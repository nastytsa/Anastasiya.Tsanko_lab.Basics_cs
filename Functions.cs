using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace lab_basics
{
    public class Functions
    {
        //a function that takes a list of non-negative integers and strings and returns a new
        //list with the strings filtered out.
        public static List<object> GetIntegersFromList(IEnumerable<object> list)
        {
            var ints = list.Where(x => x is int).ToList();
            return ints;
        }
        
        //a function that takes a string input, and returns
        //the first character that is not repeated anywhere in the string.
        public static string first_non_repeating_letter(string input)
        {
            string lowCase = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if ((lowCase.Replace(lowCase[i].ToString(), "  ").Length - lowCase.Length) == 1)
                    return input[i].ToString();
                lowCase = input.ToLower();
            }

            return "";
        }
        
        //Digital root is the recursive sum of all the digits in a number.
        //Given n take the sum of the digits of n. If that value has more than one digit, continue
        //reducing in this way until a single-digit number is produced. The input will be a non-
        //negative integer.
        public static int DigitalRoot(int number)
        {
            while (true)
            {
                int sum = 0;
                while (number % 10 > 0)
                {
                    sum = (number % 10) + sum;
                    number = number / 10;
                }

                if (sum / 10 > 0)
                {
                    number = sum;
                    continue;
                }

                return sum;
            }
        }
        
        //There is an array of numbers - arr [1, 3, 6, 2, 2, 0, 4, 5]
        //there is a number target = 5.
        //Count the number of pairs in the array, the sum of which will give target
        public static int CountPairs(int[] arr, int target){
            int pairs = 0;
            for (int i = 0; i < arr.Length; i++) {
                for (int j = i; j < arr.Length; j++){
                    if( i!= j && arr[i] + arr[j] == target)
                        pairs++;
                }
            }
            return pairs;
        }
        
        //Den has invited some friends. Could you make a program that
        //· makes this string uppercase
        //· gives it sorted in alphabetical order by last name.
        //When the last names are the same, sort them by first name. Last name and first name of a
        //guest come in the result between parentheses separated by a comma.
        public static string SortFriends(string friends)
        {
            List<string> friendList = new List<string>();
            foreach (string person in friends.ToUpper().Split(';'))
            {
                var temp = person.Split(':').Reverse();
                friendList.Add(string.Join(", ", temp));
            }
            friendList.Sort();
            return '(' + string.Join(")(", friendList) + ')';
        }
        
        
    }
}