// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("responda a seguinte equação: 3² \n(a) 6 \n(b) 3 \n(c) 27 \n(d) 9 \nResposta: ");
char escolha;
escolha = Convert.ToChar(Console.ReadLine());

switch(escolha){
    case 'a':
    case 'A':
        Console.WriteLine("Errado!!!");
        break;
    case 'b':
    case 'B': 
        Console.WriteLine("Errado!!!");
        break;
    case 'c':
    case 'C':
        Console.WriteLine("Errado!!!");
        break;
    case 'd':
    case 'D':
        Console.WriteLine("Exato!!!");
        break;
    default:
        break;
}