using System;
using System.Collections.Generic;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Qno::1
            int y = 0;
            for (int t = 0; t < 1000; t++)
            {
                if (t % 3 == 0 || t % 5 == 0)
                {
                    y = y + t;
                }
            }

            Console.WriteLine("sum of all the multiples of 3 or 5 below 100 :: {0}",y);
            //QNo2
            List<int> number = new List<int>() { 1, 2 };
            int num, sum = 0;
            int q = 0;
            do
            {
                num = number[q] + number[q + 1];
                number.Add(num);
                q++;
            } while (num <= 4000000);
            /*for (int i = 0; i < 30; i++)
            {
                num = number[i] + number[i + 1];
                number.Add(num);
            }*/
            foreach (var i in number)
            {
          
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }

            }
            Console.WriteLine();
            Console.WriteLine("By considering the terms in the Fibonacci sequence whose values do not exceed four million,  the sum of the even-valued terms. :: {0}",sum);
            /*
            for(int i=0;i<30;i++)
            {
                if (number[i] % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);*/

            double x = 600851475143;


            while (x % 2 == 0)
            {
                
                x /= 2;
            }


            for (int i = 3; i <= Math.Sqrt(x); i += 2)
            {

                while (x % i == 0)
                {
                    
                    x /= i;
                   
                }
            }


           
            Console.Write("Highest Prime Factor the number 600851475143:: {0} ", x);
            Console.WriteLine();
             //Qno :: 4
            
            int max_product = 0;

            for (int i = 999; i >= 100; i--)
            {
                for (int j = i; j >= 100; j--)
                {
                  
                    int product = i * j;
                    if (product < max_product)
                        break;
                    int number1 = product;
                    int reverse = 0;
                    while (number1 != 0)
                    {
                        reverse = reverse * 10 + number1 % 10;
                        number1 /= 10;
                    }
                    if (product == reverse && product > max_product)
                        max_product = product;
                }
            }
            Console.WriteLine(" largest palindrome made from the product of two 3-digit numbers ::{0}",max_product);
            //Qno :: 5
            Program program = new Program();

            long p = 20;
            Console.WriteLine("What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 :: {0}",program.lcm(p));

            //Qno::6
            int sumofsqaure = 0, sqaureofsum , sqaure ,sum1=0,differnce;
            for(int s = 0; s <= 100; s++)
            {
                sum1 = sum1 + s;
                sqaure = s * s;
                sumofsqaure = sumofsqaure + sqaure;
            }
            sqaureofsum = sum1 * sum1;
            differnce = sqaureofsum - sumofsqaure;
            Console.WriteLine("Sum of First 100 Natural Numbers ::{0} ", sum1);
            Console.WriteLine("Sqaure Of Sum :: {0} ",sqaureofsum);
            Console.WriteLine("Sum OF Sqaure :: {0} ",sumofsqaure);
            Console.WriteLine("Difference Between Sum OF Sqaure and Sqaure of Sum :: {0} ", differnce);
        }
        public long  primrFactor(long a,long b)
        {
            if (a % b != 0)
            {
                return primrFactor(b, a % b);
            }
            else
                return b;
        }
        public long lcm(long l)
        {
            long ans = 1;
            for(long p=1;p<=l;p++)
            {
                ans = (ans * p) / (primrFactor(ans, p));
                
            }
            return ans;
        }
    }

}

