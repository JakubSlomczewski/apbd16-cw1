// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

int[] arr = { 1, 2, 3, 4, 5 };

<<<<<<< HEAD
static double GetAverageNewMainB(int[] numbers)
=======
static double GetAverageNewZadanie5(int[] numbers)
>>>>>>> feature-new
{
    double sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    } 
    return sum / numbers.Length;
}



<<<<<<< HEAD
Console.WriteLine("srednia liczb z listy: " + GetAverageNewMainB(arr));
=======
Console.WriteLine("srednia liczb z listy: " + GetAverageNewZadanie5(arr));
>>>>>>> feature-new
