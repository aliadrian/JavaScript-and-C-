// Your task is to write a function that does just what the title suggests (so, fair warning, be aware that you are not getting out of it just throwing a lame bas sorting method there) with an array/list/vector of integers and the expected number n of smallest elements to return.

// Also:

// the number of elements to be returned cannot be higher than the array/list/vector length;
// elements can be duplicated;
// in case of duplicates, just return them according to the original order (see third example for more clarity).
// Same examples and more in the test cases:

// firstNSmallest([1,2,3,4,5],3) === [1,2,3] //well, not technically ===, but you get what I mean
// firstNSmallest([5,4,3,2,1],3) === [3,2,1]
// firstNSmallest([1,2,3,4,1],3) === [1,2,1]
// firstNSmallest([1,2,3,-4,0],3) === [1,-4,0]
// firstNSmallest([1,2,3,4,5],0) === []

using System;
using System.Collections.Generic;
using System.Linq;

class Kata
{
    public static int[] FirstNSmallest(int[] arr, int n)
    {
			if (n <= 0 || n > arr.Length)
			{
				return new int[0];
			}

			List<int> result = arr
				.Select((value, index) => new { Value = value, Index = index })
				.OrderBy(x => x.Value)
				.ThenBy(x => x.Index)
				.Take(n)
				.OrderBy(x => x.Index)
				.Select(x => x.Value)
				.ToList();

			foreach (var item in arr)
			{
				Console.WriteLine(item);        
      }

			Console.WriteLine($"N length: {n}");
			return result.ToArray();
    }
}