//using System;
//using System.Collections.Generic;
//using System.Text;
////Nested: credit score 750+ gets 8%. If the score is 650–749, check the income (>30000 gets 11%, else 13%). Below 650 is rejected.
//namespace HomePracticse
//{
//    internal class NestedType2
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter your credit score:");
//            int creditScore = Convert.ToInt32(Console.ReadLine());
//            if (creditScore >= 750)
//            {
//                Console.WriteLine("Your rate is 8%.");
//            }
//            else if (creditScore >= 650)
//            {
//                Console.WriteLine("Enter your income:");
//                double income = Convert.ToDouble(Console.ReadLine());
//                if (income > 30000)
//                {
//                    Console.WriteLine("Your rate is 11%.");
//                }
//                else
//                {
//                    Console.WriteLine("Your rate is 13%.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Your application is rejected.");
//            }
//        }
//    }
//}
