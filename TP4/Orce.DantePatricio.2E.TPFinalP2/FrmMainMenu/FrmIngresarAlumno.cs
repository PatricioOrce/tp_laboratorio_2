using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmInicio
{
    public partial class FrmIngresarAlumno : Form
    {
        List<Alumno> alumnos;
        public FrmIngresarAlumno()
        {
            InitializeComponent();
            alumnos = DataBase.ImportFromDB();
        }
        private void FrmIngresarAlumno_Load(object sender, EventArgs e)
        {
            cmbGenero.DataSource = Enum.GetValues(typeof(EGenero));
            cmbSector.DataSource = Enum.GetValues(typeof(ESector));
            cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
            cmbOrientacion.DataSource = Enum.GetValues(typeof(EOrientacion));
            FillDataGrid();
        }
        /// <summary>
        /// Rellena la informacion de un datagridview con la informacion de una lista enviada por parametro.
        /// </summary>
        /// <param name="lista"></param>
        private async void FillDataGrid()
        {
            await Task.Run(() =>
            {
                ActualizarDB();
                if(dtgvAlumnos.InvokeRequired)
                {
                    dtgvAlumnos.BeginInvoke((MethodInvoker)(() =>
                    {
                        dtgvAlumnos.Rows.Clear();
                        int n;
                        foreach (Alumno item in this.alumnos)
                        {
                            n = dtgvAlumnos.Rows.Add();
                            dtgvAlumnos.Rows[n].Cells[0].Value = item.Nombre;
                            dtgvAlumnos.Rows[n].Cells[1].Value = item.Apellido;
                            dtgvAlumnos.Rows[n].Cells[2].Value = item.Edad;
                            dtgvAlumnos.Rows[n].Cells[3].Value = item.Genero;
                            dtgvAlumnos.Rows[n].Cells[4].Value = item.Sector;
                            dtgvAlumnos.Rows[n].Cells[5].Value = item.Turno;
                            dtgvAlumnos.Rows[n].Cells[6].Value = item.Orientacion;
                        }
                    }));
                }
                else
                {
                    dtgvAlumnos.Rows.Clear();
                    int n;
                    foreach (Alumno item in this.alumnos)
                    {
                        n = dtgvAlumnos.Rows.Add();
                        dtgvAlumnos.Rows[n].Cells[0].Value = item.Nombre;
                        dtgvAlumnos.Rows[n].Cells[1].Value = item.Apellido;
                        dtgvAlumnos.Rows[n].Cells[2].Value = item.Edad;
                        dtgvAlumnos.Rows[n].Cells[3].Value = item.Genero;
                        dtgvAlumnos.Rows[n].Cells[4].Value = item.Sector;
                        dtgvAlumnos.Rows[n].Cells[5].Value = item.Turno;
                        dtgvAlumnos.Rows[n].Cells[6].Value = item.Orientacion;
                    }
                }

            }
            );
           
        }
        /// <summary>
        /// Ingreso un alumno nuevo a la lista oficial y lo agrego a la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno.Created += FillDataGrid;
                Alumno.Created += () => MessageBox.Show("Ingresado con Exito!", "Aviso!");
                Alumno.Failed += () => MessageBox.Show("Error al ingresar Alumno!", "Aviso!");
                Alumno.IngresarAlumno(new Alumno(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), (EGenero)cmbGenero.SelectedItem,
                            (ESector)cmbSector.SelectedItem, (ETurno)cmbTurno.SelectedItem, (EOrientacion)cmbOrientacion.SelectedItem));
            }
            catch (InvalidExtensionException ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
            finally
            {
                Alumno.Created -= FillDataGrid;
                Alumno.Created -= () => MessageBox.Show("Ingresado con Exito!", "Aviso!");
                Alumno.Failed -= () => MessageBox.Show("Error al ingresar Alumno!", "Aviso!");
            }
        }
        /// <summary>
        /// Actualiza la base de datos con la que interactua la clase/
        /// </summary>
        private void ActualizarDB()
        {
            this.alumnos = DataBase.ImportFromDB();
        }
      
    }
}
