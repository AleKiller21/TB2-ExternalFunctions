using System;
using System.Data.SQLite;

namespace SQLiteFunctions.Functions
{
    [SQLiteFunction(Name = "c2f", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class C2F : SQLiteFunction
    {
        public string ConstructCommand()
        {
            Console.Write("Celcius degree: ");
            var input = Console.ReadLine();

            return $"c2f({input})";
        }

        private double GetFahrenheit(double celcius)
        {
            return celcius * 9 / 5 + 32;
        }

        public override object Invoke(object[] args)
        {
            return GetFahrenheit(double.Parse(args[0].ToString()));
        }
    }
}
