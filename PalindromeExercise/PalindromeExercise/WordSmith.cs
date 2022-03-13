using System;
using System.Linq;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var array = word.ToCharArray();
            Array.Reverse(array);
            var reverse = new string(array);
            return (reverse == word) ? true : false;
        }
    }
}
