using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;
            
            if(n > 1 && n < 1000){
            
              for (int i = 1; i <= n; i++)
              {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
              }
              
            }
        }
    }
}