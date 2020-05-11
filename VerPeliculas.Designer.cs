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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbModificar = new System.Windows.Forms.Label();
            this.dgvM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SINOPSIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTituloIdM = new System.Windows.Forms.TextBox();
            this.lbTituloIdM = new System.Windows.Forms.Label();
            this.btBuscarM = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            this.SuspendLayout();
            // 
            // lbModificar
            // 
            this.lbModificar.AutoSize = true;
            this.lbModificar.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lbModificar.Location = new System.Drawing.Point(241, 9);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvM.Location = new System.Drawing.Point(39, 204);
            this.dgvM.Name = "dgvM";
            this.dgvM.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvM.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvM.Size = new System.Drawing.Size(514, 75);
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
            // tbTituloIdM
            // 
            this.tbTituloIdM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.tbTituloIdM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTituloIdM.Font = new System.Drawing.Font("Agency FB", 16F);
            this.tbTituloIdM.Location = new System.Drawing.Point(99, 172);
            this.tbTituloIdM.Name = "tbTituloIdM";
            this.tbTituloIdM.Size = new System.Drawing.Size(454, 26);
            this.tbTituloIdM.TabIndex = 43;
            // 
            // lbTituloIdM
            // 
            this.lbTituloIdM.AutoSize = true;
            this.lbTituloIdM.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloIdM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.lbTituloIdM.Location = new System.Drawing.Point(34, 173);
            this.lbTituloIdM.Name = "lbTituloIdM";
            this.lbTituloIdM.Size = new System.Drawing.Size(59, 28);
            this.lbTituloIdM.TabIndex = 42;
            this.lbTituloIdM.Text = "TITULO";
            this.lbTituloIdM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btBuscarM
            // 
            this.btBuscarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btBuscarM.Font = new System.Drawing.Font("Webdings", 25F);
            this.btBuscarM.ForeColor = System.Drawing.Color.Black;
            this.btBuscarM.Location = new System.Drawing.Point(590, 233);
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
            this.button1.Location = new System.Drawing.Point(590, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 45;
            this.button1.Text = "";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // VerPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvM);
            this.Controls.Add(this.tbTituloIdM);
            this.Controls.Add(this.lbTituloIdM);
            this.Controls.Add(this.btBuscarM);
            this.Controls.Add(this.lbModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerPeliculas";
            this.Text = "VerPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).EndInit();
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
        private System.Windows.Forms.TextBox tbTituloIdM;
        private System.Windows.Forms.Label lbTituloIdM;
        private System.Windows.Forms.Button btBuscarM;
        private System.Windows.Forms.Button button1;
    }
}