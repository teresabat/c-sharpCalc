namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            labelResult.Text = (float.Parse(TextBox1.Text) + float.Parse(TextBox2.Text)).ToString();
        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            labelResult.Text = (float.Parse(TextBox1.Text) - float.Parse(TextBox2.Text)).ToString();
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            labelResult.Text = (float.Parse(TextBox1.Text) * float.Parse(TextBox2.Text)).ToString();
        }

        private void btDividir_Click_1(object sender, EventArgs e)
        {
            labelResult.Text = (float.Parse(TextBox1.Text) / float.Parse(TextBox2.Text)).ToString();
        }
    }
}
