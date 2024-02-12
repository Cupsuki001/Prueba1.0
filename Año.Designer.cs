namespace prueba1
{
    partial class Año
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
            MSKaño = new MaskedTextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            TXBedad = new TextBox();
            TXBresult = new TextBox();
            BTNcalcular = new Button();
            BTNlimpiar = new Button();
            BTNsalir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // MSKaño
            // 
            MSKaño.Location = new Point(30, 78);
            MSKaño.Mask = "9999";
            MSKaño.Name = "MSKaño";
            MSKaño.Size = new Size(160, 27);
            MSKaño.TabIndex = 0;
            MSKaño.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el año de nacimiento";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonShadow;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TXBedad);
            groupBox1.Controls.Add(TXBresult);
            groupBox1.Location = new Point(271, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 84);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 3;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 41);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "Etapa escolar";
            // 
            // TXBedad
            // 
            TXBedad.Location = new Point(196, 76);
            TXBedad.Name = "TXBedad";
            TXBedad.Size = new Size(125, 27);
            TXBedad.TabIndex = 1;
            // 
            // TXBresult
            // 
            TXBresult.Location = new Point(167, 43);
            TXBresult.Name = "TXBresult";
            TXBresult.Size = new Size(187, 27);
            TXBresult.TabIndex = 0;
            // 
            // BTNcalcular
            // 
            BTNcalcular.Location = new Point(62, 149);
            BTNcalcular.Name = "BTNcalcular";
            BTNcalcular.Size = new Size(94, 29);
            BTNcalcular.TabIndex = 3;
            BTNcalcular.Text = "Calcular";
            BTNcalcular.UseVisualStyleBackColor = true;
            BTNcalcular.Click += BTNcalcular_Click;
            // 
            // BTNlimpiar
            // 
            BTNlimpiar.Location = new Point(310, 181);
            BTNlimpiar.Name = "BTNlimpiar";
            BTNlimpiar.Size = new Size(94, 29);
            BTNlimpiar.TabIndex = 4;
            BTNlimpiar.Text = "Limpiar";
            BTNlimpiar.UseVisualStyleBackColor = true;
            BTNlimpiar.Click += BTNlimpiar_Click;
            // 
            // BTNsalir
            // 
            BTNsalir.Location = new Point(531, 181);
            BTNsalir.Name = "BTNsalir";
            BTNsalir.Size = new Size(94, 29);
            BTNsalir.TabIndex = 5;
            BTNsalir.Text = "Salir";
            BTNsalir.UseVisualStyleBackColor = true;
            BTNsalir.Click += BTNsalir_Click;
            // 
            // Año
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 222);
            Controls.Add(BTNsalir);
            Controls.Add(BTNlimpiar);
            Controls.Add(BTNcalcular);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(MSKaño);
            Name = "Año";
            Text = "Año";
            Load += Año_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox MSKaño;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox TXBresult;
        private Button BTNcalcular;
        private Button BTNlimpiar;
        private Button BTNsalir;
        private Label label3;
        private Label label2;
        private TextBox TXBedad;
    }
}