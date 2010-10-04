/*
 * CMPT383 Assignment 03
 * Naoya Makino: 301117541
 * http://www.cs.sfu.ca/CC/383/ted/383-10-3/OutOfRange.html
 * October 03, 2010
 */

using System;
namespace Unsafe
{
	class Unsafe
	{
		const int INDEX = 10000;
		unsafe static void Main()
		{
			int[] array = new int[] {1,2,3};
			fixed (int* p = &array[0])//p is a pointer, & takes address of array
									  //the address of array will not move
				testUnsafe(p);
		}
		unsafe static void testUnsafe(int* p)
		{
			Console.WriteLine(p[INDEX]);//access out of the array-bound.
		}
	}
}

