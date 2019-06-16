using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeOperations
{
    public class Estacionamiento
    {
        public int numeroEstacionamiento;
        public int lat;
        public int longitude;
        public string status;

        public void Ocupar()
        {
            status = "ocupado";
        }
    }

}
