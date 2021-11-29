using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FrmInicio
{
    public partial class FrmFiltradoGeneral : Form
    {
        List<Alumno> alumnos;
        public FrmFiltradoGeneral()
        {
            InitializeComponent();
            try
            {
                this.alumnos = DataBase.ImportFromDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
        private void FrmFiltradoGeneral_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.AddRange(Enum.GetNames(typeof(EGenero)));
            cmbSector.Items.AddRange(Enum.GetNames(typeof(ESector)));
            cmbTurno.Items.AddRange(Enum.GetNames(typeof(ETurno)));
            cmbOrientacion.Items.AddRange(Enum.GetNames(typeof(EOrientacion)));
            rbtnShowInScreen.Checked = true;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            bool allow = false;
            List<Alumno> alumnos = new List<Alumno>();
            ActualizarDB();
            if (cmbGenero.SelectedItem != null && cmbSector.SelectedItem != null && cmbTurno.SelectedItem != null && cmbOrientacion != null)
            {

                try
                {
                    alumnos = Filtro.FilterBy(this.alumnos, (EGenero)cmbGenero.SelectedIndex,
                                                        (ESector)cmbSector.SelectedIndex,
                                                        (ETurno)cmbTurno.SelectedIndex,
                                                        (EOrientacion)cmbOrientacion.SelectedIndex);
                    MessageBox.Show($"El porcentaje de esta caracterista es del {Analizar<Alumno>.CalcularPorcentaje(this.alumnos, alumnos)}% en relacion al total.");
                    allow = true;
                }
                catch (EmptyListException ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
                
            }
            else if (cmbGenero.SelectedItem != null && cmbSector.SelectedItem != null && cmbTurno.SelectedItem != null && cmbOrientacion.SelectedItem == null)
            {
                try
                {
                    alumnos = Filtro.FilterBy(this.alumnos, (EGenero)cmbGenero.SelectedIndex,
                                                                           (ESector)cmbSector.SelectedIndex,
                                                                           (ETurno)cmbTurno.SelectedIndex);
                    MessageBox.Show($"El porcentaje de esta caracterista es del {Analizar<Alumno>.CalcularPorcentaje(this.alumnos, alumnos)}% en relacion al total.");
                    allow = true;
                }
                catch (EmptyListException ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }

            }
            else if (cmbGenero.SelectedItem != null && cmbSector.SelectedItem != null && cmbTurno.SelectedItem == null && cmbOrientacion.SelectedItem == null)
            {
                try
                {
                    alumnos = Filtro.FilterBy(this.alumnos, (EGenero)cmbGenero.SelectedIndex,
                                                            (ESector)cmbSector.SelectedIndex);
                    MessageBox.Show($"El porcentaje de esta caracterista es del {Analizar<Alumno>.CalcularPorcentaje(this.alumnos, alumnos)}% en relacion al total.");
                    allow = true;
                }
                catch (EmptyListException ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }

            }
            else if (cmbGenero.SelectedItem != null && cmbSector.SelectedItem == null && cmbTurno.SelectedItem == null && cmbOrientacion.SelectedItem == null)
            {
                try
                {
                    alumnos = Filtro.FilterBy(this.alumnos, (EGenero)cmbGenero.SelectedIndex);
                    MessageBox.Show($"El porcentaje de esta caracterista es del {Analizar<Alumno>.CalcularPorcentaje(this.alumnos, alumnos)}% en relacion al total.");
                    allow = true;
                }
                catch (EmptyListException ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }

            }
            else if (cmbGenero.SelectedItem == null && cmbSector.SelectedItem != null && cmbTurno.SelectedItem == null && cmbOrientacion.SelectedItem == null)
            {
                try
                {
                    alumnos = Filtro.FilterBy(this.alumnos, (ESector)cmbSector.SelectedIndex);
                    MessageBox.Show($"El porcentaje de esta caracterista es del {Analizar<Alumno>.CalcularPorcentaje(this.alumnos, alumnos)}% en relacion al total.");
                    allow = true;
                }
                catch (EmptyListException ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }

            }
            else if (cmbGenero.SelectedItem == null && cmbSector.SelectedItem == null && cmbTurno.SelectedItem != null && cmbOrientacion.SelectedItem == null)
            {
                try
                {
                    alumnos = Filtro.FilterBy(this.alumnos, (ETurno)cmbTurno.SelectedIndex);
                    MessageBox.Show($"El porcentaje de esta caracterista es del {Analizar<Alumno>.CalcularPorcentaje(this.alumnos, alumnos)}% en relacion al total.");
                    allow = true;
                }
                catch (EmptyListException ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }

            }
            else if (cmbGenero.SelectedItem == null && cmbSector.SelectedItem == null && cmbTurno.SelectedItem == null && cmbOrientacion.SelectedItem != null)
            {
                try
                {
                    alumnos = Filtro.FilterBy(this.alumnos, (EOrientacion)cmbOrientacion.SelectedIndex);
                    MessageBox.Show($"El porcentaje de esta caracterista es del {Analizar<Alumno>.CalcularPorcentaje(this.alumnos, alumnos)}% en relacion al total.");
                    allow = true;
                }
                catch (EmptyListException ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Lamentablemente este filtro no esta soportado, se implementara en futuras actualizaciones!", "Error Inusual.");
            }
            if(allow)
            {
                if (rbtnShowInScreen.Checked)
                {
                    FillDataGrid(alumnos);
                }
                else if (rbtnShowInFile.Checked)
                {
                    SaveTextFile(alumnos, path);
                    MessageBox.Show($"El archivo se guardo con exito!\nRuta de guardado: {path}");
                }
                else
                {
                    FillDataGrid(alumnos);
                    SaveTextFile(alumnos, path);
                    MessageBox.Show($"El archivo se guardo con exito!\nRuta de guardado: {path}");
                }
                if (cboxXML.Checked && cboxJson.Checked)
                {

                    SaveXmlFile(alumnos, path);
                    SaveJsonFile(alumnos, path);
                    MessageBox.Show($"El archivo se guardo con exito!\nRuta de guardado: {path}");
                }
                else if (cboxXML.Checked && !cboxJson.Checked)
                {
                    SaveXmlFile(alumnos, path);
                    MessageBox.Show($"El archivo se guardo con exito!\nRuta de guardado: {path}");
                }
                else if (!cboxXML.Checked && cboxJson.Checked)
                {
                    SaveJsonFile(alumnos, path);
                    MessageBox.Show($"El archivo se guardo con exito!\nRuta de guardado: {path}");
                }
            }
        }
        /// <summary>
        /// Escribe la informacion de una lista en una ruta indicada por parametro.
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="path"></param>
        private void SaveTextFile(List<Alumno> lista, string path)
        {
            string fullPath;
            StringBuilder sb = new StringBuilder();
            Random randNumerForPath = new Random();
            ArchivoText alumnATxT = new ArchivoText();
            try
            {
                foreach (Alumno item in lista)
                {
                    sb.AppendLine($"{item.Nombre};{item.Apellido};{item.Edad};{item.Genero};{item.Sector};{item.Turno};{item.Orientacion}");
                }
                fullPath = Path.Combine(path, $"Info_{DateTime.Now.ToString("fffffff")}_{randNumerForPath.Next(1000, 9999)}.csv");
                alumnATxT.Escribir(sb.ToString(), fullPath);
            }
            catch (EmptyListException ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
        /// <summary>
        /// Serializa y escribe en un archivo xml la informacion de una lista enviada por parametro.
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="path"></param>
        private void SaveXmlFile(List<Alumno> lista, string path)
        {
            Random randNumerForPath = new Random();
            string fullPath = Path.Combine(path, $"AlumnosLogXml_{DateTime.Now.ToString("fffffff")}_{randNumerForPath.Next(1000, 9999)}.xml");
            Serializer<List<Alumno>> serializador = new Serializer<List<Alumno>>(ETipo.XML);
            try
            {
                 serializador.Escribir(lista, fullPath);
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
        /// <summary>
        /// Serializa y escribe en un archivo json la informacion de una lista enviada por parametro.
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="path"></param>
        private void SaveJsonFile(List<Alumno> lista, string path)
        {
            Random randNumerForPath = new Random();
            string fullPath = Path.Combine(path, $"AlumnosLogJson_{DateTime.Now.ToString("fffffff")}_{randNumerForPath.Next(1000, 9999)}.json");
            Serializer<List<Alumno>> serializador = new Serializer<List<Alumno>>(ETipo.JSON);
            try
            {
                serializador.Escribir(lista, fullPath);
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
        /// <summary>
        /// Rellena un datagridview con la informacion de una lista enviada.
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

        public void ActualizarDB()
        {
            try
            {
                this.alumnos = DataBase.ImportFromDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }

        }
    }
}
