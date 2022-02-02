using System;

public enum Mes
{
    January = 1,
    February = 2,
    March = 3,
    April = 4,
    May = 5,
    June = 6,
    July = 7,
    August = 8,
    September = 9,
    October = 10,
    November = 11,
    December = 12,

}

public class Problem
{
    public static void Main()
    {

        int valorMes = int.Parse(Console.ReadLine()!);
        
        if(valorMes >=1 && valorMes <=12){
            Console.Write($"{(Mes)valorMes}");
        }
    
        else{
            Console.WriteLine("Digite um número válido de 1 a 12");
        }
        Console.ReadLine();
    }
}