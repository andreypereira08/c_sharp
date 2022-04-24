using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forrers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ferramentas = new Dictionary<int, string>();
            ferramentas.Add(01, "Martelo");
            ferramentas.Add(02, "Prego");
            ferramentas.Add(03, "Parafuso");
            ferramentas.Add(04, "Triturador");
            ferramentas.Add(05, "Rabimboca da Parafuseta");

            foreach(KeyValuePair<int, string> f in ferramentas)
            {
                Console.WriteLine(f);
            }
            ferramentas.Remove(02);

            //chave_tal para determinar a chave desejada
            const int chave_tal = 2;
            
            if(ferramentas.ContainsKey(chave_tal))
            {
                Console.WriteLine("Chave {0} está no Dictionary", chave_tal);
                //caso a chave esteja no dictionary
            }
            else
            {
                Console.WriteLine("Chave {0} NÃO está no Dictionary", chave_tal);
                //caso a chave NÃO esteja no dictionary
            }

            Console.WriteLine("\n \nAperte [ENTER]");
            Console.ReadKey();
        }
    }
}
