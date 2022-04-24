using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco2
{
    public partial class Form1 : Form
    {
        private Conta c; //atenção
        public Form1()
        {
            InitializeComponent();
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.c = new Conta();
            c.Numero = 1;
            Cliente cliente = new Cliente("victor");
            c.Titular = cliente.Nome;

            textoTitular.Text = c.Titular;
            textoNumero.Text = Convert.ToString(c.Numero);
            textoSaldo.Text = Convert.ToString(c.Saldo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOpereacao = Convert.ToDouble(valorDigitado);
            c.Deposita(valorOpereacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Depósito efetuado!!!");

        }

        private void btn_saque_Click(object sender, EventArgs e)
        {
            string valorDigitado_s = textoValor.Text;
            double valorOperacao_s = Convert.ToDouble(valorDigitado_s);
            c.Saque(valorOperacao_s);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Saque efetuado!!!");
        }
    }
}
