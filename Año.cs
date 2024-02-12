using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1
{
    public partial class Año : Form
    {
        public Año()
        {
            InitializeComponent();
        }

        private void Año_Load(object sender, EventArgs e)
        {
            TXBedad.Enabled = false;
            TXBresult.Enabled = false;
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {

            int año, tt;
            int lim = DateTime.Now.Year;
            try
            {

                año = Convert.ToInt16(MSKaño.Text);
                

                if (año >= 1924 || año <= lim)
                {
                    tt = lim - año;
                    if (tt >= 3 && tt <= 5)
                    {
                        TXBresult.Text = "Preescolar";
                        TXBedad.Text = tt.ToString();
                    }
                    if (tt >= 6 && tt <= 11)
                    {
                        TXBresult.Text = "Primaria";
                        TXBedad.Text = tt.ToString();
                    }
                    if (tt >= 12 && tt <= 16)
                    {
                        TXBresult.Text = "Secundaria";
                        TXBedad.Text = tt.ToString();
                    }
                    if (tt >= 17 && tt <= 25)
                    {
                        TXBresult.Text = "Universidad";
                        TXBedad.Text = tt.ToString();
                    }
                    else 
                    {
                        MessageBox.Show("La persona ya esta trabajando");
                    }
                }
                else 
                {
                    MessageBox.Show("El año tiene que estar entre 1924 y 2024");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puede estar en blanco");
            }
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            TXBedad.Text = "";
            TXBresult.Text = "";
            MSKaño.Text = "";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
