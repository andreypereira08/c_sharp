using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora2
{
    public partial class Form1 : Form
    {
        private double operando1;
        private char operador;
        private double operando2;
        private double Resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_exibicao.Text = txt_exibicao.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_exibicao.Text = txt_exibicao.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_exibicao.Text = txt_exibicao.Text + "3";
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToDouble(txt_exibicao.Text);
            operador = '+';
            txt_exibicao.Text = "";
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            operando2 = Convert.ToDouble(txt_exibicao.Text);
            switch (operador)
            {
                case '+':
                    Resultado = operando1 + operando2;
                    break;
                case '-':
                    Resultado = operando1 - operando2;
                    break;
                case '*':
                    Resultado = operando1 * operando2;
                    break;
                case '/':
                    Resultado = operando1 / operando2;
                    break;
            }
            txt_exibicao.Text = Convert.ToString(Resultado);
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToDouble(txt_exibicao.Text);
            operador = '*';
            txt_exibicao.Text = "";
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToDouble(txt_exibicao.Text);
            operador = '/';
            txt_exibicao.Text = "";
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToDouble(txt_exibicao.Text);
            operador = '-';
            txt_exibicao.Text = "";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_exibicao.Text = "";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_exibicao.Text = txt_exibicao.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_exibicao.Text = txt_exibicao.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_exibicao.Text = txt_exibicao.Text + "6";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_exibicao.Text = txt_exibicao.Text + "0";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_exibicao.Text = txt_exibicao.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_exibicao.Text = txt_exibicao.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_exibicao.Text = txt_exibicao.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
