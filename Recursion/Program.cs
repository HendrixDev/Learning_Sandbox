Console.WriteLine("Enter number to sum recursively: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(input));
Console.WriteLine();
Console.WriteLine("Enter number to countdown ");
int input2 = Convert.ToInt32(Console.ReadLine());
CountDownToZeroFromN(input2);

/*
 Recursive method to calculate sum of all numbers from 1 to N
 input: 5
 output: 15
 explanation: 1 + 2 + 3 + 4 + 5 = 15 
*/
static int Sum(int number)
{
    if (number == 0)
    {
        return number;
    }
    else
    {
        return number + Sum(number - 1);
    }
}

/*
 Recursive method to countdown to zero from N
 input: 5
 output: 0
 explanation: 5 - 4 - 3 - 2 - 1 = 0 
*/
static int CountDownToZeroFromN(int n)
{
    Console.WriteLine(n);
    if (n == 0)
    {
        return n;
    }
    else
    {
        return CountDownToZeroFromN(n - 1);
    }
}

