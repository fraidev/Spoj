using System;

namespace LifeTheUniverseAndEverything
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            while(true){
                number = Convert.ToInt32(Console.ReadLine());
                if(number == 42){
                    break;
                }
                Console.WriteLine(number);
            }
        }
    }
}
