using System;
using System.Data.SQLite;

namespace SQLiteFunctions.Functions
{
    [SQLiteFunction(Name = "repeat", Arguments = 2, FuncType = FunctionType.Scalar)]
    public class Repeat : SQLiteFunction
    {
        public string ConstructCommand()
        {
            Console.Write("Value: ");
            var value = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Times: ");
            var times = Console.ReadLine();

            return $"repeat({value}, {times})";
        }

        public override object Invoke(object[] args)
        {
            return RepeatWord(args[0].ToString(), int.Parse(args[1].ToString()));
        }

        private string RepeatWord(string value, int n)
        {
            string answer = "";
            for (int i = 0; i < n; i++)
            {
                answer += value;
            }

            return answer;
        }
    }
}
