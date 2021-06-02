using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions5_TestScopeVariableLocalUsandoLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Testeando o scope dunha variable local cunha lambda expression.***\n");
            #region Usando syntax de query (consulta, tipica Linq)
            /* Dentro da lambda Expression, podes acceder a variable que esta no scope (nesa localizacion).*/
            int puntoMedio = 5;
            List<int> listaInt = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var minhaQueryPorEnribaDoPuntoMedio = from i in listaInt
                                                  where i > puntoMedio
                                                  select i;
            Console.WriteLine("Os numeros por enriba do punto medio(5) son os seguintes:");
            foreach (int numero in minhaQueryPorEnribaDoPuntoMedio)
            {
                Console.WriteLine(numero);
            }
            #endregion

            #region Usando sintaxis de chamadaa a metodo
            // Forma alternativa (usando sintaxis de chamada a metodo)
            Console.WriteLine("Usando unha expresion lambda, os numeros por enriba de punto medio(5) son os seguintes:");
            IEnumerable<int> numerosEnribaPuntoMedio = listaInt.Where(x => x > puntoMedio);
            foreach (int numero in numerosEnribaPuntoMedio)
            {
                Console.WriteLine(numero);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
