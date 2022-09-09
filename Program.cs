using System;

namespace GeekBrains06
{
    class Program
    {
         static int task41(int[] array)
        {
            int result = 0;
           
            foreach(int x in array)
            {
                if (x > 0)
                {
                    result++;
                }

            }

            return result;
        }

        static void task43(int k1, int b1, int k2, int b2)
        {
            double x0, y0;

            x0 = (b2 - b1) / (k1 - k2);
            y0 = k1 * x0 + b1;

            Console.WriteLine($"coordinates of point  x:{x0} y:{y0}");
        }
        static void Main(string[] args)
        {
             Console.WriteLine("task41");
            Console.WriteLine("Count how many numbers greater than 0 the user entered ");
            Console.Write("Enter number in array:  " );

            int m = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[m];
            int value;
            for (int i = 0; i < m;)
            {
                Console.Write($"{i + 1} number is: ");
                value = Convert.ToInt32(Console.ReadLine());
                array.SetValue(value, i);

                i++;

            }

            Console.WriteLine("task41 result: "+ task41(array) );
            Console.WriteLine("____________________________");


            Console.WriteLine("task41");
            Console.WriteLine("Find the point of intersection of two lines find the point of intersection of two lines");
            Console.Write("Enter k1:  ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b1:  ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter k2:  ");
            int k2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b1:  ");
            int b2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("task41 result: " );
            task43(k1, b1, k2, b2);
            
        }
    }
}
