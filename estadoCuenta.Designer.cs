﻿namespace ProyectoBDM
{
    partial class estadoCuenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.showPeliculaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTADO CUENTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PELÍCULAS EN PRESTAMO";
            // 
            // dgvP
            // 
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.Location = new System.Drawing.Point(83, 99);
            this.dgvP.Name = "dgvP";
            this.dgvP.Size = new System.Drawing.Size(606, 98);
            this.dgvP.TabIndex = 2;
            // 
            // showPeliculaCliente
            // 
            this.showPeliculaCliente.Location = new System.Drawing.Point(369, 203);
            this.showPeliculaCliente.Name = "showPeliculaCliente";
            this.showPeliculaCliente.Size = new System.Drawing.Size(75, 23);
            this.showPeliculaCliente.TabIndex = 3;
            this.showPeliculaCliente.Text = "SHOW";
            this.showPeliculaCliente.UseVisualStyleBackColor = true;
            this.showPeliculaCliente.Click += new System.EventHandler(this.showPeliculaCliente_Click);
            // 
            // estadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.showPeliculaCliente);
            this.Controls.Add(this.dgvP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "estadoCuenta";
            this.Text = "estadoCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.Button showPeliculaCliente;
    }
}