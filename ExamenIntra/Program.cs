using System;
using System.Threading.Tasks;

namespace ExamenIntra
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Partie LINQ
            PartieLINQ.Start();
            Console.ReadKey();
                                       
            /// Partie concurrente
            PartieConcurrente.Start();
            
            /// Partie asynchrone
            PartieAsynchrone.Start();
        }
    
    }
}
