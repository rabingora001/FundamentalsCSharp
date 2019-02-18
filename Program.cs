using System;

namespace PracticeAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            //calling method from other class into main class(that is static).
            Rabin.say("pratesh");

            //calling method from other class into main class(that is non-static).

            Rabin sayHobby = new Rabin();
            sayHobby.Hobby("writing code", "pratesh");

            Rabin.printRandom();

            //calling method of the same class(method inside the main class)
            string parameterForstr="aaaaabbbcc";
            Console.WriteLine($"max repeating character is: {maxRepeating(parameterForstr)}");

            //calling mergeArrays method. since it has vod return and console.Write in the method itself we can call it without console.writeline.
            int[] arr1 = {1,3,4,5, 9, 11};
            int[] arr2 = {2,6,7,8};
            mergeArrays(arr1, arr2);

        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // +                                                                                    +
        // +                                                                                    +
        // +      ************* Microsoft interview questions ****************                  +
        // +                                                                                    +
        // +                                                                                    +
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    


            //method inside same class
        static char maxRepeating(string str) 
        { 
            int n = str.Length; 
            int count = 0; 
            char res = str[0]; 
            int cur_count = 1; 

            // Traverse string except  
            // last character 
            for (int i = 0; i < n; i++) 
            { 
                // If current character  
                // matches with next 
                if (i < n - 1 && str[i] == str[i + 1]) 
                    cur_count++; 

                // If doesn't match, update result 
                // (if required) and reset count 
                else
                { 
                    if (cur_count > count) 
                    { 
                        count = cur_count; 
                        res = str[i]; 
                    } 
                    cur_count = 1; 
                } 
            } 
            Console.WriteLine($"max number of repeat: {count}");
            return res; 
        }  

        public static void mergeArrays(int[] arr1, int[] arr2) 
        { 
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0; 

            // Traverse both array 
            while (i < arr1.Length && j < arr2.Length) 
            { 
                // Check if current element  
                // of first array is smaller
                // than current element 
                // of second array. If yes,  
                // store first array element  
                // and increment first array 
                // index. Otherwise do same  
                // with second array
                if (arr1[i] < arr2[j]) 
                    arr3[k++] = arr1[i++]; 
                else
                    arr3[k++] = arr2[j++]; 
            } 
            // Store remaining  
            // elements of first array 
            while (i < arr1.Length) 
                arr3[k++] = arr1[i++]; 
            // Store remaining elements 
            // of second array 
            while (j < arr2.Length) 
                arr3[k++] = arr2[j++]; 

            for(int z=0; z< arr1.Length+arr2.Length; z++)
            {
                Console.Write(arr3[z] + " " );
            }
        } 
    }


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // +                                                                                    +
        // +                                                                                    +
        // +      ************* Microsoft interview questions ****************                  +
        // +                                                                                    +
        // +                                                                                    +
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



    //different classes and methods.
    class Rabin
    {
        public static void say(String name) //with static 
        {
            Console.WriteLine("Hello {0}, Welcome to the coding world!!", name );
        }

        public void Hobby(String hobby, String name) //without static
        {
            Console.WriteLine("your hobby is {0} , {1} !!", hobby, name);
        }

        Random rand = new Random();
        public static void printRandom()
        {
            for(int val = 0; val < 10; val++)
            {
                Random rand= new Random();
                //Prints the next random value between 2 and 8
                Console.WriteLine(rand.Next(2,8));
            }
        }
    }
}
