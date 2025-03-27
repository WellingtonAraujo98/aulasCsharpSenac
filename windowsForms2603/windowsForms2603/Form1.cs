using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForms2603
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao_Click(object sender, EventArgs e)
        {
            // crtl shift e barra de espaço nos paremetros
            // MessageBox.Show("Olá sou uma janela");
            // MessageBox.Show("Olá sou uma janela", "Messagebox.Show");
            // MessageBox.Show("Mensagem da janela", "Titulo da janela", MessageBoxButtons.YesNoCancel);
            //MessageBox.Show("Mensagem da janela", "Titulo da janela", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            DialogResult resultadoJanela =  MessageBox.Show("Mensagem da janela", "Titulo da janela", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop,MessageBoxDefaultButton.Button1);


            labelResultado.Text = labelResultado.ToString();

            if (resultadoJanela == DialogResult.Yes)
            {
                labelResultado.Text = "você escolheu a opção SIM";
            }
            else if (resultadoJanela == DialogResult.No) {
                labelResultado.Text = "Você escolheu a opção NÃO";
            } else
            {
                labelResultado.Text = null;
            }





                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random numberRandom = new Random(DateTime.Now.Millisecond);
            //labelResultado.Text = numberRandom.Next(1,99).ToString();
            labelResultado.Text = numberRandom.NextDouble().ToString();
            
        }

        private void buttonDateTime_Click(object sender, EventArgs e)
        {
            DateTime myTime = new DateTime();
            //labelResultado.Text = DateTime.Now.ToString();
            //labelResultado.Text = DateTime.Now.ToLongDateString();
            //labelResultado.Text = DateTime.Now.ToShortDateString();
            // labelResultado.Text = DateTime.Now.ToLongTimeString();
            //labelResultado.Text = DateTime.Now.ToString("dd-MM-yyyy   -   HH-mm-ss");
            labelResultado.Text = DateTime.Now.AddDays(50).ToString();
            //labelResultado.Text = DateTime.Now.Subtract().ToString();
        }
    }
}
