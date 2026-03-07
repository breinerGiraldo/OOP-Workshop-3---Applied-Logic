using Shared;
using System;
var answer = string.Empty;
var options = new List<string> { "s", "n" };

do { 
var n = ConsoleExtension.GetInt("Ingrese el valor de N: ");

//definition of the matrix
int[,] matriz = ConsoleExtension.FillMatrix(n);
Console.WriteLine("\nMatriz generada:\n");
ConsoleExtension.View(matriz);

int sum = ConsoleExtension.Sum(matriz);
int elderly = ConsoleExtension.Greatestnumber(matriz);
int minor = ConsoleExtension.Smallestnumber(matriz);

    Console.WriteLine("\nSumatoria de los elementos: " + sum);
Console.WriteLine("Mayor elemento: " + elderly);
    Console.WriteLine("Menor elemento: " + minor);

do
{
    answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;
Console.WriteLine("F mi loco ");
