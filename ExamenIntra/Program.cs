using System;
using System.Threading.Tasks;

namespace ExamenIntra
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Partie LINQ
            partieLinq.PartieLINQ.Start();
            Console.ReadKey();
                                       
            /// Partie concurrente
            partieConcurrente.PartieConcurrente.Start();

            /// Partie asynchrone
            partieAsynchrone.PartieAsynchrone.Start();
        }
    
    }
}
