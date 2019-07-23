using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Palabra
    {
        public string cadena;
        public StringBuilder guiones;

        public void PasarGuiones(string cadena)
        {
            guiones = new StringBuilder(cadena);
            for (int i = 0; i < cadena.Length;i++)
            {
                guiones[i] = '-';
            }
            

        }

        public Palabra(string palabra)
        {
            palabra.ToUpper();
            cadena = palabra;
        }  
    }


    
}

