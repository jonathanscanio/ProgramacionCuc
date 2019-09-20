using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AhorcadoWindowsForms.src.Modelo;

namespace AhorcadoWindowsForms.src.Controlador
{
    class Niveles_Controlador
    {
        public ParametrosPartida ObtenerParametrosPartida(int nivel)
        {
            ParametrosPartida parametrosPartida = new ParametrosPartida();

            parametrosPartida.Palabra = PalabrasPredefinidas.PedirPalabra(nivel - 1); //-1 porque ese numero se toma como indice de un arreglo
            parametrosPartida.Pista = PalabrasPredefinidas.PedirPista(nivel - 1); 
            parametrosPartida.Vidas = 6;
            parametrosPartida.MostrarIntentos = true;
            parametrosPartida.MostrarPrimerLetra = false;

            return parametrosPartida;
        }
    }
}
