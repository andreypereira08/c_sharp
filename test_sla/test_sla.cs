using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
static void Main(string[] args)
{
string nome, saida, saida2;
int i, i2, pos = 0, pos2 = 0;

Console.Write("Informe o nome: ");
nome = Console.ReadLine();

for (i = 0; i < nome.Length; i++)
{
Console.WriteLine(nome[i]);
}

for (i = nome.Length - 1; i > 0; i--)
{
if (nome[i] == ' ')
{
pos = i;
break;
}
}
for (i2 = 0; i2 < nome.Length; i2++)
{
if (nome[i2] == ' ')
{
pos2 = i2 + 1;
break;
}
}
Console.WriteLine(nome.Length);
Console.WriteLine(pos);

saida = nome.Substring(pos + 1, nome.Length - pos - 1) + ", " + nome.Substring(0, pos);

saida2 = Convert.ToChar(nome[0]) + "." + Convert.ToChar(nome[pos2]) + ". " + nome.Substring(pos + 1, nome.Length - pos - 1);

Console.WriteLine(saida);
Console.WriteLine(saida2);

Console.ReadLine();

}
}
