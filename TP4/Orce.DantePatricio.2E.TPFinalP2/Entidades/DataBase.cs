using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DataBase
    {
        static string conexionStr;
        static SqlConnection conexion;
        static SqlCommand comando;
        static DataBase()
        {
            //Declaro la Conection string.
            conexionStr = @"Server=DESKTOP-7S0MC1J\SQLEXPRESS;Database=TP4PatricioOrce;Trusted_Connection=True;";
            //Establesco la conexion a mi base de datos
            conexion = new SqlConnection(conexionStr);
            //Instancio la entrada de consultas a mi base de datos
            comando = new SqlCommand();
            comando.Connection = conexion;
            //Establesco el tipo de consultas.
            comando.CommandType = System.Data.CommandType.Text;

        }

        public static List<Alumno> ImportFromDB()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM Alumnos";
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Alumno aux = new Alumno(reader["nombre"].ToString(), reader["apellido"].ToString(), int.Parse(reader["edad"].ToString()),
                                            (EGenero)int.Parse(reader["genero"].ToString()), (ESector)int.Parse(reader["sector"].ToString()),
                                            (ETurno)int.Parse(reader["turno"].ToString()), (EOrientacion)int.Parse(reader["orientacion"].ToString()));
                    alumnos.Add(aux);

                }
                return alumnos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: Hubo un problema al intentar importar los datos de la base de datos.\n{ex.Message}");
            }
            finally
            {
                conexion.Close();
            }
        }
        public static void InsertToDB(Alumno objeto)
        {
            try
            {
                conexion.Open();

                comando.CommandText = $"INSERT INTO Alumnos (nombre, apellido, edad, genero, sector, turno, orientacion)" +
                                      $"values (@nombre,@apellido,@edad,@genero,@sector,@turno,@orientacion)";
                comando.Parameters.AddWithValue("@nombre", objeto.Nombre);
                comando.Parameters.AddWithValue("@apellido", objeto.Apellido);
                comando.Parameters.AddWithValue("@edad", objeto.Edad);
                comando.Parameters.AddWithValue("@genero", objeto.Genero);
                comando.Parameters.AddWithValue("@sector", objeto.Sector);
                comando.Parameters.AddWithValue("@turno", objeto.Turno);
                comando.Parameters.AddWithValue("@orientacion", objeto.Orientacion);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static void InsertToDB(List<Alumno> listaObjeto)
        {
            int count = 0;
            try
            {
                conexion.Open();
                foreach (Alumno objeto in listaObjeto)
                {
                    count += 1;
                    comando.CommandText = $"INSERT INTO Alumnos (nombre, apellido, edad, genero, sector, turno, orientacion)" +
                                $"values (@nombre{count},@apellido{count},@edad{count},@genero{count},@sector{count},@turno{count},@orientacion{count})";
                    comando.Parameters.AddWithValue($"@nombre{count}", objeto.Nombre);
                    comando.Parameters.AddWithValue($"@apellido{count}", objeto.Apellido);
                    comando.Parameters.AddWithValue($"@edad{count}", objeto.Edad);
                    comando.Parameters.AddWithValue($"@genero{count}", objeto.Genero);
                    comando.Parameters.AddWithValue($"@sector{count}", objeto.Sector);
                    comando.Parameters.AddWithValue($"@turno{count}", objeto.Turno);
                    comando.Parameters.AddWithValue($"@orientacion{count}", objeto.Orientacion);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
