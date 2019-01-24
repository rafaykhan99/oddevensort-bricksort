using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 10, 94, 8, 77, 6 ,77,6,75,98,70}; //input values 
            Console.WriteLine("xxxxx BEFORE xxxxx");
            print(array);                                               // printing the array before sorting
            array = oddeven(array);                                     // calling the sort function
            Console.WriteLine("xxxxx AFTER xxxxx");
            print(array);                                              // printing the array after sorting 
        }
        static public int[] oddeven(int[] array)
        {
            bool sorted = false;              //initially the array is unsorted
            while (!sorted)
            {
                sorted = true;
                int temp;                      
                for (int i = 1; i < array.Length - 1; i = i + 2) // loop working on odd indexed elements 
                {
                    if (array[i] > array[i + 1])   //comparing odd indexed elements with even indexed elements / performing bubble sort of odd indexed elements
                    {
                        temp = array[i];                 //swaping
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = false;                 
                    }
                }
                for (int i = 0; i < array.Length - 1; i = i + 2) // loop working on even indexed elements
                {
                    if (array[i] > array[i + 1])  //comparing even indexed elements with odd indexed elements / performing bubble sort on even indexed elements
                    {
                        temp= array[i];            // swaping
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = false;         
                    }
                }
            }
            return array;
        }
        static public void print(int[] array)       // A utility function for printing the array/values
        {
            foreach  (var elements in array)
            {
                Console.WriteLine(elements);
            }
        }
        
    }
}
