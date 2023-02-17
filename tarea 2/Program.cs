using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\t\t PROGRAMA #3\n ");
        Console.Write("\tIntroduce el primer número: ");
        long num1 = long.Parse(Console.ReadLine());

        Console.Write("\tIntroduce el segundo número: ");
        long num2 = long.Parse(Console.ReadLine());

        long suma = num1 + num2;
        long resta = num1 - num2;
        long producto = num1 * num2;

        Console.WriteLine("\tLa suma de los números es: " + suma);
        Console.WriteLine("\tLa resta de los números es: " + resta);
        Console.WriteLine("\tEl producto de los números es: " + producto);

        Console.ReadLine();
    }
}
