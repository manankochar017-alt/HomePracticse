//using System;
//using System.Collections.Generic;
//using System.Text;
////Late EMI penalty: 0 days late = no penalty, 1–10 days = 2% interest, above 10 days = 5% interest, on the EMI amount.
//namespace HomePracticse
//{
//    internal class LatePenalty
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number of days late:");
//            int daysLate = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the EMI amount:");
//            double emiAmount = Convert.ToDouble(Console.ReadLine());
//            if (daysLate == 0)
//            {
//                Console.WriteLine("No penalty.");
//            }
//            else if (daysLate >= 1 && daysLate <= 10)
//            {
//                double penalty = emiAmount * 0.02;
//                Console.WriteLine($"Penalty is 2% of EMI amount: {penalty}");
//            }
//            else
//            {
//                double penalty = emiAmount * 0.05;
//                Console.WriteLine($"Penalty is 5% of EMI amount: {penalty}");
//            }
//        }
//    }
//}
