using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsibkasutajal PIN koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //Kui sisestad PIN-kood on 1234
            //programm kuvab konsoolis "Tere tulemast"
            //kui sisestatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti."

            Console.WriteLine("Sisesta oma PIN:");
            int PIN = Convert.ToInt32(Console.ReadLine());
            
            /*if (PIN == 1234)
            {
                Console.WriteLine("Tere tulemast");
            }
            else 
            {
                Console.WriteLine("Proovi uuesti.");
            }*/

            if(PIN != 1234)
            {
                Console.WriteLine("Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast");
            }
        }
    }
}
