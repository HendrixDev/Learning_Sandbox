namespace Learning.Algorithms;

public class MedianOfTwoSortedArrays
{
    //Explanation: https://leetcode.com/problems/median-of-two-sorted-arrays/description/
    public int[] MergeArrays(int[] array1, int[] array2)
    {
        int array1Length = array1.Length;
        int array2Length = array2.Length;
        int bothArrayLengths = array1Length + array2Length;

        int[] arrayToReturn = new int[bothArrayLengths];

        for (int i = 0; i < array1Length; i++)
        {
            arrayToReturn[i] = array1[i];
        }

        for (int i = 0; i < array2.Length; i++)
        {
            arrayToReturn[array1Length + i] = array2[i];
        }

        return arrayToReturn;
    }

    public void SortArray(int[] arrayToSort)
    {
        int totalLength = arrayToSort.Length;

        for (int i = 0; i <= totalLength - 2; i++)
        {
            for (int j = 0; j <= totalLength - 2; j++)
            {
                if (arrayToSort[j] > arrayToSort[j + 1])
                {
                    //Current was greater than next, swap them using tuple
                    (arrayToSort[j], arrayToSort[j + 1]) = (arrayToSort[j + 1], arrayToSort[j]);
                }
            }
        }
    }

    public double CalculateMedianOfSortedArray(int[] sortedArray)
    {
        double median;
        int sortedArrayLength = sortedArray.Length;
        int halvedArrayIndex = sortedArrayLength / 2;

        if (sortedArrayLength % 2 == 0)
        {
            //length was even, divide by 2 and grab element at that index.
            int firstNum = sortedArray[halvedArrayIndex - 1];
            int secondNum = sortedArray[halvedArrayIndex];
            median = (double)(firstNum + secondNum) / 2;
        }

        else
        {
            //length was odd, grab the middle number 
            median = sortedArray[(int)Math.Floor((decimal)halvedArrayIndex)];
        }

        return median;
    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] mergedArray = MergeArrays(nums1, nums2);

        SortArray(mergedArray);

        return CalculateMedianOfSortedArray(mergedArray);
    }
}
