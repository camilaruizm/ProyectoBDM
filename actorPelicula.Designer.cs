namespace ProyectoBDM
{
    partial class actorPelicula
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
            this.insertarAP = new System.Windows.Forms.Button();
            this.modificarAP = new System.Windows.Forms.Button();
            this.eliminarAP = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idParticipacion = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PELÍCULA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ACTRIZ-ACTOR";
            // 
            // insertarAP
            // 
            this.insertarAP.Location = new System.Drawing.Point(176, 117);
            this.insertarAP.Name = "insertarAP";
            this.insertarAP.Size = new System.Drawing.Size(75, 23);
            this.insertarAP.TabIndex = 2;
            this.insertarAP.Text = "INSERTAR";
            this.insertarAP.UseVisualStyleBackColor = true;
            // 
            // modificarAP
            // 
            this.modificarAP.Location = new System.Drawing.Point(363, 117);
            this.modificarAP.Name = "modificarAP";
            this.modificarAP.Size = new System.Drawing.Size(75, 23);
            this.modificarAP.TabIndex = 3;
            this.modificarAP.Text = "MODIFICAR";
            this.modificarAP.UseVisualStyleBackColor = true;
            // 
            // eliminarAP
            // 
            this.eliminarAP.Location = new System.Drawing.Point(555, 117);
            this.eliminarAP.Name = "eliminarAP";
            this.eliminarAP.Size = new System.Drawing.Size(75, 23);
            this.eliminarAP.TabIndex = 4;
            this.eliminarAP.Text = "ELIMINAR";
            this.eliminarAP.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // idParticipacion
            // 
            this.idParticipacion.Location = new System.Drawing.Point(21, 12);
            this.idParticipacion.Name = "idParticipacion";
            this.idParticipacion.Size = new System.Drawing.Size(23, 20);
            this.idParticipacion.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(509, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 61);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 9;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // actorPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.back);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.idParticipacion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.eliminarAP);
            this.Controls.Add(this.modificarAP);
            this.Controls.Add(this.insertarAP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "actorPelicula";
            this.Text = "actorPelicula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button insertarAP;
        private System.Windows.Forms.Button modificarAP;
        private System.Windows.Forms.Button eliminarAP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idParticipacion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button back;
    }
}