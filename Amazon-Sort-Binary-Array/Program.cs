using System;

namespace Amazon_Sort_Binary_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int SortArr(int[] arr)
        {
            int len = arr.Length;
            int[] tmp = new int[arr.Length];
            Array.Copy(arr, tmp, arr.Length);
            int count = 0;
            int count1 = 0;
            for (int j = 1; j < len; j++)
            {
                for (int i = 1; i < len; i++)
                {
                    if (arr[i] != 0)
                    {
                        if (arr[i - 1] != arr[i])
                        {
                            int temp = arr[i];
                            arr[i] = arr[i - 1];
                            arr[i - 1] = temp;
                            count++;
                        }
                    }
                    if (tmp[i] != 1)
                    {
                        if (tmp[i - 1] != tmp[i])
                        {
                            int temp = tmp[i];
                            tmp[i] = tmp[i - 1];
                            tmp[i - 1] = temp;
                            count1++;
                        }
                    }
                }
            }
            return Math.Min(count, count1);
        }
    }
}
