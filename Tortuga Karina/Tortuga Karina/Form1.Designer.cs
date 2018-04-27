namespace Tortuga_Karina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTablero = new System.Windows.Forms.TextBox();
            this.btnSubirPluma = new System.Windows.Forms.Button();
            this.btnBajarPluma = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTablero
            // 
            this.txtTablero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablero.Location = new System.Drawing.Point(12, 119);
            this.txtTablero.Multiline = true;
            this.txtTablero.Name = "txtTablero";
            this.txtTablero.Size = new System.Drawing.Size(534, 396);
            this.txtTablero.TabIndex = 0;
            // 
            // btnSubirPluma
            // 
            this.btnSubirPluma.Location = new System.Drawing.Point(12, 38);
            this.btnSubirPluma.Name = "btnSubirPluma";
            this.btnSubirPluma.Size = new System.Drawing.Size(78, 58);
            this.btnSubirPluma.TabIndex = 1;
            this.btnSubirPluma.Text = "Subir pluma";
            this.btnSubirPluma.UseVisualStyleBackColor = true;
            this.btnSubirPluma.Click += new System.EventHandler(this.btnSubirPluma_Click);
            // 
            // btnBajarPluma
            // 
            this.btnBajarPluma.Location = new System.Drawing.Point(114, 38);
            this.btnBajarPluma.Name = "btnBajarPluma";
            this.btnBajarPluma.Size = new System.Drawing.Size(80, 58);
            this.btnBajarPluma.TabIndex = 2;
            this.btnBajarPluma.Text = "Bajar Pluma";
            this.btnBajarPluma.UseVisualStyleBackColor = true;
            this.btnBajarPluma.Click += new System.EventHandler(this.btnBajarPluma_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(219, 67);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(80, 29);
            this.btnIzquierda.TabIndex = 3;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(219, 38);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(80, 29);
            this.btnDerecha.TabIndex = 4;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(322, 38);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(80, 29);
            this.btnAvanzar.TabIndex = 5;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(322, 67);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(80, 29);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 542);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnBajarPluma);
            this.Controls.Add(this.btnSubirPluma);
            this.Controls.Add(this.txtTablero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTablero;
        private System.Windows.Forms.Button btnSubirPluma;
        private System.Windows.Forms.Button btnBajarPluma;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnMostrar;
    }
}

