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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ex1_Click(object sender, EventArgs e)
        {
            exercicio_1 ex1 = new exercicio_1();
            ex1.ShowDialog();
        }

        private void btn_ex2_Click(object sender, EventArgs e)
        {
            exercicio2 ex2 = new exercicio2();
            ex2.ShowDialog();
        }

        private void btn_ex3_Click(object sender, EventArgs e)
        {
            exercicio3 ex3 = new exercicio3();
            ex3.ShowDialog();
        }

        private void btn_ex4_Click(object sender, EventArgs e)
        {
            exercicio4 ex4 = new exercicio4();
            ex4.ShowDialog();
        }
    }
}
