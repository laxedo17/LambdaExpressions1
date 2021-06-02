using System;

namespace LambdaExpressions7_UsandoEvents
{
    class Emisor
    {
        private int meuInt;
        public int MeuInt
        {
            get
            {
                return meuInt;
            }
            set
            {
                meuInt = value;
                //Cada vez que establecemos un novo valor, salta o evento
                OnMeuIntCambiado();
            }
        }

        // EventHandler e un delegate predefinido que se usa para manexar
        //eventos simples.
        // Ten a seguinte firma:         
        //delegate void System.EventHandler(object sender,System.EventArgs e)         
        //onde o emisor indica quen esta enviando o event e        
        //EventArgs usase para gardar a informacion sobre o evento.

        public event EventHandler MeuIntCambiado;
        public void OnMeuIntCambiado()
        {
            if (MeuIntCambiado != null)
            {
                MeuIntCambiado(this, EventArgs.Empty);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Demostracion-.Explorando events con lambda expression.***");
            Emisor emisor = new Emisor();
            //Usando lambda expression en un event handler             
            //Malas practicas             
            //emisor.MeuIntCambiado += (Object sender, System.EventArgs e) =>
            // Console.WriteLine("Usando lambda expression, dentro de Main method, recibiu unha notificacion: Emisor cambiou valor meuInt recentemente . ");
            //Boas practicas
            EventHandler meuEvent = (object sender, EventArgs e) => Console.WriteLine("Usando lambda expression, dentro de Main method, recibiu unha notificacion: Emisor cambiou valor meuInt recentemente");
            emisor.MeuIntCambiado += meuEvent;

            emisor.MeuInt = 1;
            emisor.MeuInt = 2;
            //Des-suscribindose agora
            //emisor.MeuIntCambiado-=receptor.GetNotificacionDoEmisor
            //Agora non fai falta enviar notificacion ao receptor
            //pero non hai garantias se usas malas practicas
            //emisor.MeuIntCambiado -= (Object sender, System.EventArgs e) =>  
            // Console.WriteLine("Notificacion de evento non rexistrada.");

            //Pero agora podes borrar o evento de maneira apropiada
            emisor.MeuIntCambiado -= meuEvent;
            emisor.MeuInt = 3;
            Console.ReadKey();
        }
    }
}