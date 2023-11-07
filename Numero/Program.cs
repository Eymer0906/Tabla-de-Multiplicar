using System;
//ingrese un numero y muestre la tabla de multiplicar
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un Numero");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("la tabla de multiplicar es:" + numero+"correcto");
        for (int i = 1; i <= 10; i++)
            
        {
            int resul = i * numero;
            Console.WriteLine("el resultado es:" + resul);
        }






    }









}


