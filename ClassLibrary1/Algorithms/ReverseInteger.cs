namespace Learning.Algorithms
{
    public class ReverseInteger
    {
        //Explanation: https://leetcode.com/problems/reverse-integer/
        public int Reverse(int x)
        {
            return int.TryParse(ReverseString(x.ToString()), out int reversed) ? reversed : 0;
        }

        string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);

            if (charArray.Contains('-'))
            {
                List<char> list = charArray.ToList();
                list.Remove('-');
                list.Insert(0, '-');
                return new string(list.ToArray());
            }

            return new string(charArray);
        }
    }
}
