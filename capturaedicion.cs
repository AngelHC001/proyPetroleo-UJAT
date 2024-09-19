using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeServicios
{
    class capturaedicion
    {
        private static string query;
        private static int respuesta;

        public static int GuardarTab1(string[] tab)
        {
            //GUARDA LOS ELEMENTOS EXTRAIDOS EN LA CLASE "rutinas"
            respuesta = 0;
            try
            {
                using (SqlConnection con = conexion.conectar())
                {
                    query = "insert into Permiso values(";
                    for (int i = 0; i < tab.Length; i++)
                    {
                        if (tab[i] == "")
                            query += "null,";
                        else if (i == 19)
                            query += $"{int.Parse(tab[i])}, ";
                        else
                            query += $"'{tab[i]}' ,";
                    }
                    query = query.Remove(query.Length - 1);   //quita ultima coma
                    query += ");";                            //cierra consulta  

                    SqlCommand cmd = new SqlCommand(query, con);
                    respuesta = cmd.ExecuteNonQuery();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return respuesta;
        }


        public static int GuardarDelimitacion(string[] datos)
        {
            int resultado = 0;
            try
            {
                using (SqlConnection con = conexion.conectar())
                {
                    string query = "INSERT INTO Delimitacion VALUES (";
                    for (int i = 0; i < datos.Length; i++)
                    {
                        if (datos[i] == "")
                            query += "null,";
                        else
                            query += $"'{datos[i]}'" + ",";
                    }
                    query = query.Remove(query.Length - 1);
                    query += ");";

                    SqlCommand comando = new SqlCommand(query, con);
                    resultado = comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resultado;
        }

        public static int guardaTab3(string[] tab)
        {
            int res = 0;
            try
            {
                using (SqlConnection con = conexion.conectar())
                {
                    string query = "insert into Cuantificacion values(";
                    for (int i = 0; i < tab.Length; i++)
                    {
                        if (tab[i] == "")
                            query += "null,";
                        else
                            query += $"'{tab[i]}'" + ",";
                    }
                    query = query.Remove(query.Length - 1);
                    query += ");"; //cierra consulta

                    MessageBox.Show(query, $"datos introducidos: {tab.Length}");

                    SqlCommand cmd = new SqlCommand(query, con);
                    res = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return res;


        }

        public static int GuardarTab4(string[] tab)
        {
            //GUARDA LOS ELEMENTOS EXTRAIDOS EN LA CLASE "rutinas"
            int res = 0;
            try
            {
                using (SqlConnection con = conexion.conectar())
                {
                    string query = $"insert into finiquito values({int.Parse(tab[0])},"; //folio numerico
                    //fechas y observacioens   
                    for (int i = 1; i < 6; i++)
                    {
                        if (tab[i] == "")
                            query += "null,";
                        else if (i == 2)
                            query += $"{int.Parse(tab[i])},";  //num cheque numerico
                        else if (i == 5)
                            query += $"'{tab[i]}' ,";          //num cheque numerico
                        else
                            query += $"'{tab[i]}' ,"; //yyyy-mm-dd formato de la fecha
                    }
                    

                    query = query.Remove(query.Length - 1); //quita ultima coma
                    query += ");"; //cierra consulta

                    SqlCommand cmd = new SqlCommand(query, con);
                    res = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return res;
        }

        //tab5
        public static int GuardarTab5(string[] datos)
        {
            int resultado = 0;
            try
            {
                using (SqlConnection con = conexion.conectar())
                {
                    string query = "INSERT INTO EST_GESTORIA VALUES (";
                    for (int i = 0; i < datos.Length; i++)
                    {
                        if (datos[i] == "")
                            query += "null,";
                        else
                            query += $"'{datos[i]}'" + ",";
                    }
                    query = query.Remove(query.Length - 1);
                    query += ");";

                    SqlCommand comando = new SqlCommand(query, con);
                    resultado = comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resultado;
        }



        //BUSCAR REGISTRO POR FOLIO y ACTUA SEGUN LA FICHA DONDE ESTA (SELECTED INDEX)

        public static string[] buscaRegistro1(string folio, string nombreFicha)
        {
            string[] values = new string[25];

            using (SqlConnection con = conexion.conectar())
            {
                string query = $"select * from {nombreFicha} where Folio = '{folio}'";
                SqlCommand cmd = new SqlCommand(query, con);          
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    values[0] = reader.GetValue(0).ToString();
                    values[1] = reader.GetValue(1).ToString();
                    values[2] = reader.GetValue(2).ToString();
                    values[3] = reader.GetValue(3).ToString();
                    values[4] = reader.GetValue(4).ToString();
                    values[5] = reader.GetValue(5).ToString();
                    values[6] = reader.GetValue(6).ToString();
                    values[7] = reader.GetValue(7).ToString();
                    values[8] = reader.GetValue(8).ToString();
                    values[9] = reader.GetValue(9).ToString();
                    values[10] = reader.GetValue(10).ToString();
                    values[11] = reader.GetValue(11).ToString();
                    values[12] = reader.GetValue(12).ToString();
                    values[13] = reader.GetValue(13).ToString();
                    values[14] = reader.GetValue(14).ToString();
                    values[15] = reader.GetValue(15).ToString();
                    values[16] = reader.GetValue(16).ToString();
                    values[17] = reader.GetValue(17).ToString();
                    values[18] = reader.GetValue(18).ToString();
                    values[19] = reader.GetValue(19).ToString();
                    values[20] = reader.GetValue(20).ToString();
                    values[21] = reader.GetValue(21).ToString();
                    values[22] = reader.GetValue(22).ToString();
                    values[23] = reader.GetValue(23).ToString();
                    values[24] = reader.GetValue(24).ToString();
                }
                con.Close();
                return values;
            }     
        }


        public static string[] buscaRegistro2(string folio)
        {
            string[] values = new string[5];

            using (SqlConnection con = conexion.conectar())
            {
                string query = $"select * from Delimitacion where Folio = '{folio}'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    values[0] = reader.GetValue(0).ToString();
                    values[1] = reader.GetValue(1).ToString();
                    values[2] = reader.GetValue(2).ToString();
                    values[3] = reader.GetValue(3).ToString();
                    values[4] = reader.GetValue(4).ToString();
                }
                con.Close();
                return values;
            }
        }

        public static string[] buscaRegistro3(string folio)
        {
            string[] values = new string[5];

            using (SqlConnection con = conexion.conectar())
            {
                string query = $"select * from Cuantificacion where Folio = '{folio}'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    values[0] = reader.GetValue(0).ToString();
                    values[1] = reader.GetValue(1).ToString();
                    values[2] = reader.GetValue(2).ToString();
                    values[3] = reader.GetValue(3).ToString();
                    values[4] = reader.GetValue(4).ToString();
                }
                con.Close();
                return values;
            }
        }

        public static string[] buscaRegistro4(string folio)
        {
            string[] values = new string[6];

            using (SqlConnection con = conexion.conectar())
            {
                string query = $"select * from Finiquito where Folio = '{folio}'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    values[0] = reader.GetValue(0).ToString();
                    values[1] = reader.GetValue(1).ToString();
                    values[2] = reader.GetValue(2).ToString();
                    values[3] = reader.GetValue(3).ToString();
                    values[4] = reader.GetValue(4).ToString();
                    values[5] = reader.GetValue(5).ToString();
                }
                con.Close();
                return values;
            }
        }


        public static string[] buscaRegistro5(string folio)
        {
            string[] values = new string[17];

            using (SqlConnection con = conexion.conectar())
            {
                string query = $"select * from Est_Gestoria where Folio = '{folio}'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    values[0] = reader.GetValue(0).ToString();
                    values[1] = reader.GetValue(1).ToString();
                    values[2] = reader.GetValue(2).ToString();
                    values[3] = reader.GetValue(3).ToString();
                    values[4] = reader.GetValue(4).ToString();
                    values[5] = reader.GetValue(5).ToString();
                    values[6] = reader.GetValue(6).ToString();
                    values[7] = reader.GetValue(7).ToString();
                    values[8] = reader.GetValue(8).ToString();
                    values[9] = reader.GetValue(9).ToString();
                    values[10] = reader.GetValue(10).ToString();
                    values[11] = reader.GetValue(11).ToString();
                    values[12] = reader.GetValue(12).ToString();
                    values[13] = reader.GetValue(13).ToString();
                    values[14] = reader.GetValue(14).ToString();
                    values[15] = reader.GetValue(15).ToString();
                    values[16] = reader.GetValue(16).ToString();
                }
                con.Close();
                return values;
            }
        }











        public void Eliminar() //DEVUELVE BOOL?
        {
            //ESTA FUNCION RECIBE UN FOLIO

            //CONECTA A LA BD
            //CONSULTA EL FOLIO
            //ELIMINA POR FOLIO 
        }

        public void Editar() //DEVUELVE BOOL?
        {
            //BUSCA EL FOLIO
            //ENVIAR DATOS NUEVOS
        }

     

        public void Validacion()
        {



            //ESTA FUNCION RECIBE LOS DATOS DE "rutinas" Y DEVUELVE UN MENSAJE


            //SEGUN LO QUE MARCA VALIDACION DE "rutinas" DEVUELVE UN MESSAJE
        }

 

    }
}
