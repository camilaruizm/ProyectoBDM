namespace ProyectoBDM
{
    partial class historialCliente
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
            this.dgvH = new System.Windows.Forms.DataGridView();
            this.showMultasHist = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showPeliculas = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HISTORIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MULTAS INACTIVAS";
            // 
            // dgvH
            // 
            this.dgvH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvH.Location = new System.Drawing.Point(36, 89);
            this.dgvH.Name = "dgvH";
            this.dgvH.RowHeadersWidth = 51;
            this.dgvH.Size = new System.Drawing.Size(724, 122);
            this.dgvH.TabIndex = 2;
            // 
            // showMultasHist
            // 
            this.showMultasHist.Location = new System.Drawing.Point(358, 217);
            this.showMultasHist.Name = "showMultasHist";
            this.showMultasHist.Size = new System.Drawing.Size(75, 23);
            this.showMultasHist.TabIndex = 3;
            this.showMultasHist.Text = "SHOW";
            this.showMultasHist.UseVisualStyleBackColor = true;
            this.showMultasHist.Click += new System.EventHandler(this.showMultasHist_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PELÍCULAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(724, 119);
            this.dataGridView1.TabIndex = 5;
            // 
            // showPeliculas
            // 
            this.showPeliculas.Location = new System.Drawing.Point(358, 423);
            this.showPeliculas.Name = "showPeliculas";
            this.showPeliculas.Size = new System.Drawing.Size(75, 23);
            this.showPeliculas.TabIndex = 6;
            this.showPeliculas.Text = "SHOW";
            this.showPeliculas.UseVisualStyleBackColor = true;
            this.showPeliculas.Click += new System.EventHandler(this.showPeliculas_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Wingdings 3", 24.5F);
            this.back.Location = new System.Drawing.Point(36, 9);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(44, 37);
            this.back.TabIndex = 7;
            this.back.Text = "";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // historialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.back);
            this.Controls.Add(this.showPeliculas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showMultasHist);
            this.Controls.Add(this.dgvH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "historialCliente";
            this.Text = "historialCliente";
            this.Load += new System.EventHandler(this.historialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvH;
        private System.Windows.Forms.Button showMultasHist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showPeliculas;
        private System.Windows.Forms.Button back;
    }
}