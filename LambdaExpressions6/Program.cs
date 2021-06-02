using System;

namespace LambdaExpressions6_TuplesEnLambdaExpressions
{
    delegate Tuple<int, double> CreaDelegateDoble(Tuple<int, double> entrada);


    class Program
    {
        static Tuple<int, double> CreaMetodoDoble(Tuple<int, double> entrada)
        {
            return Tuple.Create(entrada.Item1 * 2, entrada.Item2 * 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***Usando Tuples en Lambda Expression.***");
            var tupleEntrada = Tuple.Create(1, 2.3);
            Console.WriteLine("Contido de tuple de entrada e como sigue:");
            Console.WriteLine("Primeiro Elemento: " + tupleEntrada.Item1);
            Console.WriteLine("Segundo Elemento: " + tupleEntrada.Item2);
            var tupleResultante = CreaMetodoDoble(tupleEntrada);
            Console.WriteLine("\nPasando tuple como un argumento de entrada nun metodo normal o cal de novo devolve un tuple");
            Console.WriteLine("O contido do tuple resultante e o seguinte:");

            Console.WriteLine("Primeiro elemento: " + tupleResultante.Item1);
            Console.WriteLine("Segundo elemento: " + tupleResultante.Item2);
            Console.WriteLine("\nAgora usando un delegate e unha lambda expression co tuple.");

            CreaDelegateDoble obxetoDelegate = (Tuple<int, double> entrada) => Tuple.Create(entrada.Item1 * 2, entrada.Item2 * 2);
            var tupleResultanteUsandoLambda = obxetoDelegate(tupleEntrada);
            Console.WriteLine("Usando lambda expression, o contido do tuple resultante e o seguinte:");
            Console.WriteLine("Primeiro elemento: " + tupleResultanteUsandoLambda.Item1);
            Console.WriteLine("Segundo elemento: " + tupleResultanteUsandoLambda.Item2);
            Console.ReadKey();
        }
    }
}
