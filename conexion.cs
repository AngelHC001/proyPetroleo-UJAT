using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.IO;


namespace GestionDeServicios
{
    class conexion
    {
        private static SqlConnection cn;
        SqlConnection cnx;

        
        public conexion()
        {
            try
            {
                cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PermiData;Data Source=ANGEL-LAP\\SQLEXPRESS;TrustServerCertificate=true");
                cnx.Open();
                //MessageBox.Show("Conectado");
                //return cnx;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }      
        }
        
   

        //usado en captura edicion
        public static SqlConnection conectar()
        {
            try
            {
                SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PermiData;Data Source=ANGEL-LAP\\SQLEXPRESS;TrustServerCertificate=true");
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cn;
        }








    }
}
