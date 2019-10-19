using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForms
{
    class PalabrasPredefinidas
    {
        private static string[] palabras = {
            "Arlequin",
            "Procer",
            "Espectro",
            "Plankton",
            "Falacia",
            "Zangano",
            "Jazz",
            "Conyuge",
            "Estrafalario",
            "Estupefacientes",
            "Onomatopeya",
            "Coagulacion",
            "Linyera",
            "Incredulo",
            "Alquitran",
            "Axon",
            "Indole",
            "Funicular",
            "Estrambotico",
            "Pauperrimo" };

        private static string[] pistas = {
            "Personaje teatral del medioevo",
            "Persona recordada por sus logros sirviendo a un país",
            "Fantasma",
            "Villano en Bob Esponja",
            "Mentira",
            "Abeja macho, insulto",
            "Louis Armstrong",
            "Pareja",
            "Extravagante",
            "Los derivados del opio son: ",
            "''BANG'', ''BOOM'' ''CRACK''",
            "Solidificación de cierto tipo de sustancias",
            "Vagabundo",
            "Desconfiado",
            "Sustancia viscoza usada para la pavimentación",
            "Prolongación de la neurona",
            "Sinónimo de característica",
            "Tipo especial de ferrocarril",
            "Extraño y poco común",
            "Superlativo de pobre" };

        public static string PedirPalabra(int i)
        {
            string palabra = palabras[i];
            return palabra;
        }
        public static string PedirPista(int i)
        {
            string pista = pistas[i];
            return pista;
        }
    }
}
