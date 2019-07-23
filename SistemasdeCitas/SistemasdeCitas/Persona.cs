using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasdeCitas
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public int edad;
        public int maxEdad;
        public int minEdad;
        public string prefSexo;
        public string sexo;

        public bool Preferencia(Persona candidato)
        {
            bool preferencia;

            if (prefSexo == candidato.sexo && minEdad <= candidato.edad && maxEdad >= candidato.edad && candidato.prefSexo == sexo && candidato.minEdad <= edad && candidato.maxEdad >= edad)
            {
                preferencia = true;
            }
            else preferencia = false;


            return preferencia;
        }
        public Persona(string name, string lastname, int age, string sex, int minage, int maxage, string prefsex)
        {
            nombre = name;
            apellido = lastname;
            edad = age;
            sexo = sex;
            minEdad = minage;
            maxEdad = maxage;
            prefSexo = prefsex;
        }
        public override string ToString()
        {
            string mensaje = "";
            mensaje += "Nombre: " + nombre + "\nApellido: " + apellido + "\nEdad: " + edad + "\nSexo: " + sexo + "\nMax Edad:" + maxEdad + "\nMin Edad:" + minEdad + "\nPreferencia de Sexo: " + prefSexo;

            return mensaje;
        }
    }

}
