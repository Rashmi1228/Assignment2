using System;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 0, b = 0;
            printPrimeNumbers(a, b);

            Console.WriteLine(" Enter the Number of terms for Series: ");
            string input = Console.ReadLine();
            double n = double.Parse(input);
            double r1 = getSeriesResult(n);
            Console.WriteLine("The output the series is: " + r1);




            Console.WriteLine("Enter a decimal number");
            string number = Console.ReadLine();
            long n2 = long.Parse(number);
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);



            long n3 = 0;
            long r3 = binaryToDecimal(n3);

            Console.WriteLine("Enter Number of layers for triangle");
            String layer = Console.ReadLine();
            int n4 = int.Parse(layer);
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            //write your self-reflection here as a comment

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {

                int i, j;
                Console.WriteLine("Enter the starting range for prime number");
                string input1 = Console.ReadLine();
                j = int.Parse(input1);
                Console.WriteLine("Enter the ending range for prime number");
                string input2 = Console.ReadLine();
                i = int.Parse(input2);
                Console.WriteLine("The prime numbers between starting and ending range are:");
                for (x = j; x <= i; x++) //Loop for each number between the range
                {
                    int n = 0;  // intitiate a variable and set to 0
                    for (y = 1; y <= i; y++)
                    {
                        if (x % y == 0) // if remainder is zero then increment otherwise exit the loop
                            n++;
                    }
                    if (n == 2)
                        Console.WriteLine(x);
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
            Console.ReadKey(true);
        }


        public static double getSeriesResult(double n)
        {
            try
            {
                int i;
                double e = 0; // For even term
                double o = 0; // For odd term
                double series = 0;
                for (i = 1; i <= n; i = i + 2)
                {
                    e = Factorial(i) / (i + 1); // Calculate Even terms
                }
                for (i = 2; i <= n; i = i + 2)
                {
                    o = Factorial(i) / (i + 1); // Calculate Odd Terms
                }

                series = e - o; // Final computation of series
                return series;


            }

            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            Console.ReadKey(true);
            return 0;

        }


        static double Factorial(int n)
        {
            try
            {
                int x = 1;
                int i = 1;
                for (i = 1; i <= n; i++)  //Loop to increase the number from 1 to n
                {
                    x = (x * i);      // multuply each number by the previous    
                }

                return x;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            Console.ReadKey();

            return 0;
        }


        public static long decimalToBinary(long n)
        {
            try
            {
                string result;
                result = "";

                while (n > 1)
                {
                    long r = n % 2; //Get the remainder of number after dividing by 2
                    result = Convert.ToString(r) + result; //store that value into result
                    n /= 2; // again divide the number by 2 and repeat the same process as long as the number is greater that 1
                }
                result = Convert.ToString(n) + result; //Get the output

                return Convert.ToInt64(result);

            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }
            Console.ReadKey();
            return 0;
        }

        public static long binaryToDecimal(long n)
        {
            try
            {

                long bin, a = 0, b = 1, rem;
                Console.Write("Enter a Binary Number: ");
                n = int.Parse(Console.ReadLine());
                bin = n;
                while (n > 0)
                {
                    rem = n % 10; // get the remainder by dividing 10
                    a = a + rem * b; // store the value of remainder
                    n = n / 10; // again divide the number by 10
                    b = b * 2; // multiply by 2 every time
                }

                Console.Write(" Decimal Equivalent is : " + a);




            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }
            Console.ReadKey();
            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {

                int j, k;
                Console.WriteLine("Print Triangle");
                for (int i = 1; i <= n; i++) // Total number of layer for trianlge  
                {
                    for (j = 1; j <= (n - i); j++) // Loop For Space before the star 
                        Console.Write(" ");
                    for (k = 1; k <= i; k++) //No. of stars(Increase the value)
                        Console.Write('*');
                    for (k = (i - 1); k >= 1; k--) //No. of stars (decrease the value)
                        Console.Write('*');
                    Console.WriteLine();

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
            Console.ReadKey();
        }

        public static void computeFrequency(int[] a)
        {
            try
            {

                int[] arr1 = new int[100];
                int[] arr2 = new int[100];
                int n, i, j, count;


                Console.Write("Count the frequency of each element of an array:\n");


                Console.Write("Input the number of elements to be stored in the array :");
                string number = Console.ReadLine();
                n = int.Parse(number);
                Console.WriteLine("Input {0} elements in the array :", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0} : ", i);
                    arr1[i] = int.Parse(Console.ReadLine()); //To enter the element of array
                    arr2[i] = 0; // no. of element of array(initiate)
                }
                for (i = 0; i < n; i++)
                {
                    count = 1;
                    for (j = i + 1; j < n; j++)
                    {
                        if (arr1[i] == arr1[j]) //Check for the element
                        {
                            count++;           //if element is present then increment
                            arr2[j] = 1;
                        }
                    }

                    if (arr2[i] != 1)
                    {
                        arr2[i] = count;  //if frequency of number is more that 1 then take the count
                    }

                }
                Console.WriteLine("frequency of all elements of the array : \n");
                for (i = 0; i < n; i++)
                {
                    if (arr2[i] != 1)
                    {
                        Console.WriteLine("{0} : {1} times", arr1[i], arr2[i]);
                    }

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
            Console.ReadKey(true);
        }

    }
}


