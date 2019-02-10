using System;

namespace SomaDaSequencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();

            int soma = 0;
            for(int i = 0; i < Convert.ToInt32(n); i++){
                var x = Console.ReadLine();
                soma += Convert.ToInt32(x);
            }         
            Console.WriteLine(soma);
        }
    }
}
