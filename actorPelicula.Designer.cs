﻿namespace ProyectoBDM
{
    partial class actorPelicula
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
            this.insertarAP = new System.Windows.Forms.Button();
            this.modificarAP = new System.Windows.Forms.Button();
            this.eliminarAP = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idParticipacion = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PELÍCULA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ACTRIZ-ACTOR";
            // 
            // insertarAP
            // 
            this.insertarAP.Location = new System.Drawing.Point(235, 144);
            this.insertarAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insertarAP.Name = "insertarAP";
            this.insertarAP.Size = new System.Drawing.Size(100, 28);
            this.insertarAP.TabIndex = 2;
            this.insertarAP.Text = "INSERTAR";
            this.insertarAP.UseVisualStyleBackColor = true;
            this.insertarAP.Click += new System.EventHandler(this.insertarAP_Click);
            // 
            // modificarAP
            // 
            this.modificarAP.Location = new System.Drawing.Point(484, 144);
            this.modificarAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modificarAP.Name = "modificarAP";
            this.modificarAP.Size = new System.Drawing.Size(100, 28);
            this.modificarAP.TabIndex = 3;
            this.modificarAP.Text = "MODIFICAR";
            this.modificarAP.UseVisualStyleBackColor = true;
            this.modificarAP.Click += new System.EventHandler(this.modificarAP_Click);
            // 
            // eliminarAP
            // 
            this.eliminarAP.Location = new System.Drawing.Point(740, 144);
            this.eliminarAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eliminarAP.Name = "eliminarAP";
            this.eliminarAP.Size = new System.Drawing.Size(100, 28);
            this.eliminarAP.TabIndex = 4;
            this.eliminarAP.Text = "ELIMINAR";
            this.eliminarAP.UseVisualStyleBackColor = true;
            this.eliminarAP.Click += new System.EventHandler(this.eliminarAP_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 217);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(813, 185);
            this.dataGridView1.TabIndex = 5;
            // 
            // idParticipacion
            // 
            this.idParticipacion.Location = new System.Drawing.Point(28, 15);
            this.idParticipacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idParticipacion.Name = "idParticipacion";
            this.idParticipacion.Size = new System.Drawing.Size(29, 22);
            this.idParticipacion.TabIndex = 6;
            this.idParticipacion.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(287, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(679, 34);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Wingdings 3", 24.5F);
            this.back.Location = new System.Drawing.Point(13, 7);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(57, 48);
            this.back.TabIndex = 9;
            this.back.Text = "";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(955, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // actorPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.idParticipacion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.eliminarAP);
            this.Controls.Add(this.modificarAP);
            this.Controls.Add(this.insertarAP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "actorPelicula";
            this.Text = "actorPelicula";
            this.Load += new System.EventHandler(this.actorPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button insertarAP;
        private System.Windows.Forms.Button modificarAP;
        private System.Windows.Forms.Button eliminarAP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idParticipacion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
    }
}