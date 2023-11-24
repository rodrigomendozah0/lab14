using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.PantallaPrincipal();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.VacunacionCovid();
                        break;
                    case 2:
                        opcion = Pantallas.DatosEncuestaCovid();
                        break;
                    case 3:
                        opcion = Pantallas.Resultados();
                        break;
                    case 4:
                        opcion = Pantallas.Buscador();
                        break;
                    case 0:
                    default:
                        opcion = Pantallas.PantallaPrincipal();
                        break;
                }
            }while (opcion != 5);
            Console.ReadLine();
        }
    }
}
