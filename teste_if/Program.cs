using System;
class Program{
    static void Main(){
        Console.WriteLine("olá mundo");

        double n1, n2, n3, n4, res;

        Console.Write("Digite a nota: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota: ");
        n3 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite a nota: ");
        n4 = Convert.ToDouble(Console.ReadLine());

        res = n1+n2+n3+n4;

        static void limpar(){
            char respos;
            Console.WriteLine("Deseja limpar a tela? S/N");
            respos = Convert.ToChar(Console.ReadLine());

            if(respos == 's' || respos == 'S'){
                Console.Clear();
            }
            else{
                Console.WriteLine("OK! PORCOOOO!");
            }
        }

        limpar();

        //static void situação(){
            string situacao;

            if(res < 10){
                situacao = "Reprovado";
            }
            else if(res < 20){
                situacao = "Prova Final";
            }
            else{
                situacao = "Aprovado";
            }
        //}


        Console.WriteLine("Nota: {0} - Situação: {1}", res, situacao);

        
        
        
    }
}
