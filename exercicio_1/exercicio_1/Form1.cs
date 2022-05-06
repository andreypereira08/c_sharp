using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mudanca_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != "" && cbx_turma.Text != "")
            {
                MessageBox.Show("OI " + txt_nome.Text + ", bem-vindo a turma " + cbx_turma.Text);
            }
            
            /*
            lbl_principal.ForeColor = Color.Green;
            btn_mudanca.BackColor = Color.Red;
            btn_mudanca.ForeColor = Color.Green;
            btn_mudanca.Text = "Clique Aqui para ficar verde";

            */
            if (btn_mudanca.BackColor == Color.Red)
            {
                lbl_principal.ForeColor = Color.Green;
                btn_mudanca.BackColor = Color.Green;
                btn_mudanca.ForeColor = Color.Red;
                btn_mudanca.Text = "Clique Aqui para ficar vermelho";
            }
            else
            {
                lbl_principal.ForeColor = Color.Red;
                btn_mudanca.BackColor = Color.Red;
                btn_mudanca.ForeColor = Color.Green;
                btn_mudanca.Text = "Clique Aqui para ficar verde";
            }

            
            
        }

        private void cbx_turma_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            if (txt_nome.Text != "")
            {
                cbx_turma.Enabled = true;
            }
            else
            {
                cbx_turma.Enabled = false;
            }
        }
    }
}
