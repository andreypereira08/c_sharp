using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str_manip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp, perg;
            Console.WriteLine("digite algo em minusculo, e será convertido para MAIUSCULO: ");

            resp = Console.ReadLine();

            Console.WriteLine(resp.ToUpper());
            Console.WriteLine(resp.ToLower());

            Console.WriteLine("verifique se tem o que pretende");
            perg = Console.ReadLine();

            Console.Write("contem {0}: ", perg);
            Console.WriteLine(resp.Contains(perg));
            Console.Write("Contem deLta: ");
            Console.WriteLine(resp.Equals("deLta"));
            Console.ReadKey();
        }
    }
}
