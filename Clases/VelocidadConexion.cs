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
    internal class VelocidadConexion
    {
        public void mostrarTabla(DataGridView tablaVelocidad)
        {
            try
            {
                Conexion con = new Conexion();
                String query = "select * from velocidad order by id desc";

                tablaVelocidad.DataSource = null;

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con.setConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                tablaVelocidad.DataSource = dataTable;

                con.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos. Error: " + ex.ToString());
            }
        }

        public void añadirFila(String nombre, String tiempo, String promedio)
        {
            try
            {
                Conexion con = new Conexion();
                String query = "insert into velocidad (nombre, tiempo, promedio)" +
                    "values ('" + nombre + "', '" + tiempo + "', '" + promedio + "');";

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
