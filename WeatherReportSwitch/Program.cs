using System;

namespace WeatherReportSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mitu kraadi õues on;
            //kui õues on rohkem kui 35 kraadi, programm kuvab "boiling hot"
            //kui õues on 30 kuni 35 kraadi, programm kuvab "hot"
            //kui õues on 20 kuni 30 kraadi, programm kuvab "Nice"
            //kui õues on 10 kuni 20 kraadi, programm kuvab "chilly"
            //kui õues on 0 kuni 10 kraadi, programm kkuvab "cold"

            Console.WriteLine("Mitu kraadi õues on?");
            int temp = Convert.ToInt32(Console.ReadLine());
            switch(temp)
            {
                case var _ when temp < 0:
                    Console.WriteLine("Freezing");
                    break;
                case var _ when temp >= 0 && temp < 10:
                    Console.WriteLine("Cold.");
                    break;
                case var _ when temp >= 10 && temp < 20:
                    Console.WriteLine("Chilly.");
                    break;
                case var _ when temp >= 20 && temp < 30:
                    Console.WriteLine("Nice.");
                    break;
                case var _ when temp >= 30 && temp < 35:
                    Console.WriteLine("Hot.");
                    break;
                default:
                    Console.WriteLine($"Boiling hot");
                    break;


            }
        }
    }
}
