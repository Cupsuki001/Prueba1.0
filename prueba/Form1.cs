namespace prueba
{
    public partial class Form1 : Form
    {
        Eva1 a = new Eva1();
        Eva2 b = new Eva2();
        public Form1()
        {
            InitializeComponent();
        }

        private void prueba1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a.MdiParent = this;
            a.Show();
        }

        private void prueba2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b.MdiParent = this;
            b.Show();
        }
    }
}
