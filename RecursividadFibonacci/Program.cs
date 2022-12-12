using System.Diagnostics;
namespace Recursividad;
class Program
{
    static void Main(string[] args)
    {
        Stopwatch tiempoFibonacciRecursivo = new Stopwatch();
        Stopwatch tiempoFibonacciIterativo = new Stopwatch();

        int n, i;
        do
        {
            Console.WriteLine("Introduzca el numero de terminos: ");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n <= 1);

        Console.WriteLine("\tSerie de numeros de fibonacci recursivo: ");

        tiempoFibonacciRecursivo.Start();
        for (i = 0; i < n; i++)
        {
            Console.Write(FibonacciRecursivo(i) + " ");
        }
        tiempoFibonacciRecursivo.Stop();

        Console.WriteLine("\n\tTiempo de ejecucion: " + tiempoFibonacciRecursivo.Elapsed.ToString());

        Console.WriteLine("\n\tSerie de numeros de fibonacci iterativo: ");
        tiempoFibonacciIterativo.Start();
        FibonacciIterativo(n);
        tiempoFibonacciIterativo.Stop();

        Console.WriteLine("\n\tTiempo de ejecucion: " + tiempoFibonacciIterativo.Elapsed.ToString());
    }

    static long FibonacciRecursivo(int n)
    {
        if (n < 2)
        {
            return n;
        }
        else
        {
            return FibonacciRecursivo(n - 2) + FibonacciRecursivo(n - 1);
        }
    }

    static void FibonacciIterativo(int n)
    {
        int i;
        long ant1, ant2;
        ant1 = 0;
        ant2 = 1;
        Console.Write("0 ");
        for (i = 1; i < n; i++)
        {
            int actual = Convert.ToInt32(ant1 + ant2);
            ant2 = ant1;
            ant1 = actual;
            Console.Write(actual + " ");
        }
    }
}