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


    //Reglas:
    /*
     * Todas las cartas inician ocultas
     * Se permiten 20 movimientos para ganar el juego
   
     * Se da vueltas la primer carta, mostrando la imagen oculta.
     * Luego se da vuelta la segunda carta, mostrando su imagen. 
     * Si ambas imagenes coinciden, las cartas son "retiradas".
     * Si las imagenes de las cartas volteadas no coinciden, se vuelven a tapar.     
     */


    public partial class frmPrincipal : Form
    {
        Bitmap imagen = new Bitmap(150, 200);
        bool t1volteada = false;  
        bool t2volteada = false;  
        bool t3volteada = false;  
        bool t4volteada = false;  
        bool t5volteada = false;  
        bool t6volteada = false;  
        bool t7volteada = false;  
        bool t8volteada = false;  
        bool t9volteada = false;  
        bool t10volteada = false;  
        bool t11volteada = false;  
        bool t12volteada = false;

        int cartasVolteadas = 0;
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

       

        private void btnReglas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\r\n     * Todas las cartas inician ocultas\r\n     * Se permiten 20 movimientos para ganar el juego\r\n     * Se da vuelta la primer carta, mostrando la imagen oculta.\r\n     * Luego se da vuelta la segunda carta, mostrando su imagen. \r\n     * Si ambas imagenes coinciden, las cartas seran retiradas.\r\n     * Si las imagenes de las cartas volteadas no coinciden,\r\n      se daran vuelta nuevamente hasta encontrar coincidencia.",
               "Reglas de Memory Game",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblTarjeta1_Click(object sender, EventArgs e)
        {


            if (!t1volteada)
            {
                lblTarjeta1.Tag = "Avion";
                lblTarjeta1.Image = Properties.Resources.TarjetaAvion;
                t1volteada = true;
                cartasVolteadas++;

                if (cartasVolteadas == 1)
                {
                    if (lblTarjeta1.Tag == lblTarjeta4.Tag)
                    {
                        lblTarjeta1.Visible = false;
                        lblTarjeta4.Visible = false;
                        cartasVolteadas = 0;

                    }
              
                }

            }

        }

        private void lblTarjeta2_Click(object sender, EventArgs e)
        {
            if (!t2volteada)
            {

                lblTarjeta2.Image = Properties.Resources.TarjetaCamara;
                t2volteada = true;
                cartasVolteadas++;

            }
        }

        private void lblTarjeta3_Click(object sender, EventArgs e)
        {
            if (!t3volteada)
            {

                lblTarjeta3.Image = Properties.Resources.TarjetaValijas;
                t3volteada = true;
                cartasVolteadas++;

            }
        }

        private void lblTarjeta4_Click(object sender, EventArgs e)
        {
            if (!t4volteada)
            {
                lblTarjeta4.Tag = "Avion";
                lblTarjeta4.Image = Properties.Resources.TarjetaAvion;
                t4volteada = true;
                cartasVolteadas++;

            }
            if (cartasVolteadas == 2)
            {
                if (lblTarjeta4.Tag == lblTarjeta1.Tag)
                {
                    lblTarjeta4.Visible = false;
                    lblTarjeta1.Visible = false;

                }
            }
            
        }

        private void lblTarjeta5_Click(object sender, EventArgs e)
        {
            if (!t5volteada)
            {

                lblTarjeta5.Image = Properties.Resources.TarjetaUbicacion;
                t5volteada = true;
                cartasVolteadas++;

            }
        }

        private void lblTarjeta6_Click(object sender, EventArgs e)
        {
            if (!t6volteada)
            {

                lblTarjeta6.Image = Properties.Resources.TarjetaPasaporte;
                t6volteada = true;
                cartasVolteadas++;

            }
        }

        private void lblTarjeta7_Click(object sender, EventArgs e)
        {
            if (!t7volteada)
            {

                lblTarjeta7.Image = Properties.Resources.TarjetaValijas;
                t7volteada = true;
                cartasVolteadas++;

            }
        }

        private void lblTarjeta8_Click(object sender, EventArgs e)
        {
            if (!t8volteada)
            {

                lblTarjeta8.Image = Properties.Resources.TarjetaCamara;
                t8volteada = true;
                cartasVolteadas++;

            }
        }

        private void lblTarjeta9_Click(object sender, EventArgs e)
        {
            if (!t9volteada)
            {

                lblTarjeta9.Image = Properties.Resources.TarjetaPasajes;
                t9volteada = true;
                cartasVolteadas++;

            }
        }

        private void lblTarjeta10_Click(object sender, EventArgs e)
        {
            if (!t10volteada)
            {

                lblTarjeta10.Image = Properties.Resources.TarjetaUbicacion;
                t10volteada = true;
                cartasVolteadas++;

            }
        }

        private void lblTarjeta11_Click(object sender, EventArgs e)
        {
            if (!t11volteada)
            {

                lblTarjeta11.Image = Properties.Resources.TarjetaPasajes;
                t11volteada = true;
                cartasVolteadas++;

            }
        }

        private void lblTarjeta12_Click(object sender, EventArgs e)
        {

            if (!t12volteada)
            {

                lblTarjeta12.Image = Properties.Resources.TarjetaPasaporte;
                t12volteada = true;
                cartasVolteadas++;

            }
            if (cartasVolteadas == 1)
            {
                //si son igual ocultarlas

                //si son distintas esperar 3 seg y volver a ocultarlas
            }

        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            cartasVolteadas = 0;

            imagen = Properties.Resources.DorsoMemory;
            lblTarjeta1.Image = imagen;
            lblTarjeta2.Image = imagen;
            lblTarjeta3.Image = imagen;
            lblTarjeta4.Image = imagen;
            lblTarjeta5.Image = imagen;
            lblTarjeta6.Image = imagen;
            lblTarjeta7.Image = imagen;
            lblTarjeta8.Image = imagen;
            lblTarjeta9.Image = imagen;
            lblTarjeta10.Image = imagen;
            lblTarjeta11.Image = imagen;
            lblTarjeta12.Image = imagen;

            t1volteada = false;
            t2volteada = false;
            t3volteada = false;
            t4volteada = false;
            t5volteada = false;
            t6volteada = false;
            t7volteada = false;
            t8volteada = false;
            t9volteada = false;
            t10volteada = false;
            t11volteada = false;
            t12volteada = false;

            lblTarjeta1.Visible = true;
            lblTarjeta4.Visible = true;


        }
    }
}
