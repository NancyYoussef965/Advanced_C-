using System;
using System.Collections;
using Advanced_C_;

namespace MyApp
{
    internal class Program

    {

        #region Q1
        //static void OptimizedBubbleSort(int[] arr)
        //{

        //    int n = arr.Length;
        //    bool swapped;
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        swapped = false;
        //        for (int j = 0; j < n - i - 1; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {
        //                int temp = arr[j];
        //                arr[j] = arr[j + 1];
        //                arr[j + 1] = temp;
        //                swapped = true;
        //            }
        //        }
        //        if (!swapped)
        //            break;
        //    }
        //    {

        //    }



        //}





        #endregion


        #region Q2
        //static void ReverseArrayList(ArrayList list)
        //{
        //    int i = 0;
        //    int j = list.Count - 1;
        //    while (i < j)
        //    {
        //        object temp = list[i];
        //        list[i] = list[j];
        //        list[j] = temp;
        //        i++;
        //        j--;
        //    }
        //}


        #endregion
        static void Main(string[] args)
        {

            #region Q1
            //int[] numbers=
            //    { 64, 34, 25, 12, 22, 11, 90 };

            //Console.WriteLine("Before Sorting: " + string.Join(", ", numbers));
            //OptimizedBubbleSort(numbers);
            //Console.WriteLine("After Sorting:  " + string.Join(", ", numbers));

            #endregion



            #region Q2

            //ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Before Reversing: " + string.Join(", ", numbers.ToArray()));
            //ReverseArrayList(numbers);
            //Console.WriteLine("After Reversing:  " + string.Join(", ", numbers.ToArray()));

            #endregion

            #region Q3
            //int[] arr = { 11, 5, 3 };
            //int[] queries = { 1, 5, 13 };
            //foreach ( int q in queries)
            //{
            //    Console.WriteLine(Helper.CountsGreaterThenX
            //        (arr, q));
            //}


            #endregion


            #region Q4
            //int[] arr = { 1, 2, 3, 2, 1 };
            //if (Helper.IsPalindrome
            //   (arr))
            //    Console.WriteLine("The array is a palindrome.");
            //else
            //    Console.WriteLine("The array is not a palindrome.");
            #endregion

            #region Q5

            //Queue<int> q1 = new Queue<int>(new int[] { 1, 2, 3 });
            //Helper.ReserveQueue (q1);
            //Console.
            //    WriteLine("Reversed Queue: " + string.Join(", ", q1.ToArray()));

            #endregion

            #region Q6
            //string s = "[()]{})";
            //Console.WriteLine(Helper.IsBalanced(s)? "The tring is balanced." : "The string is not balanced.");



            #endregion



            #region Q7

            //           int[] arr = { 1, 2, 3, 4, 1, 2, 6, 7, 7 };
            //int[] DistinctArray = Helper.RemoveDuplicates
            //               (arr);
            //           foreach (int Darr in
            //               DistinctArray)
            //       Console.WriteLine(Darr);


            #endregion




            #region Q8
            //ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Console.WriteLine("Before: ");
            //foreach (var n in numbers)
            //    Console.Write(n + " ");

            //numbers.RemoveAll(x => (int)x % 2 != 0);

            //Console.WriteLine("\nAfter removing odds: ");
            //foreach (var n in numbers)
            //    Console.Write(n + " ");

            #endregion


            #region Q9
            //Queue GenericQueue = new Queue();
            //GenericQueue.Enqueue(1);
            //GenericQueue.Enqueue("apple");

            //GenericQueue.Enqueue(5.7);
            //foreach (var item in GenericQueue)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion


            #region Q10
            
      Stack <int> stack = new Stack<int>( new int[] { 10,20, 30,40 ,50 });

            Helper.SearchInStack(stack, 30);



            #endregion



            #region Q11
            int[] arr1 = { 1, 2, 3, 4, 4 };
            int[] arr2 = { 10, 4, 4 };

            // Call Helper.GetIntersection using reflection since it's private
            var method = typeof(Helper).GetMethod("GetIntersection", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            var result = (List<int>)method.Invoke(null, new object[] { arr1, arr2 });

            Console.WriteLine("[" + string.Join(",", result) + "]");
            #endregion

            #region Q12





            #endregion

            #region Q13




            #endregion







        }
    }
}