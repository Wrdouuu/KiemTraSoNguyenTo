using System;

namespace KIEMTRASONGUYENTO;

    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter your number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if(number < 2)
            {
                Console.WriteLine(number +"is not a prime number");
            }
            else
            {
                 int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(number + " is a prime");
                }
                else
                {
                    Console.WriteLine(number + " is not a prime");
            }
        }
    }
}
