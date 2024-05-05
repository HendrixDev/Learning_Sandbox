namespace Learning.Algorithms
{
    public class BuyTwoChocolates
    {
        //Explanation: https://leetcode.com/problems/buy-two-chocolates/
        public int BuyChoco(int[] prices, int money)
        {
            int numberOfChocolates = 0;
            int moneyTemp = money;

            Array.Sort(prices);

            for (int i = 0; i < prices.Length; i++)
            {
                if (moneyTemp > 0 && moneyTemp >= prices[i])
                {
                    moneyTemp -= prices[i];
                    numberOfChocolates++;
                }

                if (numberOfChocolates >= 2)
                {
                    return moneyTemp;
                }
            }

            return money;
        }
    }
}
