using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoCS
{
    class Program
    {
        static void Main(string[] args)
        {


            String[]personas = new string[4];
            personas[0] = "A";
            personas[1] = "B";
            personas[2] = "C";
            personas[3] = "D";

            string[] pers = {"A", "B", "C", "D"};

            for (int i = 0; i < personas.Length; i++)
            {
                    Console.WriteLine(personas[i]);
            }
            foreach (var per in pers)
            {
                
            }


            Console.Write("Nombre");
            String nombre = Console.ReadLine();
            Console.Write("Edad:");
            var edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hola {0} tienes {1} años",
            nombre,edad);

            Console.ReadLine();

        }
    }
}
