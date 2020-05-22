namespace ProyectoBDM
{
    partial class SolicitarPrestamo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pDirector = new System.Windows.Forms.Panel();
            this.tbDirectorPelicula = new System.Windows.Forms.TextBox();
            this.lbDirector = new System.Windows.Forms.Label();
            this.pPeliculas = new System.Windows.Forms.Panel();
            this.pCategoria = new System.Windows.Forms.Panel();
            this.dudCategorias = new System.Windows.Forms.DomainUpDown();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.pTituloPeliculas = new System.Windows.Forms.Panel();
            this.tbTituloPelicula = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.msPeliculas = new System.Windows.Forms.MenuStrip();
            this.tsTitulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDirector = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SINOPSIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscarM = new System.Windows.Forms.Button();
            this.lbPrestamo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFechaNCliente = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btPrestamo = new System.Windows.Forms.Button();
            this.pDirector.SuspendLayout();
            this.pPeliculas.SuspendLayout();
            this.pCategoria.SuspendLayout();
            this.pTituloPeliculas.SuspendLayout();
            this.msPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Agency FB", 15F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.label13.Location = new System.Drawing.Point(16, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 24);
            this.label13.TabIndex = 66;
            this.label13.Text = "Peliculas encontradas:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.button2.Font = new System.Drawing.Font("Wingdings 3", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(525, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 46);
            this.button2.TabIndex = 65;
            this.button2.Text = "";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pDirector
            // 
            this.pDirector.Controls.Add(this.tbDirectorPelicula);
            this.pDirector.Controls.Add(this.lbDirector);
            this.pDirector.Location = new System.Drawing.Point(20, 103);
            this.pDirector.Name = "pDirector";
            this.pDirector.Size = new System.Drawing.Size(489, 60);
            this.pDirector.TabIndex = 64;
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
            this.pPeliculas.Controls.Add(this.pCategoria);
            this.pPeliculas.Controls.Add(this.pTituloPeliculas);
            this.pPeliculas.Controls.Add(this.msPeliculas);
            this.pPeliculas.Location = new System.Drawing.Point(20, 72);
            this.pPeliculas.Name = "pPeliculas";
            this.pPeliculas.Size = new System.Drawing.Size(489, 91);
            this.pPeliculas.TabIndex = 63;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.button1.Font = new System.Drawing.Font("Webdings", 25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(515, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 62;
            this.button1.Text = "";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPeliculas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPeliculas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.dgvPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPeliculas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.TITULO,
            this.DIRECTOR,
            this.DURACION,
            this.SINOPSIS,
            this.Column2,
            this.Column3});
            this.dgvPeliculas.EnableHeadersVisualStyles = false;
            this.dgvPeliculas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.dgvPeliculas.Location = new System.Drawing.Point(20, 211);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPeliculas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvPeliculas.Size = new System.Drawing.Size(489, 75);
            this.dgvPeliculas.TabIndex = 61;
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
            this.btBuscarM.Location = new System.Drawing.Point(515, 72);
            this.btBuscarM.Name = "btBuscarM";
            this.btBuscarM.Size = new System.Drawing.Size(46, 46);
            this.btBuscarM.TabIndex = 60;
            this.btBuscarM.Text = "";
            this.btBuscarM.UseVisualStyleBackColor = false;
            this.btBuscarM.Click += new System.EventHandler(this.btBuscarM_Click);
            // 
            // lbPrestamo
            // 
            this.lbPrestamo.AutoSize = true;
            this.lbPrestamo.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lbPrestamo.Location = new System.Drawing.Point(218, 13);
            this.lbPrestamo.Name = "lbPrestamo";
            this.lbPrestamo.Size = new System.Drawing.Size(142, 41);
            this.lbPrestamo.TabIndex = 59;
            this.lbPrestamo.Text = "PRÉSTAMO";
            this.lbPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.label1.Location = new System.Drawing.Point(16, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 68;
            this.label1.Text = "Tu préstamo:";
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPrestamo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrestamo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.dgvPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrestamo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvPrestamo.EnableHeadersVisualStyles = false;
            this.dgvPrestamo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.dgvPrestamo.Location = new System.Drawing.Point(20, 318);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrestamo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvPrestamo.Size = new System.Drawing.Size(489, 75);
            this.dgvPrestamo.TabIndex = 67;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 22;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "TITULO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 48;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "DIRECTOR";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 62;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DURACION";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 64;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "SINOPSIS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "FECHA DE ESTRENO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 106;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "N COPIAS";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dtFechaNCliente
            // 
            this.dtFechaNCliente.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.dtFechaNCliente.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.dtFechaNCliente.Location = new System.Drawing.Point(20, 432);
            this.dtFechaNCliente.Name = "dtFechaNCliente";
            this.dtFechaNCliente.Size = new System.Drawing.Size(229, 27);
            this.dtFechaNCliente.TabIndex = 69;
            this.dtFechaNCliente.Value = new System.DateTime(2020, 5, 11, 16, 28, 35, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 432);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 27);
            this.dateTimePicker1.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.label2.Location = new System.Drawing.Point(16, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "INICIO PRÉSTAMO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(251, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "DEVOLUCIÓN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPrestamo
            // 
            this.btPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btPrestamo.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrestamo.Location = new System.Drawing.Point(199, 485);
            this.btPrestamo.Name = "btPrestamo";
            this.btPrestamo.Size = new System.Drawing.Size(170, 46);
            this.btPrestamo.TabIndex = 72;
            this.btPrestamo.Text = "SOLICITAR PRÉSTAMO";
            this.btPrestamo.UseVisualStyleBackColor = false;
            // 
            // SolicitarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(583, 545);
            this.Controls.Add(this.btPrestamo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtFechaNCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrestamo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pDirector);
            this.Controls.Add(this.pPeliculas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.btBuscarM);
            this.Controls.Add(this.lbPrestamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolicitarPrestamo";
            this.Text = "SolicitarPrestamo";
            this.pDirector.ResumeLayout(false);
            this.pDirector.PerformLayout();
            this.pPeliculas.ResumeLayout(false);
            this.pPeliculas.PerformLayout();
            this.pCategoria.ResumeLayout(false);
            this.pCategoria.PerformLayout();
            this.pTituloPeliculas.ResumeLayout(false);
            this.pTituloPeliculas.PerformLayout();
            this.msPeliculas.ResumeLayout(false);
            this.msPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pDirector;
        private System.Windows.Forms.TextBox tbDirectorPelicula;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.Panel pPeliculas;
        private System.Windows.Forms.Panel pCategoria;
        private System.Windows.Forms.DomainUpDown dudCategorias;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Panel pTituloPeliculas;
        private System.Windows.Forms.TextBox tbTituloPelicula;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.MenuStrip msPeliculas;
        private System.Windows.Forms.ToolStripMenuItem tsTitulo;
        private System.Windows.Forms.ToolStripMenuItem tsCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsDirector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn SINOPSIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btBuscarM;
        private System.Windows.Forms.Label lbPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DateTimePicker dtFechaNCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPrestamo;
    }
}