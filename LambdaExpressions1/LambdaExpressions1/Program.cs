using System;

namespace LambdaExpressions1
{
    public delegate int Meudel(int x, int y);

    class Program
    {
        public static int Suma(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***Explorando o uso de lambda expression e comparando con outras tecnicas. ***");
            // Sin usar delegates ou lambda expression             
            Console.WriteLine(" Usando un metodo normal.");
            int x = 21, y = 79;
            Console.WriteLine(" Invocando o metodo Suma() dunha maneira comun sin usar un delegate.");
            Console.WriteLine("Suma de {0} e {1} e = {2}", x, y, Suma(x, y));
            /* Usando un Delegate(Inicializacion con un metodo nomeado)*/
            Meudel del1 = new Meudel(Suma);
            Console.WriteLine("\n Usando un delegate agora."); 
            Console.WriteLine("Invocando o metodo Suma() co uso dun delegate.");
            Console.WriteLine("Suma de {0} e {1} e = {2}", x, y, del1(x, y));

            // Usando Anonymous method (C# 2.0 en diante)
            Meudel del2 = delegate (int x, int y) { return x + y; };
            Console.WriteLine("\n Usando un metodo anonimo agora."); Console.WriteLine("Chamado o metodo Suma() con un anonymous method.");
            Console.WriteLine("Suma de {0} e {1} e = {2}", x, y, del2(x, y));

            // Utilizando lambda expressions
            Console.WriteLine("\n Usando lambda expression agora");
            Meudel sumaDeDousEnteiros = (x, y) => x + y;
            Console.WriteLine("Suma de {0} e {1} e = {2}", x, y, sumaDeDousEnteiros(x, y));
            Console.ReadKey();
        }
    }
}
