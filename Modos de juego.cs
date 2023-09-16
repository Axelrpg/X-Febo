using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_Febo
{
    public partial class Modos_de_juego : Form
    {
        public Modos_de_juego()
        {
            InitializeComponent();
        }

        private void Modos_de_juego_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();

            this.Hide();
        }

        private void btnRegresar_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnMemoria_Click(object sender, EventArgs e)
        {
            Memoria memoria = new Memoria();
            memoria.Show();

            this.Hide();
        }

        private void btnValoraciones_Click(object sender, EventArgs e)
        {
            General general = new General();
            general.Show();

            this.Hide();
        }

        private void btnVelocidad_Click(object sender, EventArgs e)
        {
            Velocidad velocidad = new Velocidad();
            velocidad.Show();

            this.Hide();
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Aleatorio aleatorio = new Aleatorio();
            aleatorio.Show();

            this.Hide();
        }

        private void btnSecuencia_Click(object sender, EventArgs e)
        {
            Secuencia secuencia = new Secuencia();
            secuencia.Show();

            this.Hide();
        }
    }
}
