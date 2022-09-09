namespace JuegoDeMemoria
{
    partial class frmInicial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.lblTiempoRest = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReinicio);
            this.panel1.Controls.Add(this.lblTiempoRest);
            this.panel1.Controls.Add(this.lblErrores);
            this.panel1.Location = new System.Drawing.Point(659, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 638);
            this.panel1.TabIndex = 0;
            // 
            // btnReinicio
            // 
            this.btnReinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinicio.Location = new System.Drawing.Point(38, 496);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(180, 58);
            this.btnReinicio.TabIndex = 0;
            this.btnReinicio.Text = "Reiniciar Juego";
            this.btnReinicio.UseVisualStyleBackColor = true;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // lblTiempoRest
            // 
            this.lblTiempoRest.AutoSize = true;
            this.lblTiempoRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRest.Location = new System.Drawing.Point(34, 84);
            this.lblTiempoRest.Name = "lblTiempoRest";
            this.lblTiempoRest.Size = new System.Drawing.Size(205, 24);
            this.lblTiempoRest.TabIndex = 1;
            this.lblTiempoRest.Text = "Tiempo restante: 30s";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.Location = new System.Drawing.Point(34, 49);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(179, 24);
            this.lblErrores.TabIndex = 0;
            this.lblErrores.Text = "Errores o Aciertos";
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
            this.ClientSize = new System.Drawing.Size(929, 685);
            this.Controls.Add(this.panel1);
            this.Name = "frmInicial";
            this.Text = "frmInicial";
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
    }
}