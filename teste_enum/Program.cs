// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//using System;

class Program
{
    enum carros
    {
        carros_ruim, carro_maisoumenos, carro, carro_bom, carro_otimo
    };
        static void Main(string[] args)
        {
            Console.WriteLine("olá mundoo");
            int car = (int)carros.carro_maisoumenos;
            Console.WriteLine("O número do {0} é {1};", carros.carro_maisoumenos, car);
            limparounao();

            static void limparounao(){
            Console.WriteLine("Deseja limpar a tela? S/N");
            char sn;
            sn = Convert.ToChar(Console.ReadLine());

            if(sn == 's' || sn == 'S'){
                Console.Clear();
            }
            else{
                Console.WriteLine("OK! Continuará com a tela SUJA E POLUIDA!!!");
            }
            }

            static void buscacar(){
            Console.Write("\nDigite o número que irei buscar: ");
            int busca;
            busca = Convert.ToInt32(Console.ReadLine());
            carros nomecar = (carros)busca;
            Console.WriteLine("O carro que está buscando é o {0}", nomecar);
        }
            //limparounao();
            buscacar();
            limparounao();
        }
}

/*
int res;

Console.WriteLine("Digite um número");
int v1 = (int)Console.ReadLine();
Console.WriteLine("Digite um número");
int v2 = (int)Console.ReadLine();
res = v1+v2;

Console.WriteLine("\n1° + 2° = {0}", res);
*/

// O TESTE ACIMA NÃO DEU CERTO, PENSEI QUE FUNCIONAVA IGUAL AO ENUM
