using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meu_Programa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            int senha = int.Parse(txtSenha.Text);
            txtUsuario.Text = usuario;
            if (txtUsuario.Text == "Jhon Lenon" && txtSenha.Text == "6645")
            {
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha inválidos");
            }
        }
    }
}
