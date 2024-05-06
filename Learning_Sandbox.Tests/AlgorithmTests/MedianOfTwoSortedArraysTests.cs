using Learning.Algorithms;

namespace Learning_Sandbox.Tests.AlgorithmTests
{
    public class MedianOfTwoSortedArraysTests
    {
        private readonly MedianOfTwoSortedArrays _medianOfTwoSortedArrays = new();
        private int[] _array1 = new int[] { 5, 1, 3, 4, 2 };
        private int[] _array2 = new int[] { 9, 7, 8, 10, 6, 11 };

        [Fact]
        public void MergeArray_ReturnsLength_11()
        {
            //arrange
            int[] firstArray = _array1;
            int[] secondArray = _array2;
            int[] mergedArray;
            int expectedLength = 11;

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

        [Fact]
        public void SortArray_ActuallySorts()
        {
            //arrange
            int[] arrayToSort = _medianOfTwoSortedArrays.MergeArrays(_array1, _array2);

            //act
            _medianOfTwoSortedArrays.SortArray(arrayToSort);

            //assert
            Assert.Equal(1, arrayToSort[0]);
            Assert.Equal(3, arrayToSort[2]);
            Assert.Equal(5, arrayToSort[4]);
            Assert.Equal(7, arrayToSort[6]);
            Assert.Equal(9, arrayToSort[8]);
            Assert.Equal(11, arrayToSort[10]);
        }

        [Fact]
        public void CalculateMedian_OddNumberOfElements_Returns_3()
        {
            //arrange
            int[] array = _array1;
            double expectedResult = 3;
            _medianOfTwoSortedArrays.SortArray(array);

            //act
            double actualResult = _medianOfTwoSortedArrays.CalculateMedianOfSortedArray(array);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void CalculateMedian_EvenNumberOfElements_Returns_8_5()
        {
            //arrange
            int[] array = _array2;
            double expectedResult = 8.5;
            _medianOfTwoSortedArrays.SortArray(array);

            //act
            double actualResult = _medianOfTwoSortedArrays.CalculateMedianOfSortedArray(array);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
