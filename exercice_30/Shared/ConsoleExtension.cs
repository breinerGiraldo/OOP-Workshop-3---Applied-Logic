using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Shared;

    public class ConsoleExtension
{
    public static int GetInt(string message)
    {
        Console.Write(message);
        var numberString = Console.ReadLine();
        if (int.TryParse(numberString, out int numberInt))
        {
            return numberInt;
        }
        return 0;
    }

    public static string? GetValidOptions(string message, List<string> options)
    {
        Console.Write(message);
        var answer = Console.ReadLine();
        if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
        {
            return answer;

        }

        return null;

    }
  

    public static int[,] FillMatrix(int N)
    {
        int[,] matriz = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = (i + 1) - j;
            }
        }

        return matriz;
    }

    public static int Sum(int[,] matriz)
    {
        int suma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                suma += matriz[i, j];
            }
        }

        return suma;
    }

    public static int Greatestnumber(int[,] matriz)
    {
        int mayor = matriz[0, 0];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > mayor)
                    mayor = matriz[i, j];
            }
        }

        return mayor;
    }

    public static int Smallestnumber(int[,] matriz)
    {
        int menor = matriz[0, 0];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] < menor)
                    menor = matriz[i, j];
            }
        }

        return menor;
    }

    public static void View(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }




}
