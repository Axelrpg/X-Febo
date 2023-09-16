using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using X_Febo.Clases;

namespace X_Febo
{
    public partial class General : Form
    {
        GeneralConexion generalConexion = new GeneralConexion();
        
        public General()
        {
            InitializeComponent();
            generalConexion.mostrarTabla(dtgvGeneral);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Modos_de_juego modos_De_Juego = new Modos_de_juego();
            modos_De_Juego.Show();

            this.Hide();
        }
    }
}
