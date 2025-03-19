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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += ApplicationClosed;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        static void ApplicationClosed(object sender, FormClosingEventArgs e)
        {
            DialogResult resultadoAcao = MessageBox.Show("você  realmente deseja fechar a aplicação", "Sair da aplicação ?", MessageBoxButtons.YesNo);
            if (resultadoAcao == DialogResult.Yes) {
                Application.Exit();
            } else
            {
                e.Cancel = true;
            }

           
        }
    }
}
