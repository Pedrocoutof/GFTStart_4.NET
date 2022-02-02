using System;

namespace DIO
{

    class Program
    {
        public static void Main()
        {
            int valorFinal;
            int x = int.Parse(Console.ReadLine());
            int contador = 0;

            

            while (x != 0)
            {
                valorFinal = 0;
                contador = 0;

                for (int i = 0; contador < 5; i++)
                {
                    if (((x + i) % 2) == 0)
                    {
                        contador++;
                        valorFinal += x+i;
                    }
                }

                Console.WriteLine($"{valorFinal}");
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
