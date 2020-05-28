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
            this.BtnEstadoCuenta = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbMenuCliente
            // 
            this.LbMenuCliente.AutoSize = true;
            this.LbMenuCliente.Font = new System.Drawing.Font("Bebas Neue", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMenuCliente.ForeColor = System.Drawing.Color.Crimson;
            this.LbMenuCliente.Location = new System.Drawing.Point(143, 19);
            this.LbMenuCliente.Name = "LbMenuCliente";
            this.LbMenuCliente.Size = new System.Drawing.Size(281, 61);
            this.LbMenuCliente.TabIndex = 4;
            this.LbMenuCliente.Text = "ELIGE UNA OPCIóN";
            this.LbMenuCliente.Click += new System.EventHandler(this.LbMenuCliente_Click);
            // 
            // BtnSolPrestamo
            // 
            this.BtnSolPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSolPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSolPrestamo.FlatAppearance.BorderSize = 3;
            this.BtnSolPrestamo.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSolPrestamo.Location = new System.Drawing.Point(26, 95);
            this.BtnSolPrestamo.Name = "BtnSolPrestamo";
            this.BtnSolPrestamo.Size = new System.Drawing.Size(520, 115);
            this.BtnSolPrestamo.TabIndex = 10;
            this.BtnSolPrestamo.Text = "Buscar películas y Solicitar Prestamos";
            this.BtnSolPrestamo.UseVisualStyleBackColor = false;
            this.BtnSolPrestamo.Click += new System.EventHandler(this.BtnSolPrestamo_Click);
            this.BtnSolPrestamo.MouseLeave += new System.EventHandler(this.BtnSolPrestamo_MouseLeave);
            this.BtnSolPrestamo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSolPrestamo_MouseMove);
            // 
            // BtnEstadoCuenta
            // 
            this.BtnEstadoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnEstadoCuenta.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstadoCuenta.Location = new System.Drawing.Point(26, 216);
            this.BtnEstadoCuenta.Name = "BtnEstadoCuenta";
            this.BtnEstadoCuenta.Size = new System.Drawing.Size(520, 115);
            this.BtnEstadoCuenta.TabIndex = 9;
            this.BtnEstadoCuenta.Text = "Ver ESTADO De CUENTA";
            this.BtnEstadoCuenta.UseVisualStyleBackColor = false;
            this.BtnEstadoCuenta.Click += new System.EventHandler(this.BtnPagarMultas_Click);
            this.BtnEstadoCuenta.MouseLeave += new System.EventHandler(this.BtnPagarMultas_MouseLeave);
            this.BtnEstadoCuenta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnPagarMultas_MouseMove);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Wingdings 2", 17F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.BtnSalir.Location = new System.Drawing.Point(471, 12);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 27);
            this.BtnSalir.TabIndex = 15;
            this.BtnSalir.Text = "";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.BtnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            this.BtnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSalir_MouseMove);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(12, 12);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(113, 37);
            this.btnPerfil.TabIndex = 16;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(566, 357);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEstadoCuenta);
            this.Controls.Add(this.BtnSolPrestamo);
            this.Controls.Add(this.LbMenuCliente);
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
        private System.Windows.Forms.Button BtnEstadoCuenta;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnPerfil;
    }
}