using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente2
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cliente2 cliente = new Cliente2();
            Gerencia2 g2 = new Gerencia2();
            
            g2.Inicializacao();

            //recebendo os dados
            txt_nome.Text = cliente.Nome;

            if(txt_cpf.Text == cliente.CPF)
            {
                MessageBox.Show("CPF já cadastrado, tente outro");
            }
            else
            {
                txt_cpf.Text = cliente.CPF;
            }

            txt_endereco.Text = cliente.Endereco;
            
            //g2.Finalizacao();

            //lista_cliente.Add(cliente);
            //List<Cliente2> lista_cliente = new List<Cliente2>();
            //lista_cliente.Add(cliente);


        }
    }
}
