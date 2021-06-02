using System;

namespace LambdaExpressions4
{
    class Empregado
    {
        private int empId;
        private string companhia = "XyZ Ltd.";
        private string nome = String.Empty;

        //Implementacion tipica dun constructor
        //public Empregado(int id)
        // {
        //     empId = id;
        // }

        // A seguinte linha mostra un expression-bodied constructor
        public Empregado(int id) => empId = id;

        //Implementacion tipica dunha propiedade read-only
        // public string Companhia
        // {
        //     get
        //     {
        //         return companhia;
        //     }
        // }

        //Propiedade read-only. C#6 en adiante
        public string Companhia => companhia;

        //Implementacion tipica dunha propiedade con get e set
        // public string Nome{
        //     get 
        //     {
        //          return nome
        //          };
        //     set{
        //         nome = value;
        //     }
        // }

        //De C#7 en adiante, podes usar expression-body definitions 
        //para os accessors get e set
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Experimentando lambda expressions con propiedades expression-bodied.***");
            Empregado empOb = new Empregado(1);
            //Error. Companhia e read-only
            //empOb.Companhia = "ABC Co.";
            empOb.Nome = "Rohan Mordor";//ok
            Console.WriteLine("{0} traballa en {1}", empOb.Nome, empOb.Companhia);
            Console.ReadKey();
        }
    }
}
