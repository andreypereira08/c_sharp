// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program{
    static void Main(){
        Console.Write("\nolá mundo\n");

        int v1 = 13;
        double v2 = v1;

        Console.WriteLine(v2);
        //dará certo pois a conversão no caso int para double é implicita (ou algo assim), mas a recíproca é inválida;

        
        double v3 = 4.7;
        int v4 = (int)v3;// isso é typecast, converti o tipo double em int;
        //em alguns caso temos de fazer o type cast, e pode ser utilizado além desse tipos primitivos;

        Console.WriteLine(v4);
        
    }
}
