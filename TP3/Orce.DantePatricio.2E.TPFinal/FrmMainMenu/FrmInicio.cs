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
            alumnos = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",20,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",21,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
                new Alumno("Estevan","Quito",11,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Naturales),
                new Alumno("Camila","Baez",14,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Belen","DeJerusalen",18,EGenero.Otro,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Justin","Bibero",9,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Mauricio","Marfil",13,EGenero.Masculino,ESector.Primario, ETurno.Tarde,EOrientacion.Tecnica),
                new Alumno("Federico","Oggioni",20,EGenero.Masculino,ESector.Secundario, ETurno.Noche,EOrientacion.Economia),
                new Alumno("Lucas","Martinez",26,EGenero.Otro,ESector.Secundario, ETurno.Noche,EOrientacion.Sociales),
                new Alumno("Ezequiel","Cuticula",22,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Juan","Dinosaurio",10,EGenero.Masculino,ESector.Primario, ETurno.Tarde,EOrientacion.Naturales),
                new Alumno("Carolina","Extermidad",17,EGenero.Femenino,ESector.Secundario, ETurno.Tarde,EOrientacion.Naturales),
                new Alumno("Pedro","FrapucchinoDeDLL",16,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Tecnica),
                new Alumno("Gabriel","Lopez",19,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Sociales),
                new Alumno("Alejandro","Ledesma",11,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Naturales),
                new Alumno("Ludmila","Polimorfismo",16,EGenero.Femenino,ESector.Secundario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Hernesto","Giggliotti",17,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Sociales),
                new Alumno("Francisco","Firulais",9,EGenero.Masculino,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            alumnosAXML = new Serializer<List<Alumno>>(ETipo.XML);
            alumnosAJSON = new Serializer<List<Alumno>>(ETipo.JSON);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                alumnosAXML.Escribir(alumnos, xmlPath);
                alumnosAJSON.Escribir(alumnos, jsonPath);
                alumnos = alumnosAXML.Leer(xmlPath);
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

        private void btnNewAlumno_Click(object sender, EventArgs e)
        {
            newAlumno = new FrmIngresarAlumno(alumnos);
            newAlumno.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            filter = new FrmFiltradoGeneral(alumnos);
            filter.ShowDialog();
        }
    }
}
