using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks;
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab, kas kasutaja
            //saab arstiks õppida

            Console.WriteLine("Sisesta oma matemaatika eksami punktid:");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma keemia eksami punktid:");
            int chemestry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma bioloogia punktid:");
            int biology = Convert.ToInt32(Console.ReadLine());
            
            if(math >= 85 && chemestry >= 90 && biology>= 95)
            {
                Console.WriteLine("Tubli:");
            }
            else
            {
                Console.WriteLine("Ei ole piisavalt palju punkte:");
            } 
        }
    }
}
