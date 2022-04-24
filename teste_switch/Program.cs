// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Hello, World!");

int tempo;
char escolha;

Console.WriteLine("     **Rio de Janeiro/RJ a Belo Horizonte/BH**");
Console.WriteLine("Escolha seu transporte:\n[a] Avião   |   [c] Carro   |   [o] Ônibus  ");
escolha = Convert.ToChar(Console.ReadLine());

switch(escolha){
    case 'a':
    case 'A':
        tempo = 50;
        break;
    case 'c':
    case 'C':
        tempo = 480;
        break;
    case 'o':
    case 'O':
        tempo = 660;
        break;
    default:
        tempo = -2;
        break;
}

if(tempo < 0){
    Console.WriteLine("Transporte Indisponível");
}
else{
    Console.WriteLine("Com este transporte a viagem vai demorar {0} minutos", tempo);
}