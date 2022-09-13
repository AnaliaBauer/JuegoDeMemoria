namespace JuegoDeMemoria
{
    partial class frmJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJuego));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHola = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.lblTiempoRest = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.lblHola);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.btnReinicio);
            this.panel1.Controls.Add(this.lblTiempoRest);
            this.panel1.Controls.Add(this.lblErrores);
            this.panel1.Location = new System.Drawing.Point(659, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 649);
            this.panel1.TabIndex = 0;
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.BackColor = System.Drawing.Color.PowderBlue;
            this.lblHola.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHola.Location = new System.Drawing.Point(34, 34);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(72, 30);
            this.lblHola.TabIndex = 3;
            this.lblHola.Text = "Hola";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVolver.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(39, 509);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(173, 62);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver a la ventana de Inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.LightBlue;
            this.lblNombre.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(34, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 30);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Hola ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReinicio
            // 
            this.btnReinicio.BackColor = System.Drawing.Color.PowderBlue;
            this.btnReinicio.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinicio.Location = new System.Drawing.Point(39, 577);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(180, 58);
            this.btnReinicio.TabIndex = 0;
            this.btnReinicio.Text = "Reiniciar Juego";
            this.btnReinicio.UseVisualStyleBackColor = false;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // lblTiempoRest
            // 
            this.lblTiempoRest.AutoSize = true;
            this.lblTiempoRest.BackColor = System.Drawing.Color.LightBlue;
            this.lblTiempoRest.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRest.Location = new System.Drawing.Point(35, 168);
            this.lblTiempoRest.Name = "lblTiempoRest";
            this.lblTiempoRest.Size = new System.Drawing.Size(215, 23);
            this.lblTiempoRest.TabIndex = 1;
            this.lblTiempoRest.Text = "Tiempo restante: 30s";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.BackColor = System.Drawing.Color.PowderBlue;
            this.lblErrores.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.Location = new System.Drawing.Point(35, 133);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(97, 23);
            this.lblErrores.TabIndex = 0;
            this.lblErrores.Text = "Errores: \r\n";
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1072, 685);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicial";
            this.Text = "Memory Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicial_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTiempoRest;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Button btnReinicio;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblHola;
    }
}