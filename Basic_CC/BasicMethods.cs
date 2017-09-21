using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Basic_CC
{
    class BasicMethods
    {
        public string ReverseString(string text)
        {
            string reversed = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }
            return reversed;
        }

        public long Factorialize(long number)
        {
            long result = 1;
            for (long i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public bool Palindrome(string text)
        {
            text = Regex.Replace(text.ToLower(), @"[^A-Za-z0-9]+", "");
            return text == ReverseString(text) ? true : false;
        }

        public int FindLongestWord(string text)
        {
            int longest = 0;
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (longest < word.Length)
                {
                    longest = word.Length;
                }
            }
            return longest;
        }

        public string TitleCase(string text)
        {
            string[] words = text.ToLower().Split(' ');
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                result += words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
                if (i < words.Length - 1)
                {
                    result += ' ';
                }
            }
            return result;
        }

        public long[] LargestOfFour(long[][] array)
        {
            long[] result = new long[4];
            for (int i = 0; i < array.Length; i++)
            {
                long largest = 0;
                foreach (long number in array[i])
                {
                    if (number > largest)
                    {
                        largest = number;
                    }
                }
                result[i] = largest;
            }
            return result;
        }

        public bool ConfirmEnding(string text, string endsWith)
        {
            return ReverseString(text).Substring(0, endsWith.Length) == ReverseString(endsWith) ? true : false;
        }

        public string RepeatStringNumTimes(string text, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += text;
            }
            return result;
        }

        public string TruncateString(string text, int num)
        {
            if (text.Length <= num)
            {
                return text;
            }
            else if (num <= 3)
            {
                return text.Substring(0, num) + "...";
            }
            else
            {
                return text.Substring(0, num - 3) + "...";
            }
        }

        public object[][] ChunkArrayInGroups(object[] arr, int size)
        {
            int arraySize = (int)(Math.Ceiling((arr.Length / (double)size)));
            int length = arr.Length;
            int x = 0;
            int y = 0;
            object[][] result = new object[arraySize][];
            for (int c = 0; c < arraySize; c++)
            {
                result[c] = new object[size];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (y == size)
                {
                    x++;
                    y = 0;
                }
                if (length < size && result[x][0] == null)
                {
                    result[x] = new object[length];
                }
                result[x][y] = arr[i];
                y++;
                length--;
            }
            return result;
        }

        public object[] Slasher(object[] arr, int num)
        {
            int size = arr.Length - num;
            if (size < 1)
            {
                return new object[0];
            }
            else if (num <= 0)
            {
                return arr;
            }
            else
            {
                object[] result = new object[size];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == num)
                    {
                        for (int y = 0; y < size; y++)
                        {
                            result[y] = arr[i + y];
                        }
                        break;
                    }
                }
                return result;
            }
        }

        public object[] Bouncer(object[] arr)
        {
            object[] ignored = new object[] { false, null, 0, "NaN", "undefined", "" };
            object[] result = new object[0];
            foreach (object item in arr)
            {
                if (!ignored.Contains<object>(item))
                {
                    //object[] temp = new object[result.Length + 1];
                    //for(int i = 0; i < result.Length; i++)
                    //{
                    //    temp[i] = result[i];
                    //}
                    //result = temp;
                    Array.Resize<object>(ref result, result.Length + 1);
                    result[result.Length - 1] = item;
                }
            }
            return result;
        }

        public object[] Destroyer(object[] arr, params object[] ignored)
        {
            object[] result = new object[0];
            foreach (object item in arr)
            {
                if (!ignored.Contains<object>(item))
                {
                    Array.Resize<object>(ref result, result.Length + 1);
                    result[result.Length - 1] = item;
                }
            }
            return result;
        }

        public int GetIndexToIns(int[] arr, double num)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        temp = arr[k + 1];
                        arr[k + 1] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
            int index = 0;
            for (int l = 0; l < arr.Length; l++)
            {
                if (arr[l] >= num)
                {
                    return index;
                }
                else
                {
                    index++;
                }
            }
            return index;
        }

        public string Rot13(string text)
        {
            char[] alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string result = "";
            foreach (char character in text.ToUpper())
            {
                for (int i = 0; i < alphabets.Length; i++)
                {
                    if (character == alphabets[i])
                    {
                        if (i >= 13)
                        {
                            result += alphabets[i - 13];
                            break;
                        }
                        else if (i < 13)
                        {
                            result += alphabets[i + 13];
                            break;
                        }
                    }
                    else if(i == alphabets.Length - 1)
                    {
                        result += character;
                    }
                }
            }
            return result;
        }
    }
}
