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
            MessageBox.Show("Se debera hacer click sobre dos cartas, si ambas son iguales, \n quedaran mostrandose. Sino, volveran a darse vuelta \n Tendras 60 segundos para encontrar todas las cocincidencias", "Reglas del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
       

        
