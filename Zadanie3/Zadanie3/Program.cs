// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

int[] arr = { 1, 2, 3, 4, 5 };

static double GetAverageNewZadanie5(int[] numbers)
{
    double sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    } 
    return sum / numbers.Length;
}



Console.WriteLine("srednia liczb z listy: " + GetAverageNewZadanie5(arr));