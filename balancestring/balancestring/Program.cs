﻿// C# program to find smallest
// window containing
// all characters of a pattern.
using System;

class GFG
{
	static int no_of_chars = 256;

	// Function to find smallest
	// window containing
	// all characters of 'pat'
	static String findSubString(String str,
								String pat)
	{
		int len1 = str.Length;
		int len2 = pat.Length;

		// Check if string's length is
		// less than pattern's
		// length. If yes then no such
		// window can exist
		if (len1 < len2)
		{
			Console.WriteLine("No such window exists");
			return "";
		}

		int[] hash_pat = new int[no_of_chars];
		int[] hash_str = new int[no_of_chars];

		// Store occurrence ofs characters
		// of pattern
		for (int i = 0; i < len2; i++)
			hash_pat[pat[i]]++;

		int start = 0, start_index = -1,
			min_len = int.MaxValue;

		// Start traversing the string
		// Count of characters
		int count = 0;
		for (int j = 0; j < len1; j++)
		{

			// Count occurrence of characters
			// of string
			hash_str[str[j]]++;

			// If string's char matches
			// with pattern's char
			// then increment count
			if (hash_str[str[j]] <= hash_pat[str[j]])
				count++;

			// if all the characters are matched
			if (count == len2)
			{

				// Try to minimize the window
				while (hash_str[str[start]]
						> hash_pat[str[start]]
					|| hash_pat[str[start]] == 0)
				{

					if (hash_str[str[start]]
						> hash_pat[str[start]])
						hash_str[str[start]]--;
					start++;
				}

				// update window size
				int len_window = j - start + 1;
				if (min_len > len_window)
				{
					min_len = len_window;
					start_index = start;
				}
			}
		}

		// If no window found
		if (start_index == -1)
		{
			Console.WriteLine("No such window exists");
			return "";
		}

		// Return substring starting from start_index
		// and length min_len
		return str.Substring(start_index, min_len);
	}

	// Driver Method
	public static void Main(String[] args)
	{
		String str = "this is a test string";
		String pat = "tist";

		Console.WriteLine("Smallest window is :\n "
						+ findSubString(str, pat));
	}
}

/* This code contributed by PrinciRaj1992 */
