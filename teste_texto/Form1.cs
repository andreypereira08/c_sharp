using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_texto
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //public static int ultimaMatricula = 0;
            //public static List<Funcionario> cadastro;
        
            if (File.Exists("ola.txt"))
            {
                Stream arqEnt = File.Open("ola.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(arqEnt);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                arqEnt.Close();
            }
            Stream arqSai = File.Open("ola.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(arqSai);
            
            escritor.WriteLine("olá ");
            
            escritor.Close();
            arqSai.Close();


        }
    }
}
