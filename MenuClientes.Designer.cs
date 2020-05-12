namespace ProyectoBDM
{
    partial class MenuClientes
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
            this.LbMenuCliente = new System.Windows.Forms.Label();
            this.BtnSolPrestamo = new System.Windows.Forms.Button();
            this.BtnPeliculas = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btEstadoDeCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbMenuCliente
            // 
            this.LbMenuCliente.AutoSize = true;
            this.LbMenuCliente.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Bold);
            this.LbMenuCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.LbMenuCliente.Location = new System.Drawing.Point(123, 40);
            this.LbMenuCliente.Name = "LbMenuCliente";
            this.LbMenuCliente.Size = new System.Drawing.Size(226, 41);
            this.LbMenuCliente.TabIndex = 4;
            this.LbMenuCliente.Text = "ELIGE UNA OPCIÓN";
            this.LbMenuCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbMenuCliente.Click += new System.EventHandler(this.LbMenuCliente_Click);
            // 
            // BtnSolPrestamo
            // 
            this.BtnSolPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.BtnSolPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.BtnSolPrestamo.FlatAppearance.BorderSize = 3;
            this.BtnSolPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSolPrestamo.Font = new System.Drawing.Font("Agency FB", 18F);
            this.BtnSolPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.BtnSolPrestamo.Location = new System.Drawing.Point(15, 167);
            this.BtnSolPrestamo.Name = "BtnSolPrestamo";
            this.BtnSolPrestamo.Size = new System.Drawing.Size(445, 55);
            this.BtnSolPrestamo.TabIndex = 10;
            this.BtnSolPrestamo.Text = "SOLICITAR PELICULA";
            this.BtnSolPrestamo.UseVisualStyleBackColor = false;
            this.BtnSolPrestamo.Click += new System.EventHandler(this.BtnSolPrestamo_Click);
            this.BtnSolPrestamo.MouseLeave += new System.EventHandler(this.BtnSolPrestamo_MouseLeave);
            this.BtnSolPrestamo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSolPrestamo_MouseMove);
            // 
            // BtnPeliculas
            // 
            this.BtnPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.BtnPeliculas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.BtnPeliculas.FlatAppearance.BorderSize = 3;
            this.BtnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPeliculas.Font = new System.Drawing.Font("Agency FB", 18F);
            this.BtnPeliculas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.BtnPeliculas.Location = new System.Drawing.Point(15, 107);
            this.BtnPeliculas.Name = "BtnPeliculas";
            this.BtnPeliculas.Size = new System.Drawing.Size(445, 55);
            this.BtnPeliculas.TabIndex = 8;
            this.BtnPeliculas.Text = "BUSCAR PELÍCULA";
            this.BtnPeliculas.UseVisualStyleBackColor = false;
            this.BtnPeliculas.Click += new System.EventHandler(this.BtnVerPeliculas_Click);
            this.BtnPeliculas.MouseLeave += new System.EventHandler(this.BtnVerPeliculas_MouseLeave);
            this.BtnPeliculas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnVerPeliculas_MouseMove);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Wingdings 2", 20F);
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.BtnSalir.Location = new System.Drawing.Point(403, -1);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 33);
            this.BtnSalir.TabIndex = 15;
            this.BtnSalir.Text = "";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.BtnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            this.BtnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSalir_MouseMove);
            // 
            // btEstadoDeCuenta
            // 
            this.btEstadoDeCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.btEstadoDeCuenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btEstadoDeCuenta.FlatAppearance.BorderSize = 3;
            this.btEstadoDeCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstadoDeCuenta.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btEstadoDeCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btEstadoDeCuenta.Location = new System.Drawing.Point(15, 228);
            this.btEstadoDeCuenta.Name = "btEstadoDeCuenta";
            this.btEstadoDeCuenta.Size = new System.Drawing.Size(445, 55);
            this.btEstadoDeCuenta.TabIndex = 16;
            this.btEstadoDeCuenta.Text = "ESTADO DE CUENTA";
            this.btEstadoDeCuenta.UseVisualStyleBackColor = false;
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(474, 299);
            this.Controls.Add(this.btEstadoDeCuenta);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnSolPrestamo);
            this.Controls.Add(this.LbMenuCliente);
            this.Controls.Add(this.BtnPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuClientes";
            this.Load += new System.EventHandler(this.MenuClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbMenuCliente;
        private System.Windows.Forms.Button BtnSolPrestamo;
        private System.Windows.Forms.Button BtnPeliculas;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btEstadoDeCuenta;
    }
}