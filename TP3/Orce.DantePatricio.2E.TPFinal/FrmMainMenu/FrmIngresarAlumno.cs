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
        Serializer<List<Alumno>> alumnosAXML;
        Serializer<List<Alumno>> alumnosAJSON;
        static string xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Alumnos.xml");
        static string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Alumnos.json");
        public FrmIngresarAlumno(List<Alumno> alumnos)
        {
            InitializeComponent();
            this.alumnos = alumnos;
            alumnosAXML = new Serializer<List<Alumno>>(ETipo.XML);
            alumnosAJSON = new Serializer<List<Alumno>>(ETipo.JSON);
        }
        private void FrmIngresarAlumno_Load(object sender, EventArgs e)
        {
            cmbGenero.DataSource = Enum.GetValues(typeof(EGenero));
            cmbSector.DataSource = Enum.GetValues(typeof(ESector));
            cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
            cmbOrientacion.DataSource = Enum.GetValues(typeof(EOrientacion));
            FillDataGrid(alumnos);
        }
        /// <summary>
        /// Rellena la informacion de un datagridview con la informacion de una lista enviada por parametro.
        /// </summary>
        /// <param name="lista"></param>
        private void FillDataGrid(List<Alumno> lista)
        {
            dtgvAlumnos.Rows.Clear();
            int n;
            foreach (Alumno item in lista)
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
        /// <summary>
        /// Ingreso un alumno nuevo a la lista oficial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(Validar.IsNombre(txtNombre.Text) && Validar.IsNombre(txtApellido.Text))
            {
                alumnos.Add(new Alumno(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), (EGenero)cmbGenero.SelectedItem,
                        (ESector)cmbSector.SelectedItem, (ETurno)cmbTurno.SelectedItem, (EOrientacion)cmbOrientacion.SelectedItem));
                MessageBox.Show("Ingresado con Exito!", "Succes!");
            }
            else
            {
                MessageBox.Show("Datos Invalidos.", "Error.");
            }
            try
            {
                alumnosAXML.Escribir(alumnos, xmlPath);
                alumnosAJSON.Escribir(alumnos, jsonPath);
                FillDataGrid(alumnosAXML.Leer(xmlPath));
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
    }
}
