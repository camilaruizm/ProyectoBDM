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
            this.dgvD = new System.Windows.Forms.DataGridView();
            this.buscarD = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvD)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloPelicula
            // 
            this.labelTituloPelicula.AutoSize = true;
            this.labelTituloPelicula.Location = new System.Drawing.Point(344, 76);
            this.labelTituloPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloPelicula.Name = "labelTituloPelicula";
            this.labelTituloPelicula.Size = new System.Drawing.Size(58, 17);
            this.labelTituloPelicula.TabIndex = 0;
            this.labelTituloPelicula.Text = "TITULO";
            // 
            // labelDirectorPelicula
            // 
            this.labelDirectorPelicula.AutoSize = true;
            this.labelDirectorPelicula.Location = new System.Drawing.Point(344, 123);
            this.labelDirectorPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDirectorPelicula.Name = "labelDirectorPelicula";
            this.labelDirectorPelicula.Size = new System.Drawing.Size(138, 17);
            this.labelDirectorPelicula.TabIndex = 1;
            this.labelDirectorPelicula.Text = "CODIGO DIRECTOR";
            // 
            // labelSinopsisPelicula
            // 
            this.labelSinopsisPelicula.AutoSize = true;
            this.labelSinopsisPelicula.Location = new System.Drawing.Point(344, 174);
            this.labelSinopsisPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSinopsisPelicula.Name = "labelSinopsisPelicula";
            this.labelSinopsisPelicula.Size = new System.Drawing.Size(71, 17);
            this.labelSinopsisPelicula.TabIndex = 2;
            this.labelSinopsisPelicula.Text = "SINOPSIS";
            // 
            // labelDuracionPelicula
            // 
            this.labelDuracionPelicula.AutoSize = true;
            this.labelDuracionPelicula.Location = new System.Drawing.Point(344, 223);
            this.labelDuracionPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDuracionPelicula.Name = "labelDuracionPelicula";
            this.labelDuracionPelicula.Size = new System.Drawing.Size(80, 17);
            this.labelDuracionPelicula.TabIndex = 3;
            this.labelDuracionPelicula.Text = "DURACIÓN";
            // 
            // labelFecha_estrenoPelicula
            // 
            this.labelFecha_estrenoPelicula.AutoSize = true;
            this.labelFecha_estrenoPelicula.Location = new System.Drawing.Point(344, 277);
            this.labelFecha_estrenoPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha_estrenoPelicula.Name = "labelFecha_estrenoPelicula";
            this.labelFecha_estrenoPelicula.Size = new System.Drawing.Size(124, 17);
            this.labelFecha_estrenoPelicula.TabIndex = 4;
            this.labelFecha_estrenoPelicula.Text = "FECHA ESTRENO";
            // 
            // buttonImagePelicula
            // 
            this.buttonImagePelicula.Location = new System.Drawing.Point(1036, 172);
            this.buttonImagePelicula.Margin = new System.Windows.Forms.Padding(4);
            this.buttonImagePelicula.Name = "buttonImagePelicula";
            this.buttonImagePelicula.Size = new System.Drawing.Size(100, 28);
            this.buttonImagePelicula.TabIndex = 6;
            this.buttonImagePelicula.Text = "Upload";
            this.buttonImagePelicula.UseVisualStyleBackColor = true;
            this.buttonImagePelicula.Click += new System.EventHandler(this.buttonImagePelicula_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(260, 414);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(831, 224);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // buttonInsertPelicula
            // 
            this.buttonInsertPelicula.Location = new System.Drawing.Point(361, 378);
            this.buttonInsertPelicula.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsertPelicula.Name = "buttonInsertPelicula";
            this.buttonInsertPelicula.Size = new System.Drawing.Size(100, 28);
            this.buttonInsertPelicula.TabIndex = 8;
            this.buttonInsertPelicula.Text = "INSERTAR";
            this.buttonInsertPelicula.UseVisualStyleBackColor = true;
            this.buttonInsertPelicula.Click += new System.EventHandler(this.buttonInsertPelicula_Click);
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(504, 68);
            this.textTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(201, 22);
            this.textTitulo.TabIndex = 9;
            // 
            // textSinopsis
            // 
            this.textSinopsis.Location = new System.Drawing.Point(504, 165);
            this.textSinopsis.Margin = new System.Windows.Forms.Padding(4);
            this.textSinopsis.Name = "textSinopsis";
            this.textSinopsis.Size = new System.Drawing.Size(201, 22);
            this.textSinopsis.TabIndex = 11;
            // 
            // textDuracion
            // 
            this.textDuracion.Location = new System.Drawing.Point(504, 214);
            this.textDuracion.Margin = new System.Windows.Forms.Padding(4);
            this.textDuracion.Name = "textDuracion";
            this.textDuracion.Size = new System.Drawing.Size(201, 22);
            this.textDuracion.TabIndex = 12;
            // 
            // cantCopias
            // 
            this.cantCopias.AutoSize = true;
            this.cantCopias.Location = new System.Drawing.Point(344, 346);
            this.cantCopias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cantCopias.Name = "cantCopias";
            this.cantCopias.Size = new System.Drawing.Size(131, 17);
            this.cantCopias.TabIndex = 14;
            this.cantCopias.Text = "CANTIDAD COPIAS";
            // 
            // textCantCopis
            // 
            this.textCantCopis.Location = new System.Drawing.Point(504, 337);
            this.textCantCopis.Margin = new System.Windows.Forms.Padding(4);
            this.textCantCopis.Name = "textCantCopis";
            this.textCantCopis.Size = new System.Drawing.Size(201, 22);
            this.textCantCopis.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(504, 277);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // actualizarAdmin
            // 
            this.actualizarAdmin.Location = new System.Drawing.Point(588, 378);
            this.actualizarAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.actualizarAdmin.Name = "actualizarAdmin";
            this.actualizarAdmin.Size = new System.Drawing.Size(113, 28);
            this.actualizarAdmin.TabIndex = 24;
            this.actualizarAdmin.Text = "ACTUALIZAR";
            this.actualizarAdmin.UseVisualStyleBackColor = true;
            this.actualizarAdmin.Click += new System.EventHandler(this.actualizarAdmin_Click);
            // 
            // deleteAdmin
            // 
            this.deleteAdmin.Location = new System.Drawing.Point(845, 378);
            this.deleteAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.deleteAdmin.Name = "deleteAdmin";
            this.deleteAdmin.Size = new System.Drawing.Size(100, 28);
            this.deleteAdmin.TabIndex = 25;
            this.deleteAdmin.Text = "ELIMINAR";
            this.deleteAdmin.UseVisualStyleBackColor = true;
            this.deleteAdmin.Click += new System.EventHandler(this.deleteAdmin_Click);
            // 
            // TbDirectoresid
            // 
            this.TbDirectoresid.Location = new System.Drawing.Point(504, 114);
            this.TbDirectoresid.Margin = new System.Windows.Forms.Padding(4);
            this.TbDirectoresid.Name = "TbDirectoresid";
            this.TbDirectoresid.Size = new System.Drawing.Size(201, 22);
            this.TbDirectoresid.TabIndex = 28;
            // 
            // textBoxidPelicula
            // 
            this.textBoxidPelicula.Location = new System.Drawing.Point(504, 16);
            this.textBoxidPelicula.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxidPelicula.Name = "textBoxidPelicula";
            this.textBoxidPelicula.Size = new System.Drawing.Size(201, 22);
            this.textBoxidPelicula.TabIndex = 30;
            this.textBoxidPelicula.Visible = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(621, 645);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(119, 27);
            this.btnMostrar.TabIndex = 31;
            this.btnMostrar.Text = "show";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Wingdings 3", 24.5F);
            this.back.Location = new System.Drawing.Point(45, 16);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(53, 47);
            this.back.TabIndex = 32;
            this.back.Text = "";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dgvD
            // 
            this.dgvD.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvD.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvD.Location = new System.Drawing.Point(16, 71);
            this.dgvD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvD.Name = "dgvD";
            this.dgvD.RowHeadersWidth = 51;
            this.dgvD.Size = new System.Drawing.Size(187, 87);
            this.dgvD.TabIndex = 34;
            // 
            // buscarD
            // 
            this.buscarD.Location = new System.Drawing.Point(29, 43);
            this.buscarD.Margin = new System.Windows.Forms.Padding(4);
            this.buscarD.Name = "buscarD";
            this.buscarD.Size = new System.Drawing.Size(157, 22);
            this.buscarD.TabIndex = 35;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(63, 177);
            this.buscar.Margin = new System.Windows.Forms.Padding(4);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(100, 28);
            this.buscar.TabIndex = 36;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buscarD);
            this.panel1.Controls.Add(this.buscar);
            this.panel1.Controls.Add(this.dgvD);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(16, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 218);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Buscar Director";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 462);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 50);
            this.button1.TabIndex = 38;
            this.button1.Text = "Insertar Generos de Peliculas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(792, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // peliculasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 712);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "peliculasAdmin";
            this.Text = "peliculasAdmin";
            this.Load += new System.EventHandler(this.peliculasAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvD;
        private System.Windows.Forms.TextBox buscarD;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}