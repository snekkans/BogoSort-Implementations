using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BogoSort___Windows_Forms;

namespace BogoSort___Windows_Forms
{
    /*
     This magical piece of code has been sourced from rosettacode.org
         */

    public static class BogoSorter
    {
        public static int Sort<T>(List<T> list) where T : IComparable
        {
            int numShuffles = 0;
            while (!list.isSorted())
            {
                numShuffles += 1;
                list.Shuffle();
                Console.WriteLine(numShuffles);
            }
            return numShuffles;
        }

        private static bool isSorted<T>(this IList<T> list) where T : IComparable
        {
            string arrayString = "[";
            if (list.Count <= 1) {
                return true;
            }
            for (int i = 1; i < list.Count; i++)
                if (list[i].CompareTo(list[i - 1]) < 0) return false;
            //TODO: Send the array back to form1.cs
            
            for (int i = 0; i < list.Count; i++)
            {
                arrayString += list[i].ToString();
                if (i != list.Count - 1) { arrayString += ", "; }
            }
            arrayString += "]";
            Console.WriteLine(arrayString);
            return true;
        }

        private static void Shuffle<T>(this IList<T> list)
        {
            Random rand = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                int swapIndex = rand.Next(list.Count);
                T temp = list[swapIndex];
                list[swapIndex] = list[i];
                list[i] = temp;
            }
        }
    }
}
