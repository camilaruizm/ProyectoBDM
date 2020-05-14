namespace ProyectoBDM
{
    partial class generoPelicula
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
            this.clasificacionGenero = new System.Windows.Forms.TextBox();
            this.tipoGenero = new System.Windows.Forms.TextBox();
            this.insertarGenero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLASIFICACIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIPO GÉNERO";
            // 
            // clasificacionGenero
            // 
            this.clasificacionGenero.Location = new System.Drawing.Point(222, 37);
            this.clasificacionGenero.Name = "clasificacionGenero";
            this.clasificacionGenero.Size = new System.Drawing.Size(107, 20);
            this.clasificacionGenero.TabIndex = 2;
            // 
            // tipoGenero
            // 
            this.tipoGenero.Location = new System.Drawing.Point(222, 79);
            this.tipoGenero.Name = "tipoGenero";
            this.tipoGenero.Size = new System.Drawing.Size(100, 20);
            this.tipoGenero.TabIndex = 3;
            // 
            // insertarGenero
            // 
            this.insertarGenero.Location = new System.Drawing.Point(161, 128);
            this.insertarGenero.Name = "insertarGenero";
            this.insertarGenero.Size = new System.Drawing.Size(75, 23);
            this.insertarGenero.TabIndex = 4;
            this.insertarGenero.Text = "INSERTAR";
            this.insertarGenero.UseVisualStyleBackColor = true;
            this.insertarGenero.Click += new System.EventHandler(this.insertarGenero_Click);
            // 
            // generoPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 173);
            this.Controls.Add(this.insertarGenero);
            this.Controls.Add(this.tipoGenero);
            this.Controls.Add(this.clasificacionGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "generoPelicula";
            this.Text = "generoPelicula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clasificacionGenero;
        private System.Windows.Forms.TextBox tipoGenero;
        private System.Windows.Forms.Button insertarGenero;
    }
}