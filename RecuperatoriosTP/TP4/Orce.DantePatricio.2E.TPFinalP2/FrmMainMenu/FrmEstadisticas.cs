using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMainMenu
{
    public partial class FrmEstadisticas : Form
    {
        List<Alumno> alumnos;
        public FrmEstadisticas()
        {
            InitializeComponent();
           
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            try
            {
                this.alumnos = DataBase.ImportFromDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }

            GenerarDatosEstadisticos($"Datos estadisticos de alumnos:");
            try
            {
                #region FiltroPorSector
                List<Alumno> listaPorSectorPrimario = Filtro.FilterBy(alumnos, ESector.Primario);
                GenerarDatosEstadisticos($"Alumnos en PRIMARIA %{Analizar<Alumno>.CalcularPorcentaje(alumnos, listaPorSectorPrimario)} " +
                                         $"de los cuales %{Analizar<Alumno>.CalcularPorcentaje(listaPorSectorPrimario, Filtro.FilterBy(listaPorSectorPrimario, EGenero.Masculino))}" +
                                         $" son HOMBRES, %{Analizar<Alumno>.CalcularPorcentaje(listaPorSectorPrimario, Filtro.FilterBy(listaPorSectorPrimario, EGenero.Femenino))}" +
                                         $" son MUJERES y %{Analizar<Alumno>.CalcularPorcentaje(listaPorSectorPrimario, Filtro.FilterBy(listaPorSectorPrimario, EGenero.Otro))} OTRO.");
                List<Alumno> listaPorSectorSecundario = Filtro.FilterBy(alumnos, ESector.Secundario);
                GenerarDatosEstadisticos($"Alumnos en SECUNDARIA %{Analizar<Alumno>.CalcularPorcentaje(alumnos, listaPorSectorSecundario)} " +
                                        $"de los cuales %{Analizar<Alumno>.CalcularPorcentaje(listaPorSectorSecundario, Filtro.FilterBy(listaPorSectorSecundario, EGenero.Masculino))}" +
                                        $" son HOMBRES, %{Analizar<Alumno>.CalcularPorcentaje(listaPorSectorSecundario, Filtro.FilterBy(listaPorSectorSecundario, EGenero.Femenino))}" +
                                        $" son MUJERES y %{Analizar<Alumno>.CalcularPorcentaje(listaPorSectorSecundario, Filtro.FilterBy(listaPorSectorSecundario, EGenero.Otro))} OTRO.");
                #endregion
                GenerarDatosEstadisticos("--------------------------------------------------------");
                #region FiltroPorTurno
                List<Alumno> listaPorTurnoManiana = Filtro.FilterBy(alumnos, ETurno.Maniana);
                GenerarDatosEstadisticos($"Alumnos turno MAÑANA %{Analizar<Alumno>.CalcularPorcentaje(alumnos, Filtro.FilterBy(alumnos, ETurno.Maniana))} " +
                                        $"de los cuales %{Analizar<Alumno>.CalcularPorcentaje(listaPorTurnoManiana, Filtro.FilterBy(listaPorTurnoManiana, EGenero.Masculino))}" +
                                        $" son HOMBRES, %{Analizar<Alumno>.CalcularPorcentaje(listaPorTurnoManiana, Filtro.FilterBy(listaPorTurnoManiana, EGenero.Femenino))}" +
                                        $" son MUJERES y %{Analizar<Alumno>.CalcularPorcentaje(listaPorTurnoManiana, Filtro.FilterBy(listaPorTurnoManiana, EGenero.Otro))} OTRO.");
                List<Alumno> listaPorTurnoTarde = Filtro.FilterBy(alumnos, ETurno.Tarde);
                GenerarDatosEstadisticos($"Alumnos turno TARDE %{Analizar<Alumno>.CalcularPorcentaje(alumnos, Filtro.FilterBy(alumnos, ETurno.Tarde))} " +
                                        $"de los cuales %{Analizar<Alumno>.CalcularPorcentaje(listaPorTurnoTarde, Filtro.FilterBy(alumnos, EGenero.Masculino))}" +
                                        $" son HOMBRES, %{Analizar<Alumno>.CalcularPorcentaje(listaPorTurnoTarde, Filtro.FilterBy(alumnos, EGenero.Femenino))}" +
                                        $" son MUJERES y %{Analizar<Alumno>.CalcularPorcentaje(listaPorTurnoTarde, Filtro.FilterBy(alumnos, EGenero.Otro))} OTRO.");
                List<Alumno> listaPorTurnoNoche = Filtro.FilterBy(alumnos, ETurno.Noche);
                GenerarDatosEstadisticos($"Alumnos turno NOCHE %{Analizar<Alumno>.CalcularPorcentaje(alumnos, Filtro.FilterBy(alumnos, ETurno.Noche))} " +
                                        $"de los cuales %{Analizar<Alumno>.CalcularPorcentaje(listaPorTurnoNoche, Filtro.FilterBy(listaPorTurnoNoche, EGenero.Masculino))}" +
                                        $" son HOMBRES, %{Analizar<Alumno>.CalcularPorcentaje(listaPorTurnoNoche, Filtro.FilterBy(listaPorTurnoNoche, EGenero.Femenino))}" +
                                        $" son MUJERES y %{Analizar<Alumno>.CalcularPorcentaje(listaPorTurnoNoche, Filtro.FilterBy(listaPorTurnoNoche, EGenero.Otro))} OTRO.");
                #endregion
                GenerarDatosEstadisticos("--------------------------------------------------------");
                #region FiltroPorOrientacion
                List<Alumno> listaPorSociales = Filtro.FilterBy(alumnos, EOrientacion.Sociales);
                GenerarDatosEstadisticos($"Alumnos en PRIMARIA %{Analizar<Alumno>.CalcularPorcentaje(alumnos, Filtro.FilterBy(alumnos, EOrientacion.Sociales))} " +
                                        $"de los cuales %{Analizar<Alumno>.CalcularPorcentaje(listaPorSociales, Filtro.FilterBy(listaPorSociales, EGenero.Masculino))}" +
                                        $" son HOMBRES, %{Analizar<Alumno>.CalcularPorcentaje(listaPorSociales, Filtro.FilterBy(listaPorSociales, EGenero.Femenino))}" +
                                        $" son MUJERES y %{Analizar<Alumno>.CalcularPorcentaje(listaPorSociales, Filtro.FilterBy(listaPorSociales, EGenero.Otro))} OTRO.");
                List<Alumno> listaPorNaturales = Filtro.FilterBy(alumnos, EOrientacion.Naturales);
                GenerarDatosEstadisticos($"Alumnos en PRIMARIA %{Analizar<Alumno>.CalcularPorcentaje(alumnos, Filtro.FilterBy(alumnos, EOrientacion.Naturales))} " +
                                        $"de los cuales %{Analizar<Alumno>.CalcularPorcentaje(listaPorNaturales, Filtro.FilterBy(listaPorNaturales, EGenero.Masculino))}" +
                                        $" son HOMBRES, %{Analizar<Alumno>.CalcularPorcentaje(listaPorNaturales, Filtro.FilterBy(listaPorNaturales, EGenero.Femenino))}" +
                                        $" son MUJERES y %{Analizar<Alumno>.CalcularPorcentaje(listaPorNaturales, Filtro.FilterBy(listaPorNaturales, EGenero.Otro))} OTRO.");
                List<Alumno> listaPorEconomia = Filtro.FilterBy(alumnos, EOrientacion.Economia);
                GenerarDatosEstadisticos($"Alumnos en PRIMARIA %{Analizar<Alumno>.CalcularPorcentaje(alumnos, Filtro.FilterBy(alumnos, EOrientacion.Economia))} " +
                                        $"de los cuales %{Analizar<Alumno>.CalcularPorcentaje(listaPorEconomia, Filtro.FilterBy(listaPorEconomia, EGenero.Masculino))}" +
                                        $" son HOMBRES, %{Analizar<Alumno>.CalcularPorcentaje(listaPorEconomia, Filtro.FilterBy(listaPorEconomia, EGenero.Femenino))}" +
                                        $" son MUJERES y %{Analizar<Alumno>.CalcularPorcentaje(listaPorEconomia, Filtro.FilterBy(listaPorEconomia, EGenero.Otro))} OTRO.");
                List<Alumno> listaPorTecnica = Filtro.FilterBy(alumnos, EOrientacion.Tecnica);
                GenerarDatosEstadisticos($"Alumnos en PRIMARIA %{Analizar<Alumno>.CalcularPorcentaje(alumnos, Filtro.FilterBy(alumnos, EOrientacion.Tecnica))} " +
                                        $"de los cuales %{Analizar<Alumno>.CalcularPorcentaje(listaPorTecnica, Filtro.FilterBy(listaPorTecnica, EGenero.Masculino))}" +
                                        $" son HOMBRES, %{Analizar<Alumno>.CalcularPorcentaje(listaPorTecnica, Filtro.FilterBy(listaPorTecnica, EGenero.Femenino))}" +
                                        $" son MUJERES y %{Analizar<Alumno>.CalcularPorcentaje(listaPorTecnica, Filtro.FilterBy(listaPorTecnica, EGenero.Otro))} OTRO.");

                #endregion
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
        /// Ingresa un dato ingresado por parametro a una ListBox, la cual utilizamos para mostrar datos estadisticos
        /// </summary>
        /// <param name="datoEstadistico">Dato estadistico a ingresar.</param>
        private void GenerarDatosEstadisticos(string datoEstadistico)
        {
            try
            {
                this.lstEstadisticas.Items.Add(datoEstadistico);
            }
            catch (Exception)
            {
                throw new Exception($"Hubo un error intentando mostrar los datos por pantalla.");
            }
        }
    }
}
