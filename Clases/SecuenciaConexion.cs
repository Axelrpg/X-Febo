using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_Febo.Clases
{
    internal class SecuenciaConexion
    {
        public void mostrarTabla(DataGridView tablaSecuencia)
        {
            try
            {
                Conexion con = new Conexion();
                String query = "select * from secuencia order by id desc";

                tablaSecuencia.DataSource = null;

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con.setConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                tablaSecuencia.DataSource = dataTable;

                con.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos. Error: " + ex.ToString());
            }
        }

        public void añadirFila(String nombre, String tiempo)
        {
            try
            {
                Conexion con = new Conexion();
                String query = "insert into secuencia (nombre, tiempo)" +
                    "values ('" + nombre + "', '" + tiempo + "');";

                MySqlCommand command = new MySqlCommand(query, con.setConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                }

                con.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se añadió la fila. Error: " + ex.ToString());
            }
        }
    }
}
