namespace ProyectoBDM
{
    partial class Multa
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpfechaGeneracion = new System.Windows.Forms.DateTimePicker();
            this.dtpPago = new System.Windows.Forms.DateTimePicker();
            this.valorMulta = new System.Windows.Forms.TextBox();
            this.codigoPrestamo = new System.Windows.Forms.TextBox();
            this.codigoCliente = new System.Windows.Forms.TextBox();
            this.dgvM = new System.Windows.Forms.DataGridView();
            this.insertarMulta = new System.Windows.Forms.Button();
            this.modificarMulta = new System.Windows.Forms.Button();
            this.eliminarMulta = new System.Windows.Forms.Button();
            this.showMultas = new System.Windows.Forms.Button();
            this.idMulta = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Generación Multa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Pago Multa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Multa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado Multa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código Prestamo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Código Cliente";
            // 
            // dtpfechaGeneracion
            // 
            this.dtpfechaGeneracion.CustomFormat = "yyy-MM-dd";
            this.dtpfechaGeneracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechaGeneracion.Location = new System.Drawing.Point(320, 32);
            this.dtpfechaGeneracion.Name = "dtpfechaGeneracion";
            this.dtpfechaGeneracion.Size = new System.Drawing.Size(200, 20);
            this.dtpfechaGeneracion.TabIndex = 6;
            // 
            // dtpPago
            // 
            this.dtpPago.CustomFormat = "yyy-MM-dd";
            this.dtpPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPago.Location = new System.Drawing.Point(320, 65);
            this.dtpPago.Name = "dtpPago";
            this.dtpPago.Size = new System.Drawing.Size(200, 20);
            this.dtpPago.TabIndex = 7;
            // 
            // valorMulta
            // 
            this.valorMulta.Location = new System.Drawing.Point(320, 103);
            this.valorMulta.Name = "valorMulta";
            this.valorMulta.Size = new System.Drawing.Size(100, 20);
            this.valorMulta.TabIndex = 8;
            // 
            // codigoPrestamo
            // 
            this.codigoPrestamo.Location = new System.Drawing.Point(320, 176);
            this.codigoPrestamo.Name = "codigoPrestamo";
            this.codigoPrestamo.Size = new System.Drawing.Size(100, 20);
            this.codigoPrestamo.TabIndex = 10;
            // 
            // codigoCliente
            // 
            this.codigoCliente.Location = new System.Drawing.Point(320, 213);
            this.codigoCliente.Name = "codigoCliente";
            this.codigoCliente.Size = new System.Drawing.Size(100, 20);
            this.codigoCliente.TabIndex = 11;
            // 
            // dgvM
            // 
            this.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM.Location = new System.Drawing.Point(41, 288);
            this.dgvM.Name = "dgvM";
            this.dgvM.Size = new System.Drawing.Size(723, 150);
            this.dgvM.TabIndex = 12;
            this.dgvM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvM_CellClick);
            // 
            // insertarMulta
            // 
            this.insertarMulta.Location = new System.Drawing.Point(193, 259);
            this.insertarMulta.Name = "insertarMulta";
            this.insertarMulta.Size = new System.Drawing.Size(75, 23);
            this.insertarMulta.TabIndex = 15;
            this.insertarMulta.Text = "INSERTAR";
            this.insertarMulta.UseVisualStyleBackColor = true;
            this.insertarMulta.Click += new System.EventHandler(this.insertarMulta_Click);
            // 
            // modificarMulta
            // 
            this.modificarMulta.Location = new System.Drawing.Point(342, 258);
            this.modificarMulta.Name = "modificarMulta";
            this.modificarMulta.Size = new System.Drawing.Size(75, 23);
            this.modificarMulta.TabIndex = 16;
            this.modificarMulta.Text = "MODIFICAR";
            this.modificarMulta.UseVisualStyleBackColor = true;
            this.modificarMulta.Click += new System.EventHandler(this.modificarMulta_Click);
            // 
            // eliminarMulta
            // 
            this.eliminarMulta.Location = new System.Drawing.Point(486, 259);
            this.eliminarMulta.Name = "eliminarMulta";
            this.eliminarMulta.Size = new System.Drawing.Size(75, 23);
            this.eliminarMulta.TabIndex = 17;
            this.eliminarMulta.Text = "ELIMINAR";
            this.eliminarMulta.UseVisualStyleBackColor = true;
            this.eliminarMulta.Click += new System.EventHandler(this.eliminarMulta_Click);
            // 
            // showMultas
            // 
            this.showMultas.Location = new System.Drawing.Point(342, 444);
            this.showMultas.Name = "showMultas";
            this.showMultas.Size = new System.Drawing.Size(75, 23);
            this.showMultas.TabIndex = 18;
            this.showMultas.Text = "SHOW";
            this.showMultas.UseVisualStyleBackColor = true;
            this.showMultas.Click += new System.EventHandler(this.showMultas_Click);
            // 
            // idMulta
            // 
            this.idMulta.Location = new System.Drawing.Point(320, 6);
            this.idMulta.Name = "idMulta";
            this.idMulta.Size = new System.Drawing.Size(36, 20);
            this.idMulta.TabIndex = 20;
            this.idMulta.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox1.Location = new System.Drawing.Point(320, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // Multa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.idMulta);
            this.Controls.Add(this.showMultas);
            this.Controls.Add(this.eliminarMulta);
            this.Controls.Add(this.modificarMulta);
            this.Controls.Add(this.insertarMulta);
            this.Controls.Add(this.dgvM);
            this.Controls.Add(this.codigoCliente);
            this.Controls.Add(this.codigoPrestamo);
            this.Controls.Add(this.valorMulta);
            this.Controls.Add(this.dtpPago);
            this.Controls.Add(this.dtpfechaGeneracion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Multa";
            this.Text = "agregarMulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpfechaGeneracion;
        private System.Windows.Forms.DateTimePicker dtpPago;
        private System.Windows.Forms.TextBox valorMulta;
        private System.Windows.Forms.TextBox codigoPrestamo;
        private System.Windows.Forms.TextBox codigoCliente;
        private System.Windows.Forms.DataGridView dgvM;
        private System.Windows.Forms.Button insertarMulta;
        private System.Windows.Forms.Button modificarMulta;
        private System.Windows.Forms.Button eliminarMulta;
        private System.Windows.Forms.Button showMultas;
        private System.Windows.Forms.TextBox idMulta;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}