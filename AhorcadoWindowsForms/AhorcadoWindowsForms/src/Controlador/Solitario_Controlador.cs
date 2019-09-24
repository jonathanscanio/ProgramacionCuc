using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AhorcadoWindowsForms.src.Modelo;

namespace AhorcadoWindowsForms.src.Controlador
{
    class Solitario_Controlador
    {
        public ParametrosPartida ObtenerParametrosPartidaRandom()
        {
            ParametrosPartida parametrosPartida = new ParametrosPartida();

            Random rnd = new Random();
            int numeroRandom = rnd.Next(20); //20 = cantidad de palabras predefinidas

            parametrosPartida.Palabra = PalabrasPredefinidas.PedirPalabra(numeroRandom);
            parametrosPartida.Pista = PalabrasPredefinidas.PedirPista(numeroRandom);
            parametrosPartida.Vidas = 6;
            parametrosPartida.MostrarIntentos = true;
            parametrosPartida.MostrarPrimerLetra = false;

            return parametrosPartida;
        }
    }
}
