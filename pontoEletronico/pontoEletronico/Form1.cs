using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pontoEletronico;

namespace pontoEletronico
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "well" && textBoxPassword.Text == "1234")
            {
                
                using (var form = new telaInicial())
                {
                    form.ShowDialog();
                    
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

