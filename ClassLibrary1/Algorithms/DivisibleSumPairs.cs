namespace Learning.Algorithms
{
    public class DivisibleSumPairs
    {
        //Given a list of integers and a positive integer (divisor), determine the number of (i,j) pairs where i < j and ar[i] + ar[j] is divisible by the divisor. 
        public int GetTotalDivisableSumPairs(int divisor, List<int> ar)
        { 
            int totalDivisable = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = 0; j < ar.Count; j++)
                {
                    if (i < j && (ar[i] + ar[j]) % divisor == 0)
                    {
                        totalDivisable++;
                    }
                }
            }

            return totalDivisable;
        }
    }
}
