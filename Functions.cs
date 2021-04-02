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
        public static int CountPairs(int[] arr, int target)
        {
            int pairs = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (i != j && arr[i] + arr[j] == target)
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

        //a function that takes a positive integer and returns the next bigger number
        //that can be formed by rearranging its digits.
        public static int NextBiggerNumber(int number)
        {
            int nextBigger = -1;
            var numbers = number.ToString().ToList();
            for (int i = numbers.Count - 2; i >= 0; --i)
            {
                if (numbers[i] >= numbers[i + 1]) continue;
                var rightPart = numbers.GetRange(i + 1, numbers.Count - i - 1);
                numbers.RemoveRange(i + 1, numbers.Count - i - 1);
                rightPart.Sort();
                for (var j = 0; j < rightPart.Count; ++j)
                {
                    if (rightPart[j] <= numbers[i]) continue;
                    var temp = numbers[i];
                    numbers[i] = rightPart[j];
                    rightPart[j] = temp;
                    string joined = numbers.Concat(rightPart).Aggregate("", (current, num) => current + num);
                    int.TryParse(joined, out nextBigger);
                    i = 0;
                    break;
                }
            }
            return nextBigger;
        }

        // Take the following IPv4 address: 128.32.10.1
        // This address has 4 octets where each octet is a single byte (or 8 bits).
        // · 1st octet 128 has the binary representation: 10000000
        // · 2nd octet 32 has the binary representation: 00100000
        // · 3rd octet 10 has the binary representation: 00001010
        // · 4th octet 1 has the binary representation: 00000001
        // So 128.32.10.1 == 10000000.00100000.00001010.00000001
        // Because the above IP address has 32 bits, we can represent it as the unsigned 32 bit number: 2149583361
        // Complete the function that takes an unsigned 32 bit number and returns a string representation of its IPv4 address.
        public static string NumToIpv4(uint number)
        {
            string binary = Convert.ToString(number, 2);
            if(binary.Length < 32) 
                binary = binary.PadLeft(32, '0');
            int[] arr = new int[4];
            for (int i = 0; i < 4; i++)
                arr[i] = Convert.ToInt32(binary.Substring(i * 8, 8), 2);
            return arr.Aggregate("", (full, part) => $"{full}.{part}").Trim('.');
        }
    }
}