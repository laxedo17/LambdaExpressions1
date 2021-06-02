using System;

namespace LambdaExpressions2
{
    class Program
    {
        public delegate void DelegateSenParametros();
        public delegate int DelegateConUnParametroInt(int x);
        public delegate void DelegateConDousParametrosInt(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("***Experimentando lambda expressions con diferentes parametros.***\n");
            // Sin lambda expressions
            Metodo1(5, 10);

            // Usando lambda expressions
            DelegateSenParametros delSenParam = () => Console.WriteLine("Usando expression lambda sen parametros, mostrando Hola por pantalla");
            delSenParam();
            DelegateConUnParametroInt delConUnParamInt = (x) => x * x;
            Console.WriteLine("\n Usando lambda expression con un parametro, o cuadrado de 5 e {0}", delConUnParamInt(5));

            DelegateConDousParametrosInt delConDousParamInt = (int x, int y) =>
              {
                  Console.WriteLine("\nUsando lambda expression con dous parametros.");
                  Console.WriteLine("Chamase statement lambda porque ten un bloque de statements -instruccions- no seu corpo. Isto e diferente a unha lambda expression, que consta dunha sola expresion");
                  Console.WriteLine("Esta lambda acepta dous parametros.");
                  int suma = x + y;
                  Console.WriteLine("A suma de {0} e {1} = {2}", x, y, suma);
              };
            //se vas a usar mais de 3 linhas nunha lambda expression case e mellor usar un metodo e non unha lambda expression

            delConDousParamInt(10, 20);

            Console.ReadKey();
        }

        private static void Metodo1(int x, int y)
        {
            Console.WriteLine("\nEste e Metodo1() sin expresion lambda");
            int suma = x + y;
            Console.WriteLine("A suma de {0} e {1} = {2}", x, y, suma);
        }
    }
}
