namespace ProyectoBDM
{
    partial class verPeliculas
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
            this.LbBuscar = new System.Windows.Forms.Label();
            this.TbBuscarPelicula = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBuscarPelicular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbBuscar
            // 
            this.LbBuscar.AutoSize = true;
            this.LbBuscar.Location = new System.Drawing.Point(60, 65);
            this.LbBuscar.Name = "LbBuscar";
            this.LbBuscar.Size = new System.Drawing.Size(101, 13);
            this.LbBuscar.TabIndex = 0;
            this.LbBuscar.Text = "Titulo de la pelicula:";
            // 
            // TbBuscarPelicula
            // 
            this.TbBuscarPelicula.Location = new System.Drawing.Point(167, 62);
            this.TbBuscarPelicula.Name = "TbBuscarPelicula";
            this.TbBuscarPelicula.Size = new System.Drawing.Size(202, 20);
            this.TbBuscarPelicula.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 219);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnBuscarPelicular
            // 
            this.BtnBuscarPelicular.Location = new System.Drawing.Point(375, 55);
            this.BtnBuscarPelicular.Name = "BtnBuscarPelicular";
            this.BtnBuscarPelicular.Size = new System.Drawing.Size(62, 33);
            this.BtnBuscarPelicular.TabIndex = 3;
            this.BtnBuscarPelicular.Text = "Buscar";
            this.BtnBuscarPelicular.UseVisualStyleBackColor = true;
            this.BtnBuscarPelicular.Click += new System.EventHandler(this.BtnBuscarPelicular_Click);
            // 
            // verPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBuscarPelicular);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TbBuscarPelicula);
            this.Controls.Add(this.LbBuscar);
            this.Name = "verPeliculas";
            this.Text = "verPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbBuscar;
        private System.Windows.Forms.TextBox TbBuscarPelicula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnBuscarPelicular;
    }
}