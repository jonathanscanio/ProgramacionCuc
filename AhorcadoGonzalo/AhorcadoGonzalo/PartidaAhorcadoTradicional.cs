using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoGonzalo
{
    class PartidaAhorcadoTradicional : PartidaAhorcado
    {
        private int vidas;
        private void PedirVidas()
        {
            bool isInt;
            do
            {
                Console.Write("Cuántas vidas habrá: ");
                isInt = int.TryParse(Console.ReadLine(), out vidas);
                if (!isInt)
                {
                    Console.WriteLine("Las cantidad de vidas tiene que ser un número entero.");
                }
                else if (vidas <= 0)
                {
                    Console.WriteLine("La cantidad de vidas no es válida.");
                    isInt = false;
                }
            }
            while (!isInt);
            Console.Clear();
        }
        private void ImprimirGuiones()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n");
            Console.Write("            ");
            for (int i = 0; i < palabraElegida.Length; i++)
            {
                Console.Write(" " + sbGuiones[i].ToString());
            }
            Console.WriteLine("   Vidas restantes: " + vidas + "\n");
        }
        public static void Ejecutar()
        {
            // Iniciar partida
            PartidaAhorcadoTradicional partida = new PartidaAhorcadoTradicional();

            //Pedir datos
            partida.PedirPalabraElegida();
            partida.IniciarGuiones();
            partida.PedirVidas();

            //Logica
            bool reemplazo;
            partida.ImprimirGuiones();
            do
            {
                reemplazo = partida.LogicaReemplazar(partida.PedirIntento());
                if (!reemplazo) partida.vidas--;
                partida.ImprimirGuiones();
            } while (!partida.ganar && partida.vidas != 0);

            //Mostrar Resultado
            if (partida.ganar) Console.WriteLine("\nFelicidades, ganaste!!!");
            else Console.WriteLine("\nHas perdido, suerte la próxima.");
        }
    }
}
