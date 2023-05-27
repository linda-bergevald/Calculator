namespace Miniräknare
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            textBox1.Text = currentCalculation;
        }
    }
}