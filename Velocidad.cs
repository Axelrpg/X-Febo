﻿using System;
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
    public partial class Velocidad : Form
    {
        Clases.GeneralConexion generalConexion = new Clases.GeneralConexion();
        Clases.VelocidadConexion velocidadConexion = new Clases.VelocidadConexion();

        public Velocidad()
        {
            InitializeComponent();
            velocidadConexion.mostrarTabla(dtgvVelocidad);
        }

        private int segundosTranscurridos = 0; // Variable para rastrear los segundos transcurridos.

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundosTranscurridos++;
            TimeSpan tiempo = TimeSpan.FromSeconds(segundosTranscurridos);
            lblTiempo.Text = tiempo.ToString(@"hh\:mm\:ss");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Ingrese su nombre para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            else
            {
                // Iniciar el cronómetro
                timer1.Start();

                btnDetener.Enabled = true;
                btnIniciar.Enabled = false;
                btnPausar.Enabled = true;
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            btnIniciar.Enabled = true;
            btnIniciar.Text = "Reanudar";
            btnPausar.Enabled = false;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            btnDetener.Enabled = false;
            btnIniciar.Enabled = true;
            btnIniciar.Text = "Iniciar";
            btnPausar.Enabled = false;

            generalConexion.añadirFila(txtNombre.Text, "Velocidad");
            velocidadConexion.añadirFila(txtNombre.Text, lblTiempo.Text, "0");
            velocidadConexion.mostrarTabla(dtgvVelocidad);

            timer1.Stop();
            segundosTranscurridos = 0;
            TimeSpan tiempo = TimeSpan.FromSeconds(segundosTranscurridos);
            lblTiempo.Text = tiempo.ToString(@"hh\:mm\:ss");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Modos_de_juego modos_De_Juego = new Modos_de_juego();
            modos_De_Juego.Show();

            this.Hide();
        }
    }
}
