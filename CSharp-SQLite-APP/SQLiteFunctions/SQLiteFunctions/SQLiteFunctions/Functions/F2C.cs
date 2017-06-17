using System;
using System.Data.SQLite;

namespace SQLiteFunctions.Functions
{
    [SQLiteFunction(Name = "f2c", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class F2C : SQLiteFunction
    {
        public string ConstructCommand()
        {
            Console.Write("Fahrenheit degree: ");
            var input = Console.ReadLine();

            return $"f2c({input})";
        }

        public override object Invoke(object[] args)
        {
            return ConvertToCelcius(double.Parse(args[0].ToString()));
        }

        private double ConvertToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
