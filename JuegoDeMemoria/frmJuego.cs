using JMBackend;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace JuegoDeMemoria
{
    public partial class frmJuego : Form
    {
        List<int> numeros = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string eleccion1;
        string eleccion2;
        int intentos;
        List<PictureBox> imagenes = new List<PictureBox>();
        PictureBox imagenA;
        PictureBox imagenB;
        const int tiempoDisponible = 30;
        int cuentaRegresiva;
        bool gameOver = false;


        public frmJuego(string nombre)
        {
            InitializeComponent();
            CargarImagenes();
            lblNombre.Text = nombre + "!";


        }


        private void TimerEvent(object sender, EventArgs e)
        {
            cuentaRegresiva--;

            lblTiempoRest.Text = "Tiempo restante: " + cuentaRegresiva;

            if (cuentaRegresiva < 1)
            {
                GameOver("Se termino el tiempo, lo siento!!");

                foreach (var imagen in imagenes)
                {
                    if (imagen.Tag != null)
                    {
                        imagen.Image = Image.FromFile("imgs/" + (string)imagen.Tag + ".png");
                    }
                }
            }
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            ReiniciarJuego();
        }

        private void CargarImagenes()
        {
            int leftPos = 20;
            int topPos = 20;
            int rows = 0;

            for (int i = 0; i < 12; i++)
            {
                PictureBox newImg = new PictureBox();
                newImg.Height = 200;
                newImg.Width = 150;
                newImg.BackColor = Color.LightBlue;
                newImg.SizeMode = PictureBoxSizeMode.StretchImage;
                newImg.Click += NewImg_Click;
                imagenes.Add(newImg);

                if (rows < 4)
                {
                    rows++;
                    newImg.Left = leftPos;
                    newImg.Top = topPos;
                    this.Controls.Add(newImg);
                    leftPos = leftPos + 160;
                }

                if (rows == 4)
                {
                    leftPos = 20;
                    topPos += 210;
                    rows = 0;

                }

            }

            ReiniciarJuego();
        }

        private void NewImg_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }
            if (eleccion1 == null)
            {
                imagenA = sender as PictureBox;
                if (imagenA.Tag != null)
                {
                    imagenA.Image = SetearImagen(imagenA.Tag.ToString());
                    eleccion1 = (string)imagenA.Tag;
                }
                imagenA.Refresh();

            }
            else if (eleccion2 == null)
            {
                imagenB = sender as PictureBox;
                if (imagenB.Tag != null)
                {
                    imagenB.Image = SetearImagen(imagenB.Tag.ToString());
                    eleccion2 = (string)imagenB.Tag;


                }
                imagenB.Refresh();

                CompararImagenes(imagenA, imagenB);
            }
        }

        private Image SetearImagen(string tag)
        {
            return Image.FromFile("imgs/" + tag + ".png");
        }

        private void ReiniciarJuego()
        {
            Acciones acciones = new Acciones();
            numeros = acciones.RandomizarLista(numeros);

            for (int i = 0; i < imagenes.Count; i++)
            {
                imagenes[i].Image = Image.FromFile("imgs/world.png");
                imagenes[i].Tag = numeros[i].ToString();


            }

            intentos = 0;
            lblErrores.Text = "Errores: " + intentos;
            lblTiempoRest.Text = "Tiempo restante: " + tiempoDisponible;
            gameOver = false;
            Temporizador.Start();
            cuentaRegresiva = tiempoDisponible;
        }


        private void CompararImagenes(PictureBox A, PictureBox B)
        {
            Thread.Sleep(300);
            if (eleccion1 == eleccion2)
            {
                A.Tag = null;
                B.Tag = null;

            }
            else
            {
                intentos++;
                lblErrores.Text = "Errores: " + intentos;
                foreach (var imagen in imagenes.ToList())
                {
                    if (imagen.Tag != null)
                    {
                        imagen.Image = Image.FromFile("imgs/world.png");

                    }
                }
            }

            eleccion1 = null;
            eleccion2 = null;


            if (imagenes.All(x => x.Tag == imagenes[0].Tag))
            {
                GameOver("Felicitaciones!! GANASTE!!!");
            }
        }

        private void GameOver(string msg)
        {
            Temporizador.Stop();
            gameOver = true;
            MessageBox.Show(msg + "Click en Reiniciar Juego para jugar otra vez.", "My Memory Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Show();
            this.Close();

        }

        private void frmInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            if (this.Owner != null)
                this.Owner.Dispose();
            this.Close();
        }
    }

}
