using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento estac = new Estacionamiento();
            estac.lat = 1;
            estac.longitude = 1;
            estac.numeroEstacionamiento = 12;
            estac.status = "vacio";
            Persona pepe = new Persona();
            pepe.OcuparEstacionamiento(estac);


        }
    }
}
