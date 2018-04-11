using System;

namespace Logic
{
    public static class BinarySearcher
    {
        /// <summary>
        /// Returns index of <paramref name="item"/> in <paramref name="array"/> or -1 if <paramref name="item"/> is not exist.
        /// </summary>
        /// <typeparam name="T">Should implement IComparable.</typeparam>
        /// <param name="array">Sorted array to find <paramref name="item"/> in.</param>
        /// <param name="item">Item to find.</param>
        /// <returns>Index of <paramref name="item"/> in <paramref name="array"/></returns>
        public static int Search<T>(this T[] array, T item)
        {
            if(ReferenceEquals(null, array))
                throw new ArgumentNullException($"{nameof(array)} is null.");

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