using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeOperations
{
    public class Persona
    {
        string nombre;
        string apellido;

        public void OcuparEstacionamiento(Estacionamiento e)
        {
            e.status = "ocupado";
        }

        /*
        public Persona(string nombreAAsignar,string apellidoAasignar)
        {
            nombre = nombreAAsignar;
            apellido = apellidoAasignar;
        }
        */
    }
}
