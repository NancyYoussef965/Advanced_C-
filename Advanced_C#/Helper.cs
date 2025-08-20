using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_
{
    internal static class Helper
    {
        public static int CountsGreaterThenX(int[] arr, int x)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num > x)
                {
                    count++;
                }
            }
            return count;
        }

        static public bool IsPalindrome(int[] arr)
        {
            int i = 0, j = arr.Length - 1;
            while (i < j)
            {
                if (arr[i] != arr[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }


    
    public static void ReserveQueue<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }





        public static bool IsBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();
       Dictionary<char, char> brackets = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };
            foreach (char c in str)
            {
                if (brackets.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (brackets.ContainsValue(c))
                {
                    if (stack.Count == 0 || brackets[stack.Pop()] != c)
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }


        public static int[] RemoveDuplicates(int[] arr)
        {
            return  arr
                .Distinct().ToArray();
        }







    } }