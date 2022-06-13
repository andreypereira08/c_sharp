using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16demaio
{
    public partial class exercicio2 : Form
    {
        

        public exercicio2()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(txt_altura.Text);
            double peso = Convert.ToDouble(txt_peso.Text);
            double imc = peso / Math.Pow(altura, 2);
            string situacao;

            if(imc < 20)
            {
                situacao = " - Abaixo do peso";
            }
            else if(imc < 25)
            {
                situacao = " - Peso normal";
            }
            else if (imc < 30)
            {
                situacao = " - Sobre peso";
            }
            else if (imc < 40)
            {
                situacao = "- Obeso";
            }
            else
            {
                situacao = " - Obeso Mórbido";
            }

            resultado_imc.Text = "seu IMC é : " + imc.ToString("N2") + situacao;

        }
    }
}
