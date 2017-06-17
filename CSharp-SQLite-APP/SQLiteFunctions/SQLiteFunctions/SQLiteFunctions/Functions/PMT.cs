using System;
using System.Data.SQLite;

namespace SQLiteFunctions.Functions
{
    [SQLiteFunction(Name = "pmt", Arguments = 3, FuncType = FunctionType.Scalar)]
    public class PMT : SQLiteFunction
    {
        public string ConstructCommand()
        {
            Console.Write("Annual interest rate: ");
            var interestRate = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Periods: ");
            var periods = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Initial Value: ");
            var loan = Console.ReadLine();

            return $"pmt({interestRate}, {periods}, {loan})";
        }

        public override object Invoke(object[] args)
        {
            return CalculatePmt(double.Parse(args[0].ToString()), int.Parse(args[1].ToString()),
                double.Parse(args[2].ToString()));
        }

        private double CalculatePmt(double annualInterestRate, int periods, double loan)
        {
            double R = (annualInterestRate / 100) / 12;
            return (loan * R) / (1 - Math.Pow((1 + R), (-periods)));
        }
    }
}
