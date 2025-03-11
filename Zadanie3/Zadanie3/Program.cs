// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;


int[] arr = { 1, 2, 3, 4, 5 };

Console.WriteLine(arr.Length);
static double GetAverage(int[] numbers)
{
    double sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    } 
    return sum / numbers.Length;
}

Console.WriteLine(GetAverage(arr));