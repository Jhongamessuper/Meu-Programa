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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string placa, modelo, cor;
            placa = txtPlaca.Text;
            modelo = txtModelo.Text;
            cor = txtCor.Text;
            if (placa == txtPlaca.Text && modelo == txtModelo.Text && cor == txtCor.Text)
            {
                MessageBox.Show("Veículo foi adicionado no pátio");
            }

        }
    }
}