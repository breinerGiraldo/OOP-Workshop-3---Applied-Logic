using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de N: ");
        int N = int.Parse(Console.ReadLine());

        int[,] matriz = new int[N, N];
        int suma = 0;

        // Llenar la matriz
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = (i + 1) - j;
            }
        }

        // Inicializar mayor y menor
        int mayor = matriz[0, 0];
        int menor = matriz[0, 0];

        Console.WriteLine("\nMatriz generada:\n");

        // Mostrar matriz y calcular suma, mayor y menor
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t");

                suma += matriz[i, j];

                if (matriz[i, j] > mayor)
                    mayor = matriz[i, j];

                if (matriz[i, j] < menor)
                    menor = matriz[i, j];
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nSumatoria de los elementos: " + suma);
        Console.WriteLine("Mayor elemento: " + mayor);
        Console.WriteLine("Menor elemento: " + menor);
    }
}