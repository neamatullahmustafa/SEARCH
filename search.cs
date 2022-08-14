using System;
namespace Sorted_Array
{
    class Program
    {
        static public long LinearSearch(int[] sortedArray1, int SizeOfArray1, int number)
        {
            bool checking = false;
            SizeOfArray1 = SizeOfArray1 - 1;
            for (int i = 0; i <= SizeOfArray1; i++)
            {
                sortedArray1[i] = i;
            }
            //Getting the number that wanted to search for
            Console.Write("Please Enter the Number you want to search for: ");
            number = Convert.ToInt32(Console.ReadLine());
            int counter;
            //Get the time of system before start execution
            DateTime currentDate = DateTime.Now;
            long timebefore = currentDate.Ticks;
            long executiontime = 0;
            //searching for the number 
            for (int j = 0; j <= SizeOfArray1; j++)
            {
                counter = j;
                while (counter <= SizeOfArray1)
                {
                    if (number == sortedArray1[j])
                    {
                        Console.WriteLine("The number you want is found and its index is {0} ", j);
                        checking = true;
                        break;
                    }
                    else counter++;
                }
            }
            if (checking == true)
            { Console.WriteLine("Thank you\n"); }
            else
                Console.WriteLine("The number is not in the array\n");
            //Get the time of system after execution
            DateTime currentDate2 = DateTime.Now;
            long timeafter = currentDate2.Ticks;
            executiontime = timeafter - timebefore;
            Console.WriteLine("the execution time is {0} Microseconds\n", executiontime);
            return 0;
        }
        static public long BinarySearch(int[] sortedArray1, int SizeOfArray1, int number, int low, int high)
        {
            //filling the array with elements
            SizeOfArray1 = SizeOfArray1 - 1;
            for (int i = 0; i <= SizeOfArray1; i++)
            {
                sortedArray1[i] = i;
            }
            if (number >= SizeOfArray1 + 1)
            {
                Console.WriteLine("Number is out of range");
                return 0;
            }
            int middle = 0;
            //Get the time of system before start execution
            DateTime currentDate = DateTime.Now;
            long timebefore = currentDate.Ticks;
            long executiontime = 0;
            middle = (low + high) / 2;
            if (number == sortedArray1[middle])
            {
                Console.WriteLine("The number {0} is in index number {1}", number, middle);
                //getting the time after execution
                DateTime currentDate2 = DateTime.Now;
                long timeafter = currentDate2.Ticks;
                executiontime = timeafter - timebefore;
                Console.WriteLine("the execution time is {0} Microseconds\n", executiontime);
            }
            else if (number > sortedArray1[middle])
            {
                BinarySearch(sortedArray1, SizeOfArray1 + 1, number, middle + 1, high);
            }
            else if (number < sortedArray1[middle])
            {
                BinarySearch(sortedArray1, SizeOfArray1 + 1, number, low, middle - 1);
            }
            else
                Console.WriteLine("NOT FOUND!!\n");
            return 0;
        }
        static void Main(string[] args)
        {
            //***************Linear Search ******************* 
            Console.WriteLine("*************** Linear Search ******************");
            int size = 1000;
            int[] SortedArrayS = new int[size];
            LinearSearch(SortedArrayS, size, 50);
            Console.WriteLine("\n\n");
            //**************** Binary Search ***********************
            Console.WriteLine("*************** Binary Search ******************");
            int number = 0;
            // long x;
            number = Convert.ToInt32(Console.ReadLine());
            int size1 = 1000;
            int[] SortedArrayS1 = new int[size1];
            BinarySearch(SortedArrayS1, size1, number, 1, 999);
        }
    }
}