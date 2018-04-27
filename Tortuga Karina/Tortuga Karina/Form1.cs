using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortuga_Karina
{
    public partial class Form1 : Form
    {
        Tortuga tortuga = new Tortuga();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubirPluma_Click(object sender, EventArgs e)
        {
            tortuga.subirPluma();
        }

        private void btnBajarPluma_Click(object sender, EventArgs e)
        {
            tortuga.bajarPluma();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            tortuga.Derecha();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            tortuga.Izquierda();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            try {
            tortuga.Avanzar();
            } catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtTablero.Text = tortuga.Mostrar();
        }
    }
}
