﻿namespace ProyectoBDM
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
            this.BtnVerPeliculas = new System.Windows.Forms.Button();
            this.BtnEstadoCuenta = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
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
            this.LbMenuCliente.Text = "ELIGE UNA OPCION";
            this.LbMenuCliente.Click += new System.EventHandler(this.LbMenuCliente_Click);
            // 
            // BtnSolPrestamo
            // 
            this.BtnSolPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSolPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSolPrestamo.FlatAppearance.BorderSize = 3;
            this.BtnSolPrestamo.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSolPrestamo.Location = new System.Drawing.Point(289, 95);
            this.BtnSolPrestamo.Name = "BtnSolPrestamo";
            this.BtnSolPrestamo.Size = new System.Drawing.Size(257, 115);
            this.BtnSolPrestamo.TabIndex = 10;
            this.BtnSolPrestamo.Text = "Solicitar un Prestamo";
            this.BtnSolPrestamo.UseVisualStyleBackColor = false;
            this.BtnSolPrestamo.Click += new System.EventHandler(this.BtnSolPrestamo_Click);
            this.BtnSolPrestamo.MouseLeave += new System.EventHandler(this.BtnSolPrestamo_MouseLeave);
            this.BtnSolPrestamo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSolPrestamo_MouseMove);
            // 
            // BtnVerPeliculas
            // 
            this.BtnVerPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVerPeliculas.FlatAppearance.BorderSize = 0;
            this.BtnVerPeliculas.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerPeliculas.Location = new System.Drawing.Point(26, 95);
            this.BtnVerPeliculas.Name = "BtnVerPeliculas";
            this.BtnVerPeliculas.Size = new System.Drawing.Size(257, 115);
            this.BtnVerPeliculas.TabIndex = 8;
            this.BtnVerPeliculas.Text = "Buscar Peliculas";
            this.BtnVerPeliculas.UseVisualStyleBackColor = false;
            this.BtnVerPeliculas.Click += new System.EventHandler(this.BtnVerPeliculas_Click);
            this.BtnVerPeliculas.MouseLeave += new System.EventHandler(this.BtnVerPeliculas_MouseLeave);
            this.BtnVerPeliculas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnVerPeliculas_MouseMove);
            // 
            // BtnEstadoCuenta
            // 
            this.BtnEstadoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnEstadoCuenta.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstadoCuenta.Location = new System.Drawing.Point(26, 216);
            this.BtnEstadoCuenta.Name = "BtnEstadoCuenta";
            this.BtnEstadoCuenta.Size = new System.Drawing.Size(520, 96);
            this.BtnEstadoCuenta.TabIndex = 9;
            this.BtnEstadoCuenta.Text = "ESTADO De CUENTA";
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
            this.BtnSalir.Location = new System.Drawing.Point(496, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 27);
            this.BtnSalir.TabIndex = 15;
            this.BtnSalir.Text = "";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.BtnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            this.BtnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSalir_MouseMove);
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(571, 340);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEstadoCuenta);
            this.Controls.Add(this.BtnSolPrestamo);
            this.Controls.Add(this.LbMenuCliente);
            this.Controls.Add(this.BtnVerPeliculas);
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
        private System.Windows.Forms.Button BtnVerPeliculas;
        private System.Windows.Forms.Button BtnEstadoCuenta;
        private System.Windows.Forms.Button BtnSalir;
    }
}