using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    public static int ultimocodigo = 0;
    public static List<Produto> cadastro;

    public static void Inicializacao()
    {
        if (File.Exists("produtos.txt"))
        {
            Stream arqEnt = File.Open("produtos.txt", FileMode.Open);
            StreamReader leitor = new StreamReader(arqEnt);
            string linha = leitor.ReadLine();
            while (linha != null)
            {
                Produto produto = new Produto();
                produto.codigo = Convert.ToInt32(linha);
                produto.nome = leitor.ReadLine();
                produto.precoUnitario = Convert.ToDouble(leitor.ReadLine());
                produto.quantidade = Convert.ToDouble(leitor.ReadLine());
                cadastro.Add(produto);
                ultimocodigo = produto.codigo;
                linha = leitor.ReadLine();
            }
            leitor.Close();
            arqEnt.Close();
        }
    }
    public static void Finalizacao()
    {
        Stream arqSai = File.Open("produtos.txt", FileMode.Create);
        StreamWriter escritor = new StreamWriter(arqSai);
        foreach (Produto p in cadastro)
        {
            escritor.WriteLine(p.codigo);
            escritor.WriteLine(p.nome);
            escritor.WriteLine(p.precoUnitario);
            escritor.WriteLine(p.quantidade);
        }
        escritor.Close();
        arqSai.Close();
    }
    public static void MontarMenu()
    {
        Console.Clear();
        Console.WriteLine("** M E N U **");
        Console.WriteLine("1-Incluir");
        Console.WriteLine("2-Consultar");
        Console.WriteLine("3-Alterar");
        Console.WriteLine("4-Excluir");
        Console.WriteLine("5-Listar");
        Console.WriteLine("6-Finalizar");
        Console.Write("Escolha a opção desejada: ");
    }
    public static void Cadastrar()
    {
        Produto produto = new Produto();
        ultimocodigo++;
        produto.codigo = ultimocodigo;
        Console.Write("Informe o nome do produto: ");
        produto.nome = Console.ReadLine();
        Console.Write("Informe o preço: ");
        produto.precoUnitario = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a quantidade: ");
        produto.quantidade = Convert.ToDouble(Console.ReadLine());
        cadastro.Add(produto);
    }
    public static void Consultar()
    {
        int numcod;
        Console.Write("Informe o número da matrícula: ");
        numcod = Convert.ToInt32(Console.ReadLine());
        foreach (Produto p in cadastro)
        {
            if (numcod == p.codigo)
            {
                Console.WriteLine("Nome: {0}", p.nome);
                Console.WriteLine("Preço: {0:F2}", p.precoUnitario);
                Console.WriteLine("Quantidade: {0}", p.quantidade);
                return;
            }
        }
        Console.WriteLine("Produto não cadastrado");
    }
    public static void Alterar()
    {
        int numcod;
        Console.Write("Informe Código: ");
        numcod = Convert.ToInt32(Console.ReadLine());
        foreach (Produto p in cadastro)
        {
            if (numcod == p.codigo)
            {
                char resp;
                string nomeAux;
                double quantAux, precoAux;
                Console.WriteLine("Deseja alterar o nome do produto '{0}'? (S/N)", p.nome);
                resp = Convert.ToChar(Console.ReadLine());
                if(resp == 'S' || resp == 's')
                    {
                    Console.Write("Informe o novo nome do produto: ");
                    nomeAux = Console.ReadLine();
                    if (!String.IsNullOrEmpty(nomeAux)) p.nome = nomeAux;
                    }
                
                Console.WriteLine("Deseja alterar o preço do produto 'R${0:F2}'? (S/N)", p.precoUnitario);
                resp = Convert.ToChar(Console.ReadLine());                
                 if (resp == 'S' || resp == 's')
                {
                    Console.Write("Informe o novo preço: ");
                    precoAux = Convert.ToDouble(Console.ReadLine());

                    if (precoAux != 0) p.precoUnitario = precoAux;
                }

                Console.WriteLine("Deseja alterar a quantidade '{0}'? (S/N)", p.quantidade);
                resp = Convert.ToChar(Console.ReadLine());
                if (resp == 'S' || resp == 's')
                    {
                    Console.Write("Informe a nova quantidade: ");
                    quantAux = Convert.ToDouble(Console.ReadLine());
                    if (quantAux != 0) p.quantidade = quantAux;
                    }
                return;
            }
        }
        Console.WriteLine("Produto não cadastrado");
    }
    public static void Excluir()
    {
        int numcod;
        char resp;
        Console.Write("Informe o código do produto: ");
        numcod = Convert.ToInt32(Console.ReadLine());
        foreach (Produto p in cadastro)
        {
            if (numcod == p.codigo)
            {
                Console.WriteLine("Nome: {0}", p.nome);
                Console.WriteLine("Preço: {0:F2}", p.precoUnitario);
                Console.WriteLine("Quantidade: {0}", p.quantidade);
                Console.Write("Confirma a exclusão do produto (S/N)? ");
                resp = Convert.ToChar(Console.ReadLine());
                if (resp == 'S' || resp == 's')
                {
                    cadastro.RemoveAll((Produto p2) => { return p2.codigo == numcod; });
                }
                return;
            }
        }
        Console.WriteLine("Funcionário não cadastrado");
    }
    public static void Listar()
    {
        foreach (Produto p in cadastro)
        {
            Console.WriteLine("Código: {0}", p.codigo);
            Console.WriteLine("Nome: {0}", p.nome);
            Console.WriteLine("Preço: {0:F2}", p.precoUnitario);
            Console.WriteLine("Quantidade: {0}", p.quantidade);
            Console.WriteLine();
        }
    }
    public static void Main(string[] args)
    {
        cadastro = new List<Produto>();
        char opcao;
        Inicializacao();
        MontarMenu();
        opcao = Convert.ToChar(Console.ReadLine());
        while (opcao != '6')
        {
            switch (opcao)
            {
                case '1':
                    Cadastrar();
                    break;
                case '2':
                    Consultar();
                    break;
                case '3':
                    Alterar();
                    break;
                case '4':
                    Excluir();
                    break;
                case '5':
                    Listar();
                    break;
                case '6': break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            if (opcao != '6')
            {
                Console.WriteLine();
                Console.Write("Tecla [ENTER] para continuar");
                Console.ReadLine();
            }
            MontarMenu();
            opcao = Convert.ToChar(Console.ReadLine());
        }
        Finalizacao();
        Console.WriteLine("** Fim do programa **");
    }
}