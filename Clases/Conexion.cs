using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_Febo.Clases
{
    internal class Conexion
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=x-febo;password=;");

        public MySqlConnection setConnection()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return con;
        }

        public void closeConnection()
        {
            con.Close();
        }
    }
}
