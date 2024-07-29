using System;
using System.Linq;

namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool Palindrome(string str)
		{
            var newS = new string(str.Where(x => char.IsLetter(x)).ToArray()).ToLower();

            return newS == new string(newS.Reverse().ToArray());
        }
	}
}

