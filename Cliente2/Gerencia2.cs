using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente2
{
    internal class Gerencia2
    {
        //para colocar metodos para o programa

        //public static int ultimaMatricula = 0;
        public static List<Cliente2> lista_cliente;
        public void Inicializacao()
        {
            if (File.Exists("listacliente.txt"))
            {
                Stream arqEnt = File.Open("listacliente.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(arqEnt);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    /*
                    Funcionario funcionario = new Funcionario();
                    funcionario.matricula = Convert.ToInt32(linha);
                    funcionario.nome = leitor.ReadLine();
                    funcionario.cargo = leitor.ReadLine();
                    funcionario.salario = Convert.ToDouble(leitor.ReadLine());
                    cadastro.Add(funcionario);
                    ultimaMatricula = funcionario.matricula;
                    linha = leitor.ReadLine();
                    */
                    Cliente2 cliente = new Cliente2();
                    cliente.Nome = leitor.ReadLine();
                    cliente.CPF = leitor.ReadLine();
                    cliente.Endereco = leitor.ReadLine();
                    lista_cliente.Add(cliente);//referente a lista criada no inicio do codigo
                    //ultimaMatricula = funcionario.matricula;

                    linha = leitor.ReadLine();
                }
                leitor.Close();
                arqEnt.Close();
            }
        }
        
        public void Finalizacao()
            {
                Stream arqSai = File.Open("listacliente.txt", FileMode.Create);
                StreamWriter escritor = new StreamWriter(arqSai);
            //Cliente2 c = new Cliente2();
            List<Cliente2> lista = new List<Cliente2>();

            foreach (Cliente2 cliente in lista)
                {
                    escritor.WriteLine(cliente.Nome);
                    escritor.WriteLine(cliente.CPF);
                    escritor.WriteLine(cliente.Endereco);
                    //escritor.WriteLine(f.salario);
                }
                escritor.Close();
                arqSai.Close();
            }
        

        public static void Cadastrar()
        {
            /*
            Funcionario funcionario = new Funcionario();
            ultimaMatricula++;
            funcionario.matricula = ultimaMatricula;
            Console.Write("Informe o nome do funcionário: ");
            funcionario.nome = Console.ReadLine();
            Console.Write("Informe o cargo: ");
            funcionario.cargo = Console.ReadLine();
            Console.Write("Informe o salário: ");
            funcionario.salario = Convert.ToDouble(Console.ReadLine());
            cadastro.Add(funcionario);
            */
            Cliente2 cliente = new Cliente2();
            Cadastrar c1 = new Cadastrar();
            lista_cliente.Add(cliente);

            /*c1.txt_nome.Text = cliente.Nome;
            c1.txt_cpf.Text = cliente.CPF;
            c1.txt_endereco.Text = cliente.Endereco;
            */
        }



    }
}
