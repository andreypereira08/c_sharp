using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\andre\Pictures\escola\teste\caminho.txt";
            
            /*
            using(FileStream criar = File.Create(caminho))
            {
                criar.Close();
            }
            */

            if (File.Exists(caminho))
            {
                Console.WriteLine("arquivo já existente");
            }
            else
            {
                char resp;
                Console.WriteLine("arquivo não existente. Deseja cria-lo? (S/N)");
                resp = Convert.ToChar(Console.ReadLine());
                if(resp == 'S' || resp == 's')
                {
                    Console.WriteLine("criando arquivo...");
                    
                    using(FileStream criar = File.Create(caminho))
                    {
                        criar.Close();
                    }
                    
                    Console.WriteLine("Arquivo criado");
                }
                else if(resp == 'N' || resp == 'n')
                {
                    Console.WriteLine("Ok. não criarei-o");
                }
                else
                {
                    Console.WriteLine("Está não é uma das opções.");
                }
            }

            //ja criado e agora...

            //asssim que se escreve no caminho.txt
            
            using(StreamWriter escreva = File.AppendText(caminho))
            {
                escreva.WriteLine("**olá mundo**");
                escreva.WriteLine("**olá parker**");
            }

            string letd;
            using(StreamReader leia = File.OpenText(caminho))
            {
                letd = leia.ReadToEnd();
            }

            Console.WriteLine("aperte [ENTER]");
            Console.ReadKey();
        }
    }
}
