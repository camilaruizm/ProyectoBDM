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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnVerPrestamos = new System.Windows.Forms.Button();
            this.BtnSolPrestamo = new System.Windows.Forms.Button();
            this.BtnPagarMultas = new System.Windows.Forms.Button();
            this.BtnVerPeliculas = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbMenuCliente
            // 
            this.LbMenuCliente.AutoSize = true;
            this.LbMenuCliente.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold);
            this.LbMenuCliente.Location = new System.Drawing.Point(191, 81);
            this.LbMenuCliente.Name = "LbMenuCliente";
            this.LbMenuCliente.Size = new System.Drawing.Size(373, 46);
            this.LbMenuCliente.TabIndex = 4;
            this.LbMenuCliente.Text = "Selecciona una opcion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnVerPrestamos);
            this.panel1.Controls.Add(this.BtnSolPrestamo);
            this.panel1.Controls.Add(this.BtnPagarMultas);
            this.panel1.Controls.Add(this.BtnVerPeliculas);
            this.panel1.Location = new System.Drawing.Point(12, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 364);
            this.panel1.TabIndex = 5;
            // 
            // BtnVerPrestamos
            // 
            this.BtnVerPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerPrestamos.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.BtnVerPrestamos.Location = new System.Drawing.Point(10, 187);
            this.BtnVerPrestamos.Name = "BtnVerPrestamos";
            this.BtnVerPrestamos.Size = new System.Drawing.Size(368, 163);
            this.BtnVerPrestamos.TabIndex = 11;
            this.BtnVerPrestamos.Text = "Prestamos Activos";
            this.BtnVerPrestamos.UseVisualStyleBackColor = true;
            this.BtnVerPrestamos.Click += new System.EventHandler(this.BtnVerPrestamos_Click);
            this.BtnVerPrestamos.MouseLeave += new System.EventHandler(this.BtnVerPrestamos_MouseLeave);
            this.BtnVerPrestamos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnVerPrestamos_MouseMove);
            // 
            // BtnSolPrestamo
            // 
            this.BtnSolPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSolPrestamo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.BtnSolPrestamo.Location = new System.Drawing.Point(384, 18);
            this.BtnSolPrestamo.Name = "BtnSolPrestamo";
            this.BtnSolPrestamo.Size = new System.Drawing.Size(368, 163);
            this.BtnSolPrestamo.TabIndex = 10;
            this.BtnSolPrestamo.Text = "Solicitar un Prestamo";
            this.BtnSolPrestamo.UseVisualStyleBackColor = true;
            this.BtnSolPrestamo.Click += new System.EventHandler(this.BtnSolPrestamo_Click);
            this.BtnSolPrestamo.MouseLeave += new System.EventHandler(this.BtnSolPrestamo_MouseLeave);
            this.BtnSolPrestamo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSolPrestamo_MouseMove);
            // 
            // BtnPagarMultas
            // 
            this.BtnPagarMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagarMultas.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.BtnPagarMultas.Location = new System.Drawing.Point(384, 187);
            this.BtnPagarMultas.Name = "BtnPagarMultas";
            this.BtnPagarMultas.Size = new System.Drawing.Size(368, 163);
            this.BtnPagarMultas.TabIndex = 9;
            this.BtnPagarMultas.Text = "Pagar Multas";
            this.BtnPagarMultas.UseVisualStyleBackColor = true;
            this.BtnPagarMultas.Click += new System.EventHandler(this.BtnPagarMultas_Click);
            this.BtnPagarMultas.MouseLeave += new System.EventHandler(this.BtnPagarMultas_MouseLeave);
            this.BtnPagarMultas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnPagarMultas_MouseMove);
            // 
            // BtnVerPeliculas
            // 
            this.BtnVerPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerPeliculas.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.BtnVerPeliculas.Location = new System.Drawing.Point(10, 18);
            this.BtnVerPeliculas.Name = "BtnVerPeliculas";
            this.BtnVerPeliculas.Size = new System.Drawing.Size(368, 163);
            this.BtnVerPeliculas.TabIndex = 8;
            this.BtnVerPeliculas.Text = "Ver Peliculas";
            this.BtnVerPeliculas.UseVisualStyleBackColor = true;
            this.BtnVerPeliculas.Click += new System.EventHandler(this.BtnVerPeliculas_Click);
            this.BtnVerPeliculas.MouseLeave += new System.EventHandler(this.BtnVerPeliculas_MouseLeave);
            this.BtnVerPeliculas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnVerPeliculas_MouseMove);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.Location = new System.Drawing.Point(711, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 27);
            this.BtnSalir.TabIndex = 15;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.BtnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            this.BtnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSalir_MouseMove);
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(786, 522);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbMenuCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuClientes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbMenuCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnVerPrestamos;
        private System.Windows.Forms.Button BtnSolPrestamo;
        private System.Windows.Forms.Button BtnPagarMultas;
        private System.Windows.Forms.Button BtnVerPeliculas;
        private System.Windows.Forms.Button BtnSalir;
    }
}