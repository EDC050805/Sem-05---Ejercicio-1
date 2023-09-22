// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("\tPrograma para multiplicar dos números enteros sin '*'");
Console.WriteLine("\t*****************************************************\n");
Console.Write("Ingrese el número 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el número 2: ");
int num2 = int.Parse(Console.ReadLine());
int suma = 0;

for (int i = 1; i <= num2; i++)
{
    suma += num1; 
}
Console.WriteLine("El producto es: {0}", suma);
Console.ReadKey();


