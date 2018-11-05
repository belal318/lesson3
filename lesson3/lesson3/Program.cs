
///==============================================Q3======================================================
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lesson3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int i = 2;
//            Console.WriteLine("Enter a number");
//            int num = int.Parse(Console.ReadLine());

//            while (i <= 10)
//            {
//                if (num % i == 0)
//                {
//                    Console.Write(i + ", ");
//                    Console.WriteLine($"{i} ,");
//                }
//                i++;
//            }
//            Console.WriteLine("\b\b ");// for removing the space and the "," from the outpot window!!!
//            Console.Clear();
//        }
//    }
//}




////-----------------------------------------7BOOOM-------------------------------------------------------
///
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lesson3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Enter a number");
//            int num = int.Parse(Console.ReadLine());
//            int max = 1;
//            while (max <= num)
//            {
//                if (max % 7 == 0)
//                {
//                    Console.WriteLine("7 BOOOM");
//                }
//                else
//                {
//                    Console.WriteLine(max);
//                }
//                max++;
//            }

//        }
//    }
//}


//==================================Q4=====================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,counter = 0;
            Console.Write("Please Enter A Number : ");
            string input = Console.ReadLine();
            while (input != "done")
            {
                int num = int.Parse(input);
                sum += num;
                counter++;
                Console.Write("Please Enter A Number : ");
                input = Console.ReadLine();
            }
            Console.WriteLine(sum / (counter*1.0));
        }
    }
}
