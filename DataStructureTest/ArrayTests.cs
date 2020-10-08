using System;
using DataStructure.Array;
using NUnit.Framework;

namespace DataStructureTest
{
    public class ArrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Rotate_Array_With_Two_Steps()
        {
            int[] items = {1, 2, 3, 4, 5, 6, 7};
            int steps = 2;
            int[] Expected = {3, 4, 5, 6, 7, 1, 2};
            var returndata = ArrayRotation.RotateArray(steps, items);
            Assert.AreEqual(Expected, returndata);

        }

        [Test]
        public void Rotate_Array_With_Five_Steps()
        {
            int[] items = { 1, 2, 3, 4, 5, 6, 7 };
            int steps = 5;
            int[] Expected = {6, 7, 1, 2, 3, 4, 5};
            var returndata = ArrayRotation.RotateArray(steps, items);
            Assert.AreEqual(Expected, returndata);

        }

        [Test]
        public void Cycle_Rotate_Array_With_One_Steps()
        {
            int[] items = { 1, 2, 3, 4, 5 };
            int steps = 1;
            int[] Expected = { 5, 1, 2, 3, 4 };
            var returndata = CycleRotate.RotateArray(steps, items);
            Assert.AreEqual(Expected, returndata);

        }

        [Test]
        public void Cycle_Rotate_Array_With_Three_Steps()
        {
            int[] items = { 1, 2, 3, 4, 5 };
            int steps = 3;
            int[] Expected = {3, 4, 5, 1, 2};
            var returndata = CycleRotate.RotateArray(steps, items);
            Assert.AreEqual(Expected, returndata);

        }

        [Test]
        public void Search_In_Sorted_AndRotated_Array()
        {
            int[] Items = {3, 4, 5, 1, 2};
            int search = 5;
            int foundAt = SearchInSortedAndRotated.SearchElement(search, Items);
            Assert.AreEqual(2, foundAt);
        }

        [Test]
        public void Search_In_Sorted_AndRotated_Array_WithOptimized_Test1()
        {
            int[] Items = { 3, 4, 5, 1, 2 };
            int search = 5;
            int foundAt = SearchInSortedAndRotated.SearchElementOptimize(search, Items);
            Assert.AreEqual(2, foundAt);
        }

        [Test]
        public void Search_In_Sorted_AndRotated_Array_WithOptimized_Test2()
        {
            int[] Items = { 3, 4, 5, 1, 2 };
            int search = 1;
            int foundAt = SearchInSortedAndRotated.SearchElementOptimize(search, Items);
            Assert.AreEqual(3, foundAt);
        }

        [Test]
        public void GetPairOfGivenSum_withGivenItems_Test1()
        {
            int[] Items = { 3, 4, 5, 1, 2 };
            int search = 9;
            dynamic foundAt = GetPairOfGivenSum.GetPair(search, Items);
            int firstValue = foundAt.Item1;
            int secondValue = foundAt.Item2;
            Assert.AreEqual(1, firstValue);
            Assert.AreEqual(2, secondValue);

        }

        [Test]
        public void GetPairOfGivenSum_withGivenItems_Test2()
        {
            int[] Items = { 3, 4, 5, 1, 2 };
            int search = 3;
            dynamic foundAt = GetPairOfGivenSum.GetPair(search, Items);
            int firstValue = foundAt.Item1;
            int secondValue = foundAt.Item2;
            Assert.AreEqual(0, firstValue);
            Assert.AreEqual(-1, secondValue);

        }

        [Test]
        public void GetPairOfGivenSum_withGivenItems_Test3()
        {
            int[] Items = { 3, 4, 5, 1, 11 };
            int search = 16;
            dynamic foundAt = GetPairOfGivenSum.GetPair(search, Items);
            int firstValue = foundAt.Item1;
            int secondValue = foundAt.Item2;
            Assert.AreEqual(2, firstValue);
            Assert.AreEqual(4, secondValue);

        }

        [Test]
        public void GetPairOfSumInSortedArray_withGivenItems_Test1()
        {
            int[] Items = { 3, 4, 5, 7, 11 };
            int search = 12;
            dynamic foundAt = GetPairOfSumInSortedArray.GetPair(search, Items);
            int firstValue = foundAt.Item1;
            int secondValue = foundAt.Item2;
            Assert.AreEqual(2, firstValue);
            Assert.AreEqual(3, secondValue);

        }
    }
}