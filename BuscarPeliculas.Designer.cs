namespace ProyectoBDM
{
    partial class BuscarPeliculas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbPeliculas = new System.Windows.Forms.Label();
            this.pDirectorPeliculas = new System.Windows.Forms.Panel();
            this.tbDirectorPelicula = new System.Windows.Forms.TextBox();
            this.lbDirector = new System.Windows.Forms.Label();
            this.pPeliculas = new System.Windows.Forms.Panel();
            this.pCategoriaPeliculas = new System.Windows.Forms.Panel();
            this.dudCategorias = new System.Windows.Forms.DomainUpDown();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.pTituloPeliculas = new System.Windows.Forms.Panel();
            this.tbTituloPelicula = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.msPeliculas = new System.Windows.Forms.MenuStrip();
            this.tsTitulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDirector = new System.Windows.Forms.ToolStripMenuItem();
            this.btBuscarPeliculas2 = new System.Windows.Forms.Button();
            this.btBuscarPeliculas = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvBuscarPeliculas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SINOPSIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAtrasPeliculas = new System.Windows.Forms.Button();
            this.btPrestamo = new System.Windows.Forms.Button();
            this.pDirectorPeliculas.SuspendLayout();
            this.pPeliculas.SuspendLayout();
            this.pCategoriaPeliculas.SuspendLayout();
            this.pTituloPeliculas.SuspendLayout();
            this.msPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPeliculas
            // 
            this.lbPeliculas.AutoSize = true;
            this.lbPeliculas.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeliculas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lbPeliculas.Location = new System.Drawing.Point(225, 25);
            this.lbPeliculas.Name = "lbPeliculas";
            this.lbPeliculas.Size = new System.Drawing.Size(137, 41);
            this.lbPeliculas.TabIndex = 60;
            this.lbPeliculas.Text = "PELÍCULAS";
            this.lbPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPeliculas.Click += new System.EventHandler(this.lbPeliculas_Click);
            // 
            // pDirectorPeliculas
            // 
            this.pDirectorPeliculas.Controls.Add(this.tbDirectorPelicula);
            this.pDirectorPeliculas.Controls.Add(this.lbDirector);
            this.pDirectorPeliculas.Location = new System.Drawing.Point(0, 0);
            this.pDirectorPeliculas.Name = "pDirectorPeliculas";
            this.pDirectorPeliculas.Size = new System.Drawing.Size(489, 60);
            this.pDirectorPeliculas.TabIndex = 66;
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
            // pPeliculas
            // 
            this.pPeliculas.Controls.Add(this.pCategoriaPeliculas);
            this.pPeliculas.Controls.Add(this.pTituloPeliculas);
            this.pPeliculas.Controls.Add(this.msPeliculas);
            this.pPeliculas.Location = new System.Drawing.Point(28, 89);
            this.pPeliculas.Name = "pPeliculas";
            this.pPeliculas.Size = new System.Drawing.Size(489, 91);
            this.pPeliculas.TabIndex = 65;
            // 
            // pCategoriaPeliculas
            // 
            this.pCategoriaPeliculas.Controls.Add(this.pDirectorPeliculas);
            this.pCategoriaPeliculas.Controls.Add(this.dudCategorias);
            this.pCategoriaPeliculas.Controls.Add(this.lbCategoria);
            this.pCategoriaPeliculas.Location = new System.Drawing.Point(0, 31);
            this.pCategoriaPeliculas.Name = "pCategoriaPeliculas";
            this.pCategoriaPeliculas.Size = new System.Drawing.Size(489, 60);
            this.pCategoriaPeliculas.TabIndex = 56;
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
            // btBuscarPeliculas2
            // 
            this.btBuscarPeliculas2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btBuscarPeliculas2.Font = new System.Drawing.Font("Webdings", 25F);
            this.btBuscarPeliculas2.ForeColor = System.Drawing.Color.Black;
            this.btBuscarPeliculas2.Location = new System.Drawing.Point(523, 141);
            this.btBuscarPeliculas2.Name = "btBuscarPeliculas2";
            this.btBuscarPeliculas2.Size = new System.Drawing.Size(46, 46);
            this.btBuscarPeliculas2.TabIndex = 67;
            this.btBuscarPeliculas2.Text = "";
            this.btBuscarPeliculas2.UseVisualStyleBackColor = false;
            // 
            // btBuscarPeliculas
            // 
            this.btBuscarPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btBuscarPeliculas.Font = new System.Drawing.Font("Webdings", 25F);
            this.btBuscarPeliculas.ForeColor = System.Drawing.Color.Black;
            this.btBuscarPeliculas.Location = new System.Drawing.Point(523, 89);
            this.btBuscarPeliculas.Name = "btBuscarPeliculas";
            this.btBuscarPeliculas.Size = new System.Drawing.Size(46, 46);
            this.btBuscarPeliculas.TabIndex = 66;
            this.btBuscarPeliculas.Text = "";
            this.btBuscarPeliculas.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Agency FB", 15F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.label13.Location = new System.Drawing.Point(24, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 24);
            this.label13.TabIndex = 70;
            this.label13.Text = "Peliculas encontradas:";
            // 
            // dgvBuscarPeliculas
            // 
            this.dgvBuscarPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuscarPeliculas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuscarPeliculas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.dgvBuscarPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuscarPeliculas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscarPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBuscarPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.TITULO,
            this.DIRECTOR,
            this.DURACION,
            this.SINOPSIS,
            this.Column2,
            this.Column3});
            this.dgvBuscarPeliculas.EnableHeadersVisualStyles = false;
            this.dgvBuscarPeliculas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.dgvBuscarPeliculas.Location = new System.Drawing.Point(28, 229);
            this.dgvBuscarPeliculas.Name = "dgvBuscarPeliculas";
            this.dgvBuscarPeliculas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBuscarPeliculas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBuscarPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvBuscarPeliculas.Size = new System.Drawing.Size(489, 128);
            this.dgvBuscarPeliculas.TabIndex = 69;
            this.dgvBuscarPeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarPeliculas_CellContentClick);
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
            // btAtrasPeliculas
            // 
            this.btAtrasPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btAtrasPeliculas.Font = new System.Drawing.Font("Wingdings 3", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btAtrasPeliculas.ForeColor = System.Drawing.Color.Black;
            this.btAtrasPeliculas.Location = new System.Drawing.Point(536, 390);
            this.btAtrasPeliculas.Name = "btAtrasPeliculas";
            this.btAtrasPeliculas.Size = new System.Drawing.Size(46, 46);
            this.btAtrasPeliculas.TabIndex = 71;
            this.btAtrasPeliculas.Text = "";
            this.btAtrasPeliculas.UseVisualStyleBackColor = false;
            // 
            // btPrestamo
            // 
            this.btPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btPrestamo.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrestamo.Location = new System.Drawing.Point(204, 390);
            this.btPrestamo.Name = "btPrestamo";
            this.btPrestamo.Size = new System.Drawing.Size(170, 46);
            this.btPrestamo.TabIndex = 73;
            this.btPrestamo.Text = "REALIZAR PRÉSTAMO";
            this.btPrestamo.UseVisualStyleBackColor = false;
            this.btPrestamo.Click += new System.EventHandler(this.btPrestamo_Click);
            // 
            // BuscarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(594, 448);
            this.Controls.Add(this.btPrestamo);
            this.Controls.Add(this.btAtrasPeliculas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvBuscarPeliculas);
            this.Controls.Add(this.btBuscarPeliculas2);
            this.Controls.Add(this.btBuscarPeliculas);
            this.Controls.Add(this.pPeliculas);
            this.Controls.Add(this.lbPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarPeliculas";
            this.Text = "BuscarPeliculas";
            this.Load += new System.EventHandler(this.BuscarPeliculas_Load);
            this.pDirectorPeliculas.ResumeLayout(false);
            this.pDirectorPeliculas.PerformLayout();
            this.pPeliculas.ResumeLayout(false);
            this.pPeliculas.PerformLayout();
            this.pCategoriaPeliculas.ResumeLayout(false);
            this.pCategoriaPeliculas.PerformLayout();
            this.pTituloPeliculas.ResumeLayout(false);
            this.pTituloPeliculas.PerformLayout();
            this.msPeliculas.ResumeLayout(false);
            this.msPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPeliculas;
        private System.Windows.Forms.Panel pDirectorPeliculas;
        private System.Windows.Forms.TextBox tbDirectorPelicula;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.Panel pPeliculas;
        private System.Windows.Forms.Panel pCategoriaPeliculas;
        private System.Windows.Forms.DomainUpDown dudCategorias;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Panel pTituloPeliculas;
        private System.Windows.Forms.TextBox tbTituloPelicula;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.MenuStrip msPeliculas;
        private System.Windows.Forms.ToolStripMenuItem tsTitulo;
        private System.Windows.Forms.ToolStripMenuItem tsCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsDirector;
        private System.Windows.Forms.Button btBuscarPeliculas2;
        private System.Windows.Forms.Button btBuscarPeliculas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvBuscarPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn SINOPSIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btAtrasPeliculas;
        private System.Windows.Forms.Button btPrestamo;
    }
}