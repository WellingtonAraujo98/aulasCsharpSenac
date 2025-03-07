namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Calculadora()
        {
            public double Somar(double n1,double n2)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            label1.Text = Convert.ToString(resultado);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   //botão soma
            double resultado = double.Parse(textBox1.Text + textBox2.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //botão diminuir
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //botão multplicar
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //botão diminuir
        }
    }
}
