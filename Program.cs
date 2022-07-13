using System;

namespace PalindromeSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSubstrings("abc"));
        }

        public int CountSubstrings(string s) {

            var chars_array = s.ToCharArray();
            var bool_arr = new bool[chars_array.Length, chars_array.Length];
            int longest_start = 0;
            int max_length = 1;
            int palindromeCount=0;
            for (int i = 0; i < chars_array.Length; i++) {
                bool_arr[i, i] = true;
                palindromeCount++;
            }
            for (int i = 0; i < chars_array.Length - 1; i++) {
                if (chars_array[i] == chars_array[i + 1]) {
                bool_arr[i, i + 1] = true;
                longest_start = i;
                max_length = 2;
                palindromeCount++;
                }
            }
            for (int length = 3; length <= chars_array.Length; length++) {
                for (int i = 0; i < chars_array.Length - length + 1; i++) {
                int j = i + length - 1;
                if (chars_array[i] == chars_array[j] && bool_arr[i + 1, j - 1]) {
                    bool_arr[i, j] = true;
                    if (max_length < (j - i)) {
                    max_length = j - i;
                    longest_start = i;              
                    }
                    palindromeCount++;
                }
                }
            }
                
                return palindromeCount;
        }
    }
}
