using Continental_App.Continent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continental_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contienent[] contienents = new Contienent[2];

            contienents[0] = new Africa();
            contienents[1] = new Asia();

            foreach (Contienent contienent in contienents)
            {
                Console.WriteLine(contienent.GetType().Name + ":");
                foreach (Animal animal in contienent.Animals) 
                { 
                    Console.WriteLine(" " + animal.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
