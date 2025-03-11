// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr = { 5, 1, 2, 10, 1, 2 };


static int MaxValue(int[] numbers)
{
    int MaxNumber = numbers[0];
    foreach(int number in numbers)
        {
            if( number > MaxNumber)
             {
                MaxNumber = number;
             }
        }
    
    return MaxNumber;
}

Console.WriteLine(MaxValue(arr));