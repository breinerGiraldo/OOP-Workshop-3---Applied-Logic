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
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));// validamos que la respuesta del usuario sea igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula 

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;
Console.WriteLine("F mi loco");
