using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {

        public static void PrintNumbers()
        {
            int i = 0;

            while (i < 256)
            {
                Console.WriteLine(i);
                i++;
            }

        }

        public static void PrintOdds()
        {
            int i = 1;

            while (i < 256)
            {
                Console.WriteLine(i);
                i+=2;
            }
        }

        public static void PrintSum()
        {
            int i = 0;
            int sum = 0;

            while(i < 256){

                Console.WriteLine(i);
                sum += i;
                Console.WriteLine("Sum: " + sum);
                i++;
            }
        }

        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 

            foreach(int i in numbers){
                Console.WriteLine(i);
            }
        }

        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.

            int max = numbers[0];

            foreach (int i in numbers)
            {
                if(i > max){
                    max = i;
                }
            }

            Console.WriteLine("The Max # is: " + max);
            return max;

        }

        public static void GetAverage(int[] numbers)
        {

            int sum = 0;

            foreach (int i in numbers)
            {
                sum += i;
            }

            Console.WriteLine("The Average of these numbers is: " + sum / numbers.Length);

        }

        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].

            List<int> newarray = new List<int>();

            int i = 1;

            while(i < 256){
                newarray.Add(i);
                i+=2;
            }

            int[] array = newarray.ToArray();
            return array;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).

            int count = 0;

            foreach (int i in numbers)
            {
                if(i > y){
                    count++;
                }
            }

            Console.WriteLine("There are " + count + " numbers greater than y.");
            return count;

        }

        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]

            for(int i = 0; i < numbers.Length; i++){

                int replace = numbers[i] * numbers[i];
                numbers[i] = replace;
            }
            
            Console.WriteLine("Squaring complete!");
            
        }

        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. copy
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < 0){
                    numbers[i] = 0;
                }
            }

            Console.WriteLine("All Negative numbers replaced!");
        }

        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.

            int max = numbers[0];
            int min = numbers[0];
            int count = 0;

            for(int i = 1; i < numbers.Length; i++){
                if(numbers[i] > max){
                    max = numbers[i];
                }
                if(numbers[i] < min){
                    min = numbers[i];
                }
                count+= numbers[i];
            }

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Avg: " + count / numbers.Length);
        }

        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].

            for(int i = 0; i < numbers.Length - 1; i++){
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = 0;
            Console.WriteLine("Numbers have been shifted!");
        }

        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].

            object[] newarray = new object[numbers.Length];

            for(int i = 0; i < numbers.Length; i++){

                if(numbers[i] < 0){
                    newarray[i] = "Dojo";
                }
                else{
                    newarray[i] = numbers[i];
                }
            }

            Console.WriteLine("Items have been boxed!");
            return newarray;
        }


        static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();

            int[] numarray = {-1,2,3,526, -62, 52};
            LoopArray(numarray);
            FindMax(numarray);
            GetAverage(numarray);

            int[] array = OddArray();
            GreaterThanY(array, 52);
            SquareArrayValues(array);
            EliminateNegatives(numarray);
            MinMaxAverage(array);
            int[] shift = {1,2,3,4,5};
            ShiftValues(shift);
            int[] data = {1,-2,-3,40,520};
            NumToString(data);
        }

        




    }
}
