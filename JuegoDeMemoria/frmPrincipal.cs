using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDeMemoria
{


    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {

            var juego = new frmInicial(txtJugador.Text);
            juego.Show();
            this.Hide();


                
        }

        private void btnReglas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para jugar, se deberá hacer click sobre dos cartas, si ambas son iguales, quedarán mostrándose por un momento. Sino, volverán a darse vuelta \n\n Tendrás 30 segundos para encontrar todas las coincidencias.\n\n Mucha suerte! ", "Reglas del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnJugar.Enabled = false;
        }

        private void txtJugador_TextChanged(object sender, EventArgs e)
        {
            if (!txtJugador.Text.Equals(""))
            {
                btnJugar.Enabled = true;
            }
            else
            {
                btnJugar.Enabled=false;
            }
        }
    }
}
       

        
