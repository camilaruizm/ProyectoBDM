namespace ProyectoBDM
{
    partial class RelacionGeneroPelicula
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.LbIdPelicula = new System.Windows.Forms.Label();
            this.idGenero = new System.Windows.Forms.Label();
            this.tbidPelicula = new System.Windows.Forms.TextBox();
            this.tbidGenero = new System.Windows.Forms.TextBox();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbidPeliGen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 156);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(690, 217);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(83, 39);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            // 
            // LbIdPelicula
            // 
            this.LbIdPelicula.AutoSize = true;
            this.LbIdPelicula.Location = new System.Drawing.Point(292, 70);
            this.LbIdPelicula.Name = "LbIdPelicula";
            this.LbIdPelicula.Size = new System.Drawing.Size(82, 13);
            this.LbIdPelicula.TabIndex = 2;
            this.LbIdPelicula.Text = "Id de la Pelicula";
            // 
            // idGenero
            // 
            this.idGenero.AutoSize = true;
            this.idGenero.Location = new System.Drawing.Point(558, 70);
            this.idGenero.Name = "idGenero";
            this.idGenero.Size = new System.Drawing.Size(71, 13);
            this.idGenero.TabIndex = 3;
            this.idGenero.Text = "Id del Genero";
            // 
            // tbidPelicula
            // 
            this.tbidPelicula.Location = new System.Drawing.Point(380, 67);
            this.tbidPelicula.Name = "tbidPelicula";
            this.tbidPelicula.Size = new System.Drawing.Size(100, 20);
            this.tbidPelicula.TabIndex = 4;
            // 
            // tbidGenero
            // 
            this.tbidGenero.Location = new System.Drawing.Point(635, 67);
            this.tbidGenero.Name = "tbidGenero";
            this.tbidGenero.Size = new System.Drawing.Size(100, 20);
            this.tbidGenero.TabIndex = 5;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(146, 120);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(95, 33);
            this.BtnInsertar.TabIndex = 6;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(304, 120);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(98, 33);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(468, 120);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 33);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Agregacion de Generos a las Peliculas";
            // 
            // tbidPeliGen
            // 
            this.tbidPeliGen.Location = new System.Drawing.Point(133, 67);
            this.tbidPeliGen.Name = "tbidPeliGen";
            this.tbidPeliGen.Size = new System.Drawing.Size(100, 20);
            this.tbidPeliGen.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo de relacion";
            // 
            // RelacionGeneroPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 332);
            this.Controls.Add(this.tbidPeliGen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.tbidGenero);
            this.Controls.Add(this.tbidPelicula);
            this.Controls.Add(this.idGenero);
            this.Controls.Add(this.LbIdPelicula);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RelacionGeneroPelicula";
            this.Text = "AgregarGenero";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label LbIdPelicula;
        private System.Windows.Forms.Label idGenero;
        private System.Windows.Forms.TextBox tbidPelicula;
        private System.Windows.Forms.TextBox tbidGenero;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbidPeliGen;
        private System.Windows.Forms.Label label2;
    }
}