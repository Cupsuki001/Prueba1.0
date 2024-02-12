namespace prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            TXBinteres.Enabled = false;
            TXBtotal.Enabled = false;
            textBox1.Enabled = false;
        }

        private void BTNacept_Click(object sender, EventArgs e)
        {
            double pres , inter , tot;
            try 
            {
                pres = Convert.ToDouble(MSKpestamo.Text);

                if (RDresi.Checked == true) 
                {
                   if(pres >=30000 && pres <= 250000) 
                   {
                        if (COMBOplazo.Text == "")
                        {
                            MessageBox.Show("Ingrese un plazo");
                        }
                        else
                        {
                            if (COMBOplazo.SelectedItem.Equals("120 meses"))
                            {
                                inter = pres * 180;
                                tot = pres + inter;
                                TXBinteres.Text = inter.ToString();
                                TXBtotal.Text = tot.ToString();
                                MessageBox.Show("Rellene los requisitos para su prestamo");
                               
                                groupBox1.Enabled = true;
                            }
                            if (COMBOplazo.SelectedItem.Equals("180 meses"))
                            {
                                inter = pres * 270;
                                tot = pres + inter;
                                TXBinteres.Text = inter.ToString();
                                TXBtotal.Text = tot.ToString();
                                MessageBox.Show("Rellene los requisitos para su prestamo");
                                
                                groupBox1.Enabled = true;
                            }
                            if (COMBOplazo.SelectedItem.Equals("240 meses"))
                            {
                                inter = pres * 360;
                                tot = pres + inter;
                                TXBinteres.Text = inter.ToString();
                                TXBtotal.Text = tot.ToString();
                                MessageBox.Show("Rellene los requisitos para su prestamo");
                                
                                groupBox1.Enabled = true;
                            }

                        }
                   }
                   else 
                   {
                        MessageBox.Show("El prestamo tiene que estar entre 30000 a 250000"); 
                   }
                    
                }   
                else 
                {
                    if (pres >= 20000 && pres <= 29000)
                    {
                        if (COMBOplazo.Text == "")
                        {
                            MessageBox.Show("Ingrese un plazo");
                        }
                        else
                        {
                            if (COMBOplazo.SelectedItem.Equals("120 meses"))
                            {
                                inter = pres * 110;
                                tot = pres + inter;
                                TXBinteres.Text = inter.ToString();
                                TXBtotal.Text = tot.ToString();
                                MessageBox.Show("Rellene los requisitos para su prestamo");
                                
                                groupBox1.Enabled = true;
                            }
                            if (COMBOplazo.SelectedItem.Equals("180 meses"))
                            {
                                inter = pres * 165;
                                tot = pres + inter;
                                TXBinteres.Text = inter.ToString();
                                TXBtotal.Text = tot.ToString();
                                MessageBox.Show("Rellene los requisitos para su prestamo");
                                
                                groupBox1.Enabled = true;
                            }
                            if (COMBOplazo.SelectedItem.Equals("240 meses"))
                            {
                                inter = pres * 220;
                                tot = pres + inter;
                                TXBinteres.Text = inter.ToString();
                                TXBtotal.Text = tot.ToString();
                                MessageBox.Show("Rellene los requisitos para su prestamo");
                                
                                groupBox1.Enabled = true;
                            }

                        }
                    }
                    else 
                    {
                        MessageBox.Show("El prestamo tiene que estar entre 20000 a 29000");
                    }
                }
                      
            }
            catch (Exception) 
            {
                MessageBox.Show("No puede estar en blanco");
            }
        }

        private void BTNlimp_Click(object sender, EventArgs e)
        {
            MSKpestamo.Text = "";
            TXBinteres.Text = "";
            TXBtotal.Text = "";
            COMBOplazo.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double año , ing , egre , tt , conv;
            try 
            {
                año = Convert.ToDouble(MSKaño.Text);
                ing = Convert.ToDouble(MSKingre.Text);
                egre = Convert.ToDouble(MSKegre.Text);

                if(año == 2024) 
                {
                    MessageBox.Show("No cumple con los años requerido");
                }
                else 
                {
                    if (CMBmoneda.SelectedItem.Equals("Cordoba")) 
                    {
                        if (egre >= ing && ing >= 22194)
                        {
                            MessageBox.Show("Los egresos no pueden ser mayor que los ingresos");
                        }
                        else
                        {
                            tt = ing - egre;
                            textBox1.Text = tt.ToString();
                        }
                    }
                    else 
                    {
                        conv = ing * 36.99;
                       
                        if (egre >= ing && ing >= 600)
                        {
                            MessageBox.Show("Los egresos no pueden ser mayor que los ingresos");
                        }
                        else
                        {
                            
                            tt = ing - egre;
                            textBox1.Text = tt.ToString();
                        }
                    }
                   
                      
                    
                }
            }
            catch 
            {
            
            }
        }

        private void BTNlimp1_Click(object sender, EventArgs e)
        {
            MSKaño.Text = "";
            CMBmoneda.Text = "";
            MSKingre.Text = "";
            MSKegre.Text = "";
        }
    }
}