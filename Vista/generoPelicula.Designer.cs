﻿namespace ProyectoBDM
{
    partial class generoPelicula
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
            this.label2 = new System.Windows.Forms.Label();
            this.tipoGenero = new System.Windows.Forms.TextBox();
            this.insertarGenero = new System.Windows.Forms.Button();
            this.modificarGenero = new System.Windows.Forms.Button();
            this.eliminarGenero = new System.Windows.Forms.Button();
            this.idGenero = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showGenero = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIPO GÉNERO";
            // 
            // tipoGenero
            // 
            this.tipoGenero.Location = new System.Drawing.Point(222, 64);
            this.tipoGenero.Name = "tipoGenero";
            this.tipoGenero.Size = new System.Drawing.Size(107, 20);
            this.tipoGenero.TabIndex = 3;
            // 
            // insertarGenero
            // 
            this.insertarGenero.Location = new System.Drawing.Point(44, 126);
            this.insertarGenero.Name = "insertarGenero";
            this.insertarGenero.Size = new System.Drawing.Size(75, 23);
            this.insertarGenero.TabIndex = 4;
            this.insertarGenero.Text = "INSERTAR";
            this.insertarGenero.UseVisualStyleBackColor = true;
            this.insertarGenero.Click += new System.EventHandler(this.insertarGenero_Click);
            // 
            // modificarGenero
            // 
            this.modificarGenero.Location = new System.Drawing.Point(156, 125);
            this.modificarGenero.Name = "modificarGenero";
            this.modificarGenero.Size = new System.Drawing.Size(75, 23);
            this.modificarGenero.TabIndex = 5;
            this.modificarGenero.Text = "MODIFICAR";
            this.modificarGenero.UseVisualStyleBackColor = true;
            this.modificarGenero.Click += new System.EventHandler(this.modificarGenero_Click);
            // 
            // eliminarGenero
            // 
            this.eliminarGenero.Location = new System.Drawing.Point(270, 124);
            this.eliminarGenero.Name = "eliminarGenero";
            this.eliminarGenero.Size = new System.Drawing.Size(75, 23);
            this.eliminarGenero.TabIndex = 6;
            this.eliminarGenero.Text = "ELIMINAR";
            this.eliminarGenero.UseVisualStyleBackColor = true;
            this.eliminarGenero.Click += new System.EventHandler(this.eliminarGenero_Click);
            // 
            // idGenero
            // 
            this.idGenero.Enabled = false;
            this.idGenero.Location = new System.Drawing.Point(222, 13);
            this.idGenero.Name = "idGenero";
            this.idGenero.Size = new System.Drawing.Size(107, 20);
            this.idGenero.TabIndex = 7;
            this.idGenero.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(454, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // showGenero
            // 
            this.showGenero.Location = new System.Drawing.Point(598, 164);
            this.showGenero.Name = "showGenero";
            this.showGenero.Size = new System.Drawing.Size(75, 23);
            this.showGenero.TabIndex = 10;
            this.showGenero.Text = "SHOW";
            this.showGenero.UseVisualStyleBackColor = true;
            this.showGenero.Click += new System.EventHandler(this.showGenero_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(44, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 11;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // generoPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 199);
            this.Controls.Add(this.back);
            this.Controls.Add(this.showGenero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.idGenero);
            this.Controls.Add(this.eliminarGenero);
            this.Controls.Add(this.modificarGenero);
            this.Controls.Add(this.insertarGenero);
            this.Controls.Add(this.tipoGenero);
            this.Controls.Add(this.label2);
            this.Name = "generoPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "generoPelicula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tipoGenero;
        private System.Windows.Forms.Button insertarGenero;
        private System.Windows.Forms.Button modificarGenero;
        private System.Windows.Forms.Button eliminarGenero;
        private System.Windows.Forms.TextBox idGenero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showGenero;
        private System.Windows.Forms.Button back;
    }
}