namespace ClassLibrary1.Recursion
{
    public static class Recursion
    {
        /*
        Recursive method to calculate sum of all numbers from 1 to N
        input: 5
        output: 15
        explanation: 1 + 2 + 3 + 4 + 5 = 15 
        */
        public static int Sum(int number)
        {
            if (number == 0)
                return number;

            return number + Sum(number - 1);
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
                return n;

            return CountDownToZeroFromN(n - 1);
        }
    }
}
