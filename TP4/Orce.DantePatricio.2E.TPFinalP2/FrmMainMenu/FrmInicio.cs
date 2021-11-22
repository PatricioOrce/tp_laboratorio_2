using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmInicio
{
    public partial class FrmInicio : Form
    {
        FrmIngresarAlumno newAlumno;
        FrmFiltradoGeneral filter;
        List<Alumno> alumnos;
        Serializer<List<Alumno>> alumnosAXML;
        Serializer<List<Alumno>> alumnosAJSON;
        static string xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Alumnos.xml");
        static string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Alumnos.json");
        public FrmInicio()
        {
            InitializeComponent();
            alumnosAXML = new Serializer<List<Alumno>>(ETipo.XML);
            alumnosAJSON = new Serializer<List<Alumno>>(ETipo.JSON);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
            this.picLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picLoading.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "loading.gif"));
            this.lblInicioText.Text = "Cargando datos de Alumnos......";
            await CargarDatos();
        }

        /// <summary>
        /// Realiza la carga de datos en un hilo paralelo, permitiendo continuar con otras tareas.
        /// </summary>
        /// <returns></returns>
        private async Task CargarDatos()
        {
            try
            {
                await Task.Run(() => {
                    alumnos = DataBase.ImportFromDB();
                    Thread.Sleep(5000);
                    if (btnData.InvokeRequired)
                    {
                        btnData.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.Refresh();
                            lblInicioText.Text = "Datos Cargados con Éxito.";
                        });
                    }
                    else
                    {
                        this.Refresh();
                        lblInicioText.Text = "Datos Cargados con Éxito.";
                    }
                    Thread.Sleep(1000);
                });
                this.picLoading.Visible = false;
                this.pictureBox1.Visible = true;
                this.btnData.Enabled = true;
                this.lblInicioText.Text = "Bienvenido, Que desea realizar?";
            }
            catch (InvalidExtensionException ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }

        }
        private async void btnNewAlumno_Click(object sender, EventArgs e)
        {
            await Task.Run(() => 
            {
                try
                {
                    newAlumno = new FrmIngresarAlumno();
                    newAlumno.ShowDialog();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnData_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                filter = new FrmFiltradoGeneral();
                filter.ShowDialog();
            });
        }
    }
}
