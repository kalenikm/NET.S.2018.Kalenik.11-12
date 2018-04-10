using System;

namespace Logic
{
    public static class BinarySearcher
    {
        public static int Search<T>(this T[] array, T item)
        {
            if (!(item is IComparable))
                throw new InvalidCastException("Type of array elements is not comparable.");

            return Search(array, item, 0, array.Length - 1);
        }

        private static int Search<T>(T[] array, T item, int first, int last)
        {
            if (last < first)
                return -1;

            int average = (last + first) / 2;

            if (array[average].Equals(item))
                return average;
            else if (((IComparable<T>)item).CompareTo(array[average]) < 0)
                return Search(array, item, first, average - 1);
            else
                return Search(array, item, average + 1, last);
        }
    }
}