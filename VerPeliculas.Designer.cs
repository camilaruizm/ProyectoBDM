namespace ProyectoBDM
{
    partial class VerPeliculas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbModificar = new System.Windows.Forms.Label();
            this.dgvM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SINOPSIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscarM = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pPeliculas = new System.Windows.Forms.Panel();
            this.msPeliculas = new System.Windows.Forms.MenuStrip();
            this.tsTitulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDirector = new System.Windows.Forms.ToolStripMenuItem();
            this.pTituloPeliculas = new System.Windows.Forms.Panel();
            this.tbTituloPelicula = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pCategoria = new System.Windows.Forms.Panel();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.dudCategorias = new System.Windows.Forms.DomainUpDown();
            this.pDirector = new System.Windows.Forms.Panel();
            this.tbDirectorPelicula = new System.Windows.Forms.TextBox();
            this.lbDirector = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            this.pPeliculas.SuspendLayout();
            this.msPeliculas.SuspendLayout();
            this.pTituloPeliculas.SuspendLayout();
            this.pCategoria.SuspendLayout();
            this.pDirector.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbModificar
            // 
            this.lbModificar.AutoSize = true;
            this.lbModificar.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lbModificar.Location = new System.Drawing.Point(218, 15);
            this.lbModificar.Name = "lbModificar";
            this.lbModificar.Size = new System.Drawing.Size(137, 41);
            this.lbModificar.TabIndex = 20;
            this.lbModificar.Text = "PELÍCULAS";
            this.lbModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvM
            // 
            this.dgvM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.dgvM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.TITULO,
            this.DIRECTOR,
            this.DURACION,
            this.SINOPSIS,
            this.Column2,
            this.Column3});
            this.dgvM.EnableHeadersVisualStyles = false;
            this.dgvM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.dgvM.Location = new System.Drawing.Point(20, 213);
            this.dgvM.Name = "dgvM";
            this.dgvM.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvM.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvM.Size = new System.Drawing.Size(489, 75);
            this.dgvM.TabIndex = 44;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 22;
            // 
            // TITULO
            // 
            this.TITULO.HeaderText = "TITULO";
            this.TITULO.Name = "TITULO";
            this.TITULO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TITULO.Width = 48;
            // 
            // DIRECTOR
            // 
            this.DIRECTOR.HeaderText = "DIRECTOR";
            this.DIRECTOR.Name = "DIRECTOR";
            this.DIRECTOR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DIRECTOR.Width = 62;
            // 
            // DURACION
            // 
            this.DURACION.HeaderText = "DURACION";
            this.DURACION.Name = "DURACION";
            this.DURACION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DURACION.Width = 64;
            // 
            // SINOPSIS
            // 
            this.SINOPSIS.HeaderText = "SINOPSIS";
            this.SINOPSIS.Name = "SINOPSIS";
            this.SINOPSIS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SINOPSIS.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FECHA DE ESTRENO";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 106;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "N COPIAS";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 60;
            // 
            // btBuscarM
            // 
            this.btBuscarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btBuscarM.Font = new System.Drawing.Font("Webdings", 25F);
            this.btBuscarM.ForeColor = System.Drawing.Color.Black;
            this.btBuscarM.Location = new System.Drawing.Point(515, 74);
            this.btBuscarM.Name = "btBuscarM";
            this.btBuscarM.Size = new System.Drawing.Size(46, 46);
            this.btBuscarM.TabIndex = 41;
            this.btBuscarM.Text = "";
            this.btBuscarM.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.button1.Font = new System.Drawing.Font("Webdings", 25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(515, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 45;
            this.button1.Text = "";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pPeliculas
            // 
            this.pPeliculas.Controls.Add(this.pCategoria);
            this.pPeliculas.Controls.Add(this.pTituloPeliculas);
            this.pPeliculas.Controls.Add(this.msPeliculas);
            this.pPeliculas.Location = new System.Drawing.Point(20, 74);
            this.pPeliculas.Name = "pPeliculas";
            this.pPeliculas.Size = new System.Drawing.Size(489, 91);
            this.pPeliculas.TabIndex = 54;
            // 
            // msPeliculas
            // 
            this.msPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.msPeliculas.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.msPeliculas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTitulo,
            this.tsCategoria,
            this.tsDirector});
            this.msPeliculas.Location = new System.Drawing.Point(0, 0);
            this.msPeliculas.Name = "msPeliculas";
            this.msPeliculas.Size = new System.Drawing.Size(489, 28);
            this.msPeliculas.TabIndex = 0;
            this.msPeliculas.Text = "menuStrip2";
            // 
            // tsTitulo
            // 
            this.tsTitulo.Name = "tsTitulo";
            this.tsTitulo.Size = new System.Drawing.Size(57, 24);
            this.tsTitulo.Text = "TÍTULO";
            // 
            // tsCategoria
            // 
            this.tsCategoria.Name = "tsCategoria";
            this.tsCategoria.Size = new System.Drawing.Size(78, 24);
            this.tsCategoria.Text = "CATEGORÍA";
            // 
            // tsDirector
            // 
            this.tsDirector.Name = "tsDirector";
            this.tsDirector.Size = new System.Drawing.Size(71, 24);
            this.tsDirector.Text = "DIRECTOR";
            // 
            // pTituloPeliculas
            // 
            this.pTituloPeliculas.Controls.Add(this.tbTituloPelicula);
            this.pTituloPeliculas.Controls.Add(this.lbTitulo);
            this.pTituloPeliculas.Location = new System.Drawing.Point(0, 31);
            this.pTituloPeliculas.Name = "pTituloPeliculas";
            this.pTituloPeliculas.Size = new System.Drawing.Size(489, 60);
            this.pTituloPeliculas.TabIndex = 55;
            // 
            // tbTituloPelicula
            // 
            this.tbTituloPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.tbTituloPelicula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTituloPelicula.Font = new System.Drawing.Font("Agency FB", 16F);
            this.tbTituloPelicula.Location = new System.Drawing.Point(7, 27);
            this.tbTituloPelicula.Name = "tbTituloPelicula";
            this.tbTituloPelicula.Size = new System.Drawing.Size(475, 26);
            this.tbTituloPelicula.TabIndex = 45;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(44, 24);
            this.lbTitulo.TabIndex = 44;
            this.lbTitulo.Text = "TÍTULO";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCategoria
            // 
            this.pCategoria.Controls.Add(this.dudCategorias);
            this.pCategoria.Controls.Add(this.lbCategoria);
            this.pCategoria.Location = new System.Drawing.Point(0, 31);
            this.pCategoria.Name = "pCategoria";
            this.pCategoria.Size = new System.Drawing.Size(489, 60);
            this.pCategoria.TabIndex = 56;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.lbCategoria.Location = new System.Drawing.Point(3, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(79, 24);
            this.lbCategoria.TabIndex = 44;
            this.lbCategoria.Text = "CATEGORÍAS";
            this.lbCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dudCategorias
            // 
            this.dudCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.dudCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dudCategorias.Font = new System.Drawing.Font("Agency FB", 16F);
            this.dudCategorias.ForeColor = System.Drawing.Color.Black;
            this.dudCategorias.Location = new System.Drawing.Point(7, 27);
            this.dudCategorias.Name = "dudCategorias";
            this.dudCategorias.Size = new System.Drawing.Size(475, 29);
            this.dudCategorias.TabIndex = 45;
            this.dudCategorias.Text = "domainUpDown1";
            // 
            // pDirector
            // 
            this.pDirector.Controls.Add(this.tbDirectorPelicula);
            this.pDirector.Controls.Add(this.lbDirector);
            this.pDirector.Location = new System.Drawing.Point(20, 105);
            this.pDirector.Name = "pDirector";
            this.pDirector.Size = new System.Drawing.Size(489, 60);
            this.pDirector.TabIndex = 56;
            // 
            // tbDirectorPelicula
            // 
            this.tbDirectorPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.tbDirectorPelicula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDirectorPelicula.Font = new System.Drawing.Font("Agency FB", 16F);
            this.tbDirectorPelicula.Location = new System.Drawing.Point(7, 27);
            this.tbDirectorPelicula.Name = "tbDirectorPelicula";
            this.tbDirectorPelicula.Size = new System.Drawing.Size(475, 26);
            this.tbDirectorPelicula.TabIndex = 45;
            // 
            // lbDirector
            // 
            this.lbDirector.AutoSize = true;
            this.lbDirector.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.lbDirector.Location = new System.Drawing.Point(3, 0);
            this.lbDirector.Name = "lbDirector";
            this.lbDirector.Size = new System.Drawing.Size(65, 24);
            this.lbDirector.TabIndex = 44;
            this.lbDirector.Text = "DIRECTOR";
            this.lbDirector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.button2.Font = new System.Drawing.Font("Wingdings 3", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(524, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 46);
            this.button2.TabIndex = 57;
            this.button2.Text = "";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Agency FB", 15F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.label13.Location = new System.Drawing.Point(16, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 24);
            this.label13.TabIndex = 58;
            this.label13.Text = "Peliculas encontradas:";
            // 
            // VerPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(582, 363);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pDirector);
            this.Controls.Add(this.pPeliculas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvM);
            this.Controls.Add(this.btBuscarM);
            this.Controls.Add(this.lbModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerPeliculas";
            this.Text = "VerPeliculas";
            this.Load += new System.EventHandler(this.VerPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).EndInit();
            this.pPeliculas.ResumeLayout(false);
            this.pPeliculas.PerformLayout();
            this.msPeliculas.ResumeLayout(false);
            this.msPeliculas.PerformLayout();
            this.pTituloPeliculas.ResumeLayout(false);
            this.pTituloPeliculas.PerformLayout();
            this.pCategoria.ResumeLayout(false);
            this.pCategoria.PerformLayout();
            this.pDirector.ResumeLayout(false);
            this.pDirector.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbModificar;
        private System.Windows.Forms.DataGridView dgvM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn SINOPSIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btBuscarM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pPeliculas;
        private System.Windows.Forms.MenuStrip msPeliculas;
        private System.Windows.Forms.ToolStripMenuItem tsTitulo;
        private System.Windows.Forms.ToolStripMenuItem tsCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsDirector;
        private System.Windows.Forms.Panel pTituloPeliculas;
        private System.Windows.Forms.TextBox tbTituloPelicula;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel pCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.DomainUpDown dudCategorias;
        private System.Windows.Forms.Panel pDirector;
        private System.Windows.Forms.TextBox tbDirectorPelicula;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
    }
}