using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace periodo_do_dia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo)  == DialogResult.Yes)
                Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string turno = txtTurno.Text.ToUpper();
            string mensagem;

            if (turno == "M")
            {
                mensagem = "Bom dia";
            }
            else if (turno == "V")
            {
                mensagem = "Boa tarde";
            }
            else if (turno == "N")
            {
                mensagem = "Boa noite";
            }
            else
            {
                mensagem = "Valor inválido";
            }

            MessageBox.Show(mensagem);


        }
    }
}
