namespace prueba1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CMBmoneda = new System.Windows.Forms.ComboBox();
            this.BTNlimp1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MSKegre = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.MSKingre = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MSKaño = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXBtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNlimp = new System.Windows.Forms.Button();
            this.BTNacept = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TXBinteres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.COMBOplazo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MSKpestamo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RDsocial = new System.Windows.Forms.RadioButton();
            this.RDresi = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CMBmoneda);
            this.groupBox1.Controls.Add(this.BTNlimp1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MSKegre);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.MSKingre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MSKaño);
            this.groupBox1.Location = new System.Drawing.Point(12, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requisitos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(581, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(581, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 23);
            this.textBox1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Moneda";
            // 
            // CMBmoneda
            // 
            this.CMBmoneda.FormattingEnabled = true;
            this.CMBmoneda.Items.AddRange(new object[] {
            "Cordoba",
            "Dolar"});
            this.CMBmoneda.Location = new System.Drawing.Point(179, 94);
            this.CMBmoneda.Name = "CMBmoneda";
            this.CMBmoneda.Size = new System.Drawing.Size(121, 23);
            this.CMBmoneda.TabIndex = 8;
            // 
            // BTNlimp1
            // 
            this.BTNlimp1.Location = new System.Drawing.Point(676, 125);
            this.BTNlimp1.Name = "BTNlimp1";
            this.BTNlimp1.Size = new System.Drawing.Size(75, 23);
            this.BTNlimp1.TabIndex = 7;
            this.BTNlimp1.Text = "Limpiar";
            this.BTNlimp1.UseVisualStyleBackColor = true;
            this.BTNlimp1.Click += new System.EventHandler(this.BTNlimp1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Egreso";
            // 
            // MSKegre
            // 
            this.MSKegre.Location = new System.Drawing.Point(462, 94);
            this.MSKegre.Mask = "9999999";
            this.MSKegre.Name = "MSKegre";
            this.MSKegre.Size = new System.Drawing.Size(100, 23);
            this.MSKegre.TabIndex = 5;
            this.MSKegre.ValidatingType = typeof(int);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Verificar ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MSKingre
            // 
            this.MSKingre.Location = new System.Drawing.Point(324, 93);
            this.MSKingre.Mask = "9999999";
            this.MSKingre.Name = "MSKingre";
            this.MSKingre.Size = new System.Drawing.Size(100, 23);
            this.MSKingre.TabIndex = 3;
            this.MSKingre.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingreso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año de ingreso laboral";
            // 
            // MSKaño
            // 
            this.MSKaño.Location = new System.Drawing.Point(18, 94);
            this.MSKaño.Mask = "9999";
            this.MSKaño.Name = "MSKaño";
            this.MSKaño.Size = new System.Drawing.Size(126, 23);
            this.MSKaño.TabIndex = 0;
            this.MSKaño.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.TXBtotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BTNlimp);
            this.groupBox2.Controls.Add(this.BTNacept);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TXBinteres);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.COMBOplazo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.MSKpestamo);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prestamo";
            // 
            // TXBtotal
            // 
            this.TXBtotal.Location = new System.Drawing.Point(279, 191);
            this.TXBtotal.Name = "TXBtotal";
            this.TXBtotal.Size = new System.Drawing.Size(100, 23);
            this.TXBtotal.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total";
            // 
            // BTNlimp
            // 
            this.BTNlimp.Location = new System.Drawing.Point(451, 191);
            this.BTNlimp.Name = "BTNlimp";
            this.BTNlimp.Size = new System.Drawing.Size(75, 23);
            this.BTNlimp.TabIndex = 8;
            this.BTNlimp.Text = "Limpiar";
            this.BTNlimp.UseVisualStyleBackColor = true;
            this.BTNlimp.Click += new System.EventHandler(this.BTNlimp_Click);
            // 
            // BTNacept
            // 
            this.BTNacept.Location = new System.Drawing.Point(451, 150);
            this.BTNacept.Name = "BTNacept";
            this.BTNacept.Size = new System.Drawing.Size(75, 23);
            this.BTNacept.TabIndex = 7;
            this.BTNacept.Text = "Aceptar";
            this.BTNacept.UseVisualStyleBackColor = true;
            this.BTNacept.Click += new System.EventHandler(this.BTNacept_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Interes";
            // 
            // TXBinteres
            // 
            this.TXBinteres.Location = new System.Drawing.Point(592, 87);
            this.TXBinteres.Name = "TXBinteres";
            this.TXBinteres.Size = new System.Drawing.Size(100, 23);
            this.TXBinteres.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plazo";
            // 
            // COMBOplazo
            // 
            this.COMBOplazo.FormattingEnabled = true;
            this.COMBOplazo.Items.AddRange(new object[] {
            "120 meses",
            "180 meses",
            "240 meses"});
            this.COMBOplazo.Location = new System.Drawing.Point(421, 88);
            this.COMBOplazo.Name = "COMBOplazo";
            this.COMBOplazo.Size = new System.Drawing.Size(121, 23);
            this.COMBOplazo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prestamos";
            // 
            // MSKpestamo
            // 
            this.MSKpestamo.Location = new System.Drawing.Point(279, 87);
            this.MSKpestamo.Mask = "999999";
            this.MSKpestamo.Name = "MSKpestamo";
            this.MSKpestamo.Size = new System.Drawing.Size(100, 23);
            this.MSKpestamo.TabIndex = 1;
            this.MSKpestamo.ValidatingType = typeof(int);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RDsocial);
            this.groupBox3.Controls.Add(this.RDresi);
            this.groupBox3.Location = new System.Drawing.Point(18, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 175);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // RDsocial
            // 
            this.RDsocial.AutoSize = true;
            this.RDsocial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RDsocial.Location = new System.Drawing.Point(20, 115);
            this.RDsocial.Name = "RDsocial";
            this.RDsocial.Size = new System.Drawing.Size(94, 19);
            this.RDsocial.TabIndex = 1;
            this.RDsocial.TabStop = true;
            this.RDsocial.Text = "Interes Social";
            this.RDsocial.UseVisualStyleBackColor = false;
            // 
            // RDresi
            // 
            this.RDresi.AutoSize = true;
            this.RDresi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RDresi.Location = new System.Drawing.Point(20, 53);
            this.RDresi.Name = "RDresi";
            this.RDresi.Size = new System.Drawing.Size(84, 19);
            this.RDresi.TabIndex = 0;
            this.RDresi.TabStop = true;
            this.RDresi.Text = "Residencial";
            this.RDresi.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button BTNlimp1;
        private Label label6;
        private MaskedTextBox MSKegre;
        private Button button3;
        private MaskedTextBox MSKingre;
        private Label label2;
        private Label label1;
        private MaskedTextBox MSKaño;
        private GroupBox groupBox2;
        private Button BTNlimp;
        private Button BTNacept;
        private Label label5;
        private TextBox TXBinteres;
        private Label label4;
        private ComboBox COMBOplazo;
        private Label label3;
        private MaskedTextBox MSKpestamo;
        private GroupBox groupBox3;
        private RadioButton RDsocial;
        private RadioButton RDresi;
        private BindingSource bindingSource1;
        private TextBox TXBtotal;
        private Label label7;
        private Label label8;
        private ComboBox CMBmoneda;
        private Label label9;
        private TextBox textBox1;
    }
}