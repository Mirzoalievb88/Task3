// task1 

// void PrintNumbers(int n)
// {
//     if (n > 0)
//     {
//         PrintNumbers(n - 1);
//         Console.Write(n + " ");
//     }
// }

// int n = 10;
// PrintNumbers(n);

//task2

// void Print(int n)
// {
//     if (n > 0)
//     {
//         Console.Write(n + " ");
//         Print(n - 1);
//     }
// }

// int n = 10;
// Print(n);

//task3

// void PrintDigits(int number)
// {
//     if (number > 0)
//     {
//         PrintDigits(number / 10);
//         Console.Write(number % 10 + " ");
//     }
// }


// int number = 1234;
// PrintDigits(number);

//task4

// int SumOfNumbers(int n)
// {
//     if (n == 1)
//         return 1;
//     else
//         return n + SumOfNumbers(n - 1);
// }

// int n = 10;
// int result = SumOfNumbers(n);
// Console.WriteLine(result);

//task5

// int CountDigits(int number)
// {
//     if (number == 0)
//         return 0;
//     else
//         return 1 + CountDigits(number / 10);
// }

// int number = 1234;
// int result = CountDigits(number);
// Console.WriteLine(result);

//task6

void PrintEvenNumbers(int start, int end)
{
    if (start > end)
        return;

    if (start % 2 == 0)
    {
        Console.Write(start + " ");
    }
    PrintEvenNumbers(start + 1, end);
}


int start = 1, end = 20;
Console.WriteLine("All even numbers from " + start + " to " + end + " are: ");
PrintEvenNumbers(start, end);
System.Console.WriteLine(" ");

void Numbers(int sta, int e)
{
    if (sta > e)
        return;

    if (sta % 2 != 0)
    {
        Console.Write(sta + " ");
    }
    Numbers(sta + 1, e);
}


int sta = 1, e = 20;
Console.WriteLine("All odd numbers from " + sta + " to " + e + " are: ");
Numbers(start, end);
