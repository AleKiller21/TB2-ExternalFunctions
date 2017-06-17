using System;
using System.Data.SQLite;

namespace SQLiteFunctions.Functions
{
    [SQLiteFunction(Name = "factorial", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class Factorial : SQLiteFunction
    {
        public string ConstructCommand()
        {
            Console.Write("Value: ");
            var input = Console.ReadLine();

            return $"factorial({input})";
        }

        public override object Invoke(object[] args)
        {
            return GetFactorial(int.Parse(args[0].ToString()));
        }

        private int GetFactorial(int number)
        {
            if (number == 0) return 1;

            int answer = 1;
            for (int i = 1; i < number; i++) answer *= (i + 1);
            return answer;
        }
    }
}
