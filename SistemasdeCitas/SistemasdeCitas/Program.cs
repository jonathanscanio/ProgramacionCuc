using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasdeCitas
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Juan = new Persona("Juan","Perez",20,"M",19,29,"F");
            Persona candidata1 = new Persona("Mariana","Potichkin",21,"F",30,35,"M");
            Persona candidata2 = new Persona("Valentina","Gomez",23,"F",19,23,"M");
            Persona candidata3 = new Persona("Julieta", "Flores", 20,"F", 20, 21, "M");

            Console.WriteLine(Juan.ToString()+"\n");
            if (Juan.Preferencia(candidata1))
            {
                Console.WriteLine(candidata1.ToString()+ "\n");
            }
            if (Juan.Preferencia(candidata2))
            {
                Console.WriteLine(candidata2.ToString() + "\n");
            }
            if (Juan.Preferencia(candidata3))
            {
                Console.WriteLine(candidata3.ToString() + "\n");
            }
        }
    }
}
