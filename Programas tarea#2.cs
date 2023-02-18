//Programa 1
int edad;
int año;

Console.Write("\t\t PROGRAMA #1\n")
Console.WriteLine("\tDigite su edad");
edad = Convert.ToInt32(Console.ReadLine());

año = 2022 - edad;

Console.WriteLine("\tNo pareces tener " + edad + " años");

//programa 2

using System;
class Program
{
    static void Main(string[] args)
    {
        ushort num1, num2, resultado;
        Console.Write("\t\t PROGRAMA #2\n");
        Console.Write("\tIngrese el primer número de dos cifras: ");
        num1 = Convert.ToUInt16(Console.ReadLine());
        while (num1 >= 10)
        {
            Console.Write("\tIngrese el segundo número de dos cifras: ");
            num2 = Convert.ToUInt16(Console.ReadLine());
            while (num2 >= 10)
            {
                resultado = (ushort)(num1 * num2);

                Console.WriteLine("\tEl resultado de la multiplicación es: " + resultado);
                return;
            }
            Console.WriteLine("\tEl número ingresado no es de dos dígitos");
            Console.ReadKey();
        }
        Console.WriteLine("\tEl número ingresado no es de dos dígitos");
        Console.ReadKey();
    }
}


//Programa 3

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
