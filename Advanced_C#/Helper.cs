using System;
using System.Collections;
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


        public static void RemoveAll(this ArrayList list, Predicate<object> match)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (match(list[i]))
                    list.RemoveAt(i);
            }
        }



        public static  void SearchInStack(Stack<int> stack, int value)
        {
            if (stack.Contains(value))
            {
                Console.WriteLine($"Value {value} found in the stack.");
            }
            else
            {
                Console.WriteLine($"Value {value} not found in the stack.");
            }
        }




      public  static List<int> GetIntersection(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            List<int> intersection = new List<int>();

            foreach (int num in arr1)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            foreach (int num in arr2)
            {
                if (freq.ContainsKey(num) && freq[num] > 0)
                {
                    intersection.Add(num);
                    freq[num]--;
                }
            }

            return intersection;
        }


    public    static List<int> FindContiguousSubArray(List<int> arr, int targetSum)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                int currentSum = 0;
                for (int j = i; j < arr.Count; j++)
                {
                    currentSum += arr[j];
                    if (currentSum == targetSum)
                    {
                        return arr.GetRange(i, j - i + 1);
                    }
                }
            }
            return new List<int>(); 
        }



        public static Queue<int> ReverseFirstKElements(Queue<int> q, int k)
        {
            if (k <= 0 || k > q.Count)
                return q;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(q.Dequeue());
            }

            Queue<int> newQueue = new Queue<int>();
            while (stack.Count > 0)
            {
                newQueue.Enqueue(stack.Pop());
            }

            while (q.Count > 0)
            {
                newQueue.Enqueue(q.Dequeue());
            }

            return newQueue;
        }


}







} 
