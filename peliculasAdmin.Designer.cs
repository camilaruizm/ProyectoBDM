namespace ProyectoBDM
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.actualizarAdmin = new System.Windows.Forms.Button();
            this.deleteAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloPelicula
            // 
            this.labelTituloPelicula.AutoSize = true;
            this.labelTituloPelicula.Location = new System.Drawing.Point(112, 30);
            this.labelTituloPelicula.Name = "labelTituloPelicula";
            this.labelTituloPelicula.Size = new System.Drawing.Size(46, 13);
            this.labelTituloPelicula.TabIndex = 0;
            this.labelTituloPelicula.Text = "TITULO";
            // 
            // labelDirectorPelicula
            // 
            this.labelDirectorPelicula.AutoSize = true;
            this.labelDirectorPelicula.Location = new System.Drawing.Point(112, 68);
            this.labelDirectorPelicula.Name = "labelDirectorPelicula";
            this.labelDirectorPelicula.Size = new System.Drawing.Size(63, 13);
            this.labelDirectorPelicula.TabIndex = 1;
            this.labelDirectorPelicula.Text = "DIRECTOR";
            // 
            // labelSinopsisPelicula
            // 
            this.labelSinopsisPelicula.AutoSize = true;
            this.labelSinopsisPelicula.Location = new System.Drawing.Point(112, 109);
            this.labelSinopsisPelicula.Name = "labelSinopsisPelicula";
            this.labelSinopsisPelicula.Size = new System.Drawing.Size(57, 13);
            this.labelSinopsisPelicula.TabIndex = 2;
            this.labelSinopsisPelicula.Text = "SINOPSIS";
            // 
            // labelDuracionPelicula
            // 
            this.labelDuracionPelicula.AutoSize = true;
            this.labelDuracionPelicula.Location = new System.Drawing.Point(112, 149);
            this.labelDuracionPelicula.Name = "labelDuracionPelicula";
            this.labelDuracionPelicula.Size = new System.Drawing.Size(64, 13);
            this.labelDuracionPelicula.TabIndex = 3;
            this.labelDuracionPelicula.Text = "DURACIÓN";
            // 
            // labelFecha_estrenoPelicula
            // 
            this.labelFecha_estrenoPelicula.AutoSize = true;
            this.labelFecha_estrenoPelicula.Location = new System.Drawing.Point(112, 193);
            this.labelFecha_estrenoPelicula.Name = "labelFecha_estrenoPelicula";
            this.labelFecha_estrenoPelicula.Size = new System.Drawing.Size(97, 13);
            this.labelFecha_estrenoPelicula.TabIndex = 4;
            this.labelFecha_estrenoPelicula.Text = "FECHA ESTRENO";
            // 
            // buttonImagePelicula
            // 
            this.buttonImagePelicula.Location = new System.Drawing.Point(693, 139);
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
            this.dataGridView2.Location = new System.Drawing.Point(97, 348);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(623, 182);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.textTitulo.Location = new System.Drawing.Point(232, 23);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(152, 20);
            this.textTitulo.TabIndex = 9;
            // 
            // textSinopsis
            // 
            this.textSinopsis.Location = new System.Drawing.Point(232, 102);
            this.textSinopsis.Name = "textSinopsis";
            this.textSinopsis.Size = new System.Drawing.Size(152, 20);
            this.textSinopsis.TabIndex = 11;
            // 
            // textDuracion
            // 
            this.textDuracion.Location = new System.Drawing.Point(232, 142);
            this.textDuracion.Name = "textDuracion";
            this.textDuracion.Size = new System.Drawing.Size(152, 20);
            this.textDuracion.TabIndex = 12;
            // 
            // cantCopias
            // 
            this.cantCopias.AutoSize = true;
            this.cantCopias.Location = new System.Drawing.Point(115, 232);
            this.cantCopias.Name = "cantCopias";
            this.cantCopias.Size = new System.Drawing.Size(104, 13);
            this.cantCopias.TabIndex = 14;
            this.cantCopias.Text = "CANTIDAD COPIAS";
            // 
            // textCantCopis
            // 
            this.textCantCopis.Location = new System.Drawing.Point(232, 224);
            this.textCantCopis.Name = "textCantCopis";
            this.textCantCopis.Size = new System.Drawing.Size(152, 20);
            this.textCantCopis.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(503, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(232, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(265, 21);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // actualizarAdmin
            // 
            this.actualizarAdmin.Location = new System.Drawing.Point(351, 306);
            this.actualizarAdmin.Name = "actualizarAdmin";
            this.actualizarAdmin.Size = new System.Drawing.Size(85, 23);
            this.actualizarAdmin.TabIndex = 24;
            this.actualizarAdmin.Text = "ACTUALIZAR";
            this.actualizarAdmin.UseVisualStyleBackColor = true;
            this.actualizarAdmin.Click += new System.EventHandler(this.actualizarAdmin_Click);
            // 
            // deleteAdmin
            // 
            this.deleteAdmin.Location = new System.Drawing.Point(503, 306);
            this.deleteAdmin.Name = "deleteAdmin";
            this.deleteAdmin.Size = new System.Drawing.Size(75, 23);
            this.deleteAdmin.TabIndex = 25;
            this.deleteAdmin.Text = "ELIMINAR";
            this.deleteAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "GÉNERO";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // peliculasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteAdmin);
            this.Controls.Add(this.actualizarAdmin);
            this.Controls.Add(this.comboBox2);
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button actualizarAdmin;
        private System.Windows.Forms.Button deleteAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}