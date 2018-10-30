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

//            while (num > 1)
//            {
//                if (num % i == 0)
//                {
//                    Console.WriteLine(i);
//                }


//                else if (i > 10)
//                {
//                    break;
//                }
//                i++;
//            }


//        }
//    }
//}




////-----------------------------------------7BOOOM-------------------------------------------------------
///
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

            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int max = 1;
            while (max <= num)
            {
                if (max % 7 == 0)
                {
                    Console.WriteLine("7 BOOOM");
                }
                else
                {
                    Console.WriteLine(max);
                }
                max++;
            }

        }
    }
}
