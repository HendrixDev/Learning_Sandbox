using Learning.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Sandbox.Tests.AlgorithmTests
{
    public class MedianOfTwoSortedArraysTests
    {
        private readonly MedianOfTwoSortedArrays _medianOfTwoSortedArrays = new();
        private int[] _array1 = new int[] { 5, 1, 3, 4, 2 };
        private int[] _array2 = new int[] { 9, 7, 8, 10, 6 };

        [Fact]
        public void MergeArray_ReturnsLength_10()
        {
            //arrange
            int[] firstArray = _array1;
            int[] secondArray = _array2;
            int[] mergedArray;
            int expectedLength = 10;

            //act
            mergedArray = _medianOfTwoSortedArrays.MergeArrays(firstArray, secondArray);

            //assert
            Assert.Equal(expectedLength, mergedArray.Length);
        }

        [Fact]
        public void MergeArray_ReturnsCorrectValues()
        {
            //arrange
            int[] firstArray = _array1;
            int[] secondArray = _array2;
            int[] mergedArray;
            int expectedValueAtIndexZero = 5;
            int expectedValueAtIndexThree = 4;
            int expectedValueAtIndexSix = 7;
            int expectedValueAtIndexNine = 6;

            //act
            mergedArray = _medianOfTwoSortedArrays.MergeArrays(firstArray, secondArray);

            //assert
            Assert.Equal(expectedValueAtIndexZero, mergedArray[0]);
            Assert.Equal(expectedValueAtIndexThree, mergedArray[3]);
            Assert.Equal(expectedValueAtIndexSix, mergedArray[6]);
            Assert.Equal(expectedValueAtIndexNine, mergedArray[9]);
        }

    }
}
