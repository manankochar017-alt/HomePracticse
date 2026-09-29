//using System;
//using System.Collections.Generic;
//using System.Text;
////Nested: customer type 'P' (premium) or 'R' (regular). Premium gets +1% if tenure >= 3 yrs, else +0.5%. Regular gets no bonus. Base rate is 6%.
//namespace HomePracticse
//{
//    internal class NestedType3
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter your customer type (P for premium, R for regular):");
//            char customerType = Convert.ToChar(Console.ReadLine().ToUpper());
//            Console.WriteLine("Enter your tenure in years:");
//            int tenure = Convert.ToInt32(Console.ReadLine());
//            double baseRate = 6.0;
//            double finalRate = baseRate;
//            if (customerType == 'P')
//            {
//                if (tenure >= 3)
//                {
//                    finalRate += 1.0;
//                }
//                else
//                {
//                    finalRate += 0.5; 
//                }
//            }
           
//            Console.WriteLine($"Your final rate is {finalRate}%.");
//        }
//    }
//}
