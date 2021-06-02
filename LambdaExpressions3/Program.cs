using System;

namespace LambdaExpressions3_DemoMetodoExpressionBodied
{
    class Test
    {
        public int CalcularSuma1(int x, int y)
        {
            int suma = x + y;
            return suma;
        }

        /* Expression-bodied method non esta disponible en C#5.          
        C#6.0 en adiante, podes usar a misma sintaxis de expression para definir un metodo non-lambda dentro dunha clase
        Funciona ben con unha expresion simple, por exemplo, para a sintaxis dunha expression lambda pero non para un statement lambda de varias linhas */
        public int CalcularSuma2(int x, int y) => x + y;//ok

        // O seguinte codigo causa un erro no tempo de compilacion
        // Para metodos expression-bodied
        // Non podes usar un statement lambda         
        // int CalcularSuma3(int x, int y) =>{         
        // int suma = x + y;         
        // return suma;         
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Experimentando lambda expression con expression-bodied method.***\n");
            // Usando metodo normal
            Test test = new Test();
            int result1 = test.CalcularSuma1(5, 7);
            Console.WriteLine("\nUsando un metodo normal, CalcularSuma1(5,7), resultado", result1);
            //Usando sintaxis de expression bodied method
            int result2 = test.CalcularSuma2(5, 7);
            Console.WriteLine("\nUsando sintaxis de expression bodied method, CalcularSuma2(5,7), resultado", result2);
            Console.ReadKey();

        }
    }
}
