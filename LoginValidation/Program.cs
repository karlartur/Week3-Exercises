using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja parool
            //programm kontrollib sisestatud andmed
            //kui sisestatud kasutajatunnus on "admin" ja
            //sisestatud parool on "admin1234"
            //siis programm kuvab "Tere tulemast"
            //muul juhul programm kuvab "Vale kasutaja tunnus või parool. Proovi uuesti."
            //option1
            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta parool:");
            string password = Console.ReadLine();
            /* if (userName == "admin" && password == "admin1234")
             {
                 Console.WriteLine("Tere tulemast!");
             }
             else
             {
                 Console.WriteLine("Vale kasutaja tunnus või parool. Proovi uuesti.");
             }*/
            if (userName != "admin" || password != "admin1234")
            {
                Console.WriteLine("Vale kasutaja tunnus või parool. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
            


        }
    }
}
