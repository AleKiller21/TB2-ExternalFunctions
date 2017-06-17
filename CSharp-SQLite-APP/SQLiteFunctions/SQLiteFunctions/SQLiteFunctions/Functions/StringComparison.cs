using System;
using System.Data.SQLite;

namespace SQLiteFunctions.Functions
{
    [SQLiteFunction(Name = "compare", Arguments = 2, FuncType = FunctionType.Scalar)]
    public class StringComparison : SQLiteFunction
    {
        public string ConstructCommand()
        {
            Console.Write("string 1: ");
            var val1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("string 2: ");
            var val2 = Console.ReadLine();

            return $"compare({val1}, {val2})";
        }

        public override object Invoke(object[] args)
        {
            return CompareString(args[0].ToString(), args[1].ToString());
        }

        private string CompareString(string val1, string val2)
        {
            if (val1.Length < val2.Length) return "-1";
            return val1.Length == val2.Length ? "0" : "1";
        }
    }
}
