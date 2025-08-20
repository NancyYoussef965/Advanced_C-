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
    } }