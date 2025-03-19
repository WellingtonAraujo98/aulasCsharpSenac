using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLoginEMaistelas
{
    public partial class LoginApp : Form
    {
        public LoginApp()
        {
            InitializeComponent();
        }

        private void LabelUser_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text)|| string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtUser.Text == "admin" && txtPassword.Text == "1234")
            {
                this.Hide(); //escondendo o formulario atual

                MainForm mainForm = new MainForm();
                mainForm.Show();
            } else
            {
                MessageBox.Show("Usuário ou senha incorretos. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
