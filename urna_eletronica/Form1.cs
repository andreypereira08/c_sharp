using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urna_eletronica
{
    public partial class Form1 : Form
    {
        private int cont11;
        private int cont22;
        private int cont33;
        private int contnulo;
        private int cont_branco;

        public Form1()
        {
            InitializeComponent();
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "1";
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "2";
        }

        private void btn_3_Click_1(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "3";
        }

        private void btn_4_Click_1(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "4";
        }

        private void btn_5_Click_1(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "5";
        }

        private void btn_6_Click_1(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "6";
        }

        private void btn_7_Click_1(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "7";
        }

        private void btn_8_Click_1(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "8";
        }

        private void btn_9_Click_1(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "9";
        }

        private void btn_0_Click_1(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "0";
        }

        private void btn_branco_Click_1(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("confirma o voto em branco?", "Confirmação", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                cont_branco = cont_branco + 1;
            }
        }

        private void btn_corrige_Click_1(object sender, EventArgs e)
        {
            txt_visor.Text = "";
        }

        private void btn_confirma_Click_1(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("confirma o voto do numero " + txt_visor.Text + "?", "Confirmação", MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                switch (txt_visor.Text)
                {
                    case "11":
                        cont11 = cont11 + 1;
                        break;

                    case "22":
                        cont22 = cont22 + 1;
                        break;

                    case "33":
                        cont33 = cont33 + 1;
                        break;

                    default:
                        contnulo = contnulo + 1;
                        break;

                }
            }


            if (txt_visor.Text == "144132")
            {
                MessageBox.Show("votos do candidato 11: " + cont11 + "\nvotos do candidato 22: " + cont22 + "\nvotos do candidato 33: " + cont33 + "\nvotos nulos: " + contnulo + "\nvoto branco: " + cont_branco);
            }

            txt_visor.Text = "";

        }
    }
}
