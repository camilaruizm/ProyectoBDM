﻿namespace ProyectoBDM
{
    partial class peliculasAdmin
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
            this.labelTituloPelicula = new System.Windows.Forms.Label();
            this.labelDirectorPelicula = new System.Windows.Forms.Label();
            this.labelSinopsisPelicula = new System.Windows.Forms.Label();
            this.labelDuracionPelicula = new System.Windows.Forms.Label();
            this.labelFecha_estrenoPelicula = new System.Windows.Forms.Label();
            this.buttonImagePelicula = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonInsertPelicula = new System.Windows.Forms.Button();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.textSinopsis = new System.Windows.Forms.TextBox();
            this.textDuracion = new System.Windows.Forms.TextBox();
            this.cantCopias = new System.Windows.Forms.Label();
            this.textCantCopis = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.actualizarAdmin = new System.Windows.Forms.Button();
            this.deleteAdmin = new System.Windows.Forms.Button();
            this.TbDirectoresid = new System.Windows.Forms.TextBox();
            this.textBoxidPelicula = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvD = new System.Windows.Forms.DataGridView();
            this.buscarD = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvD)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloPelicula
            // 
            this.labelTituloPelicula.AutoSize = true;
            this.labelTituloPelicula.Location = new System.Drawing.Point(202, 61);
            this.labelTituloPelicula.Name = "labelTituloPelicula";
            this.labelTituloPelicula.Size = new System.Drawing.Size(46, 13);
            this.labelTituloPelicula.TabIndex = 0;
            this.labelTituloPelicula.Text = "TITULO";
            // 
            // labelDirectorPelicula
            // 
            this.labelDirectorPelicula.AutoSize = true;
            this.labelDirectorPelicula.Location = new System.Drawing.Point(202, 99);
            this.labelDirectorPelicula.Name = "labelDirectorPelicula";
            this.labelDirectorPelicula.Size = new System.Drawing.Size(108, 13);
            this.labelDirectorPelicula.TabIndex = 1;
            this.labelDirectorPelicula.Text = "CODIGO DIRECTOR";
            // 
            // labelSinopsisPelicula
            // 
            this.labelSinopsisPelicula.AutoSize = true;
            this.labelSinopsisPelicula.Location = new System.Drawing.Point(202, 140);
            this.labelSinopsisPelicula.Name = "labelSinopsisPelicula";
            this.labelSinopsisPelicula.Size = new System.Drawing.Size(57, 13);
            this.labelSinopsisPelicula.TabIndex = 2;
            this.labelSinopsisPelicula.Text = "SINOPSIS";
            // 
            // labelDuracionPelicula
            // 
            this.labelDuracionPelicula.AutoSize = true;
            this.labelDuracionPelicula.Location = new System.Drawing.Point(202, 180);
            this.labelDuracionPelicula.Name = "labelDuracionPelicula";
            this.labelDuracionPelicula.Size = new System.Drawing.Size(64, 13);
            this.labelDuracionPelicula.TabIndex = 3;
            this.labelDuracionPelicula.Text = "DURACIÓN";
            // 
            // labelFecha_estrenoPelicula
            // 
            this.labelFecha_estrenoPelicula.AutoSize = true;
            this.labelFecha_estrenoPelicula.Location = new System.Drawing.Point(202, 224);
            this.labelFecha_estrenoPelicula.Name = "labelFecha_estrenoPelicula";
            this.labelFecha_estrenoPelicula.Size = new System.Drawing.Size(97, 13);
            this.labelFecha_estrenoPelicula.TabIndex = 4;
            this.labelFecha_estrenoPelicula.Text = "FECHA ESTRENO";
            // 
            // buttonImagePelicula
            // 
            this.buttonImagePelicula.Location = new System.Drawing.Point(721, 139);
            this.buttonImagePelicula.Name = "buttonImagePelicula";
            this.buttonImagePelicula.Size = new System.Drawing.Size(75, 23);
            this.buttonImagePelicula.TabIndex = 6;
            this.buttonImagePelicula.Text = "Upload";
            this.buttonImagePelicula.UseVisualStyleBackColor = true;
            this.buttonImagePelicula.Click += new System.EventHandler(this.buttonImagePelicula_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(114, 335);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(623, 182);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            // 
            // buttonInsertPelicula
            // 
            this.buttonInsertPelicula.Location = new System.Drawing.Point(215, 306);
            this.buttonInsertPelicula.Name = "buttonInsertPelicula";
            this.buttonInsertPelicula.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertPelicula.TabIndex = 8;
            this.buttonInsertPelicula.Text = "INSERTAR";
            this.buttonInsertPelicula.UseVisualStyleBackColor = true;
            this.buttonInsertPelicula.Click += new System.EventHandler(this.buttonInsertPelicula_Click);
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(322, 54);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(152, 20);
            this.textTitulo.TabIndex = 9;
            // 
            // textSinopsis
            // 
            this.textSinopsis.Location = new System.Drawing.Point(322, 133);
            this.textSinopsis.Name = "textSinopsis";
            this.textSinopsis.Size = new System.Drawing.Size(152, 20);
            this.textSinopsis.TabIndex = 11;
            // 
            // textDuracion
            // 
            this.textDuracion.Location = new System.Drawing.Point(322, 173);
            this.textDuracion.Name = "textDuracion";
            this.textDuracion.Size = new System.Drawing.Size(152, 20);
            this.textDuracion.TabIndex = 12;
            // 
            // cantCopias
            // 
            this.cantCopias.AutoSize = true;
            this.cantCopias.Location = new System.Drawing.Point(202, 280);
            this.cantCopias.Name = "cantCopias";
            this.cantCopias.Size = new System.Drawing.Size(104, 13);
            this.cantCopias.TabIndex = 14;
            this.cantCopias.Text = "CANTIDAD COPIAS";
            // 
            // textCantCopis
            // 
            this.textCantCopis.Location = new System.Drawing.Point(322, 273);
            this.textCantCopis.Name = "textCantCopis";
            this.textCantCopis.Size = new System.Drawing.Size(152, 20);
            this.textCantCopis.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // actualizarAdmin
            // 
            this.actualizarAdmin.Location = new System.Drawing.Point(385, 306);
            this.actualizarAdmin.Name = "actualizarAdmin";
            this.actualizarAdmin.Size = new System.Drawing.Size(85, 23);
            this.actualizarAdmin.TabIndex = 24;
            this.actualizarAdmin.Text = "ACTUALIZAR";
            this.actualizarAdmin.UseVisualStyleBackColor = true;
            this.actualizarAdmin.Click += new System.EventHandler(this.actualizarAdmin_Click);
            // 
            // deleteAdmin
            // 
            this.deleteAdmin.Location = new System.Drawing.Point(578, 306);
            this.deleteAdmin.Name = "deleteAdmin";
            this.deleteAdmin.Size = new System.Drawing.Size(75, 23);
            this.deleteAdmin.TabIndex = 25;
            this.deleteAdmin.Text = "ELIMINAR";
            this.deleteAdmin.UseVisualStyleBackColor = true;
            this.deleteAdmin.Click += new System.EventHandler(this.deleteAdmin_Click);
            // 
            // TbDirectoresid
            // 
            this.TbDirectoresid.Location = new System.Drawing.Point(322, 92);
            this.TbDirectoresid.Name = "TbDirectoresid";
            this.TbDirectoresid.Size = new System.Drawing.Size(152, 20);
            this.TbDirectoresid.TabIndex = 28;
            // 
            // textBoxidPelicula
            // 
            this.textBoxidPelicula.Location = new System.Drawing.Point(322, 12);
            this.textBoxidPelicula.Name = "textBoxidPelicula";
            this.textBoxidPelicula.Size = new System.Drawing.Size(152, 20);
            this.textBoxidPelicula.TabIndex = 30;
            this.textBoxidPelicula.Visible = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(385, 523);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(89, 22);
            this.btnMostrar.TabIndex = 31;
            this.btnMostrar.Text = "show";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 10);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 32;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(538, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Buscar Director";
            // 
            // dgvD
            // 
            this.dgvD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvD.Location = new System.Drawing.Point(10, 173);
            this.dgvD.Name = "dgvD";
            this.dgvD.Size = new System.Drawing.Size(114, 71);
            this.dgvD.TabIndex = 34;
            // 
            // buscarD
            // 
            this.buscarD.Location = new System.Drawing.Point(12, 99);
            this.buscarD.Name = "buscarD";
            this.buscarD.Size = new System.Drawing.Size(100, 20);
            this.buscarD.TabIndex = 35;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(17, 139);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 36;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // peliculasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.buscarD);
            this.Controls.Add(this.dgvD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.textBoxidPelicula);
            this.Controls.Add(this.TbDirectoresid);
            this.Controls.Add(this.deleteAdmin);
            this.Controls.Add(this.actualizarAdmin);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textCantCopis);
            this.Controls.Add(this.cantCopias);
            this.Controls.Add(this.textDuracion);
            this.Controls.Add(this.textSinopsis);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.buttonInsertPelicula);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonImagePelicula);
            this.Controls.Add(this.labelFecha_estrenoPelicula);
            this.Controls.Add(this.labelDuracionPelicula);
            this.Controls.Add(this.labelSinopsisPelicula);
            this.Controls.Add(this.labelDirectorPelicula);
            this.Controls.Add(this.labelTituloPelicula);
            this.Name = "peliculasAdmin";
            this.Text = "peliculasAdmin";
            this.Load += new System.EventHandler(this.peliculasAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloPelicula;
        private System.Windows.Forms.Label labelDirectorPelicula;
        private System.Windows.Forms.Label labelSinopsisPelicula;
        private System.Windows.Forms.Label labelDuracionPelicula;
        private System.Windows.Forms.Label labelFecha_estrenoPelicula;
        private System.Windows.Forms.Button buttonImagePelicula;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonInsertPelicula;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.TextBox textSinopsis;
        private System.Windows.Forms.TextBox textDuracion;
        private System.Windows.Forms.Label cantCopias;
        private System.Windows.Forms.TextBox textCantCopis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button actualizarAdmin;
        private System.Windows.Forms.Button deleteAdmin;
        private System.Windows.Forms.TextBox TbDirectoresid;
        private System.Windows.Forms.TextBox textBoxidPelicula;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvD;
        private System.Windows.Forms.TextBox buscarD;
        private System.Windows.Forms.Button buscar;
    }
}