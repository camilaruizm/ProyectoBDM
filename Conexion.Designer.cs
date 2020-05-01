namespace ProyectoBDM
{
    partial class Conexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conexion));
            this.TbServidor = new System.Windows.Forms.TextBox();
            this.TbBaseDatos = new System.Windows.Forms.TextBox();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.LbConexion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PBMySQL = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMySQL)).BeginInit();
            this.SuspendLayout();
            // 
            // TbServidor
            // 
            this.TbServidor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TbServidor.BackColor = System.Drawing.Color.Beige;
            this.TbServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbServidor.Font = new System.Drawing.Font("Arial", 15F);
            this.TbServidor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TbServidor.Location = new System.Drawing.Point(117, 156);
            this.TbServidor.Name = "TbServidor";
            this.TbServidor.Size = new System.Drawing.Size(226, 30);
            this.TbServidor.TabIndex = 2;
            this.TbServidor.Text = "Servidor";
            this.TbServidor.Click += new System.EventHandler(this.TbServidor_Click);
            // 
            // TbBaseDatos
            // 
            this.TbBaseDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TbBaseDatos.BackColor = System.Drawing.Color.Beige;
            this.TbBaseDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbBaseDatos.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbBaseDatos.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TbBaseDatos.Location = new System.Drawing.Point(117, 237);
            this.TbBaseDatos.Name = "TbBaseDatos";
            this.TbBaseDatos.Size = new System.Drawing.Size(226, 30);
            this.TbBaseDatos.TabIndex = 3;
            this.TbBaseDatos.Text = "Base de Datos";
            this.TbBaseDatos.Click += new System.EventHandler(this.TbBaseDatos_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConectar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnConectar.BackColor = System.Drawing.Color.Lavender;
            this.BtnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConectar.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.BtnConectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnConectar.Location = new System.Drawing.Point(167, 285);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(223, 75);
            this.BtnConectar.TabIndex = 4;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = false;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            this.BtnConectar.MouseLeave += new System.EventHandler(this.BtnConectar_MouseLeave);
            this.BtnConectar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnConectar_MouseMove);
            // 
            // LbConexion
            // 
            this.LbConexion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbConexion.AutoSize = true;
            this.LbConexion.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbConexion.Location = new System.Drawing.Point(60, 75);
            this.LbConexion.Name = "LbConexion";
            this.LbConexion.Size = new System.Drawing.Size(296, 31);
            this.LbConexion.TabIndex = 8;
            this.LbConexion.Text = "Conexion a la Base de Datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // PBMySQL
            // 
            this.PBMySQL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBMySQL.Image = ((System.Drawing.Image)(resources.GetObject("PBMySQL.Image")));
            this.PBMySQL.Location = new System.Drawing.Point(174, 12);
            this.PBMySQL.Name = "PBMySQL";
            this.PBMySQL.Size = new System.Drawing.Size(60, 60);
            this.PBMySQL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PBMySQL.TabIndex = 5;
            this.PBMySQL.TabStop = false;
            // 
            // Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(402, 372);
            this.Controls.Add(this.LbConexion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PBMySQL);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.TbBaseDatos);
            this.Controls.Add(this.TbServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMySQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbServidor;
        private System.Windows.Forms.TextBox TbBaseDatos;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Label LbConexion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PBMySQL;
    }
}