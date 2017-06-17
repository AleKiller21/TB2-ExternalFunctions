using System;
using System.Data.SQLite;

namespace SQLiteFunctions.Functions
{
    [SQLiteFunction(Name = "dec2bin", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class Dec2Bin : SQLiteFunction
    {
        public string ConstructCommand()
        {
            Console.Write("Decimal value: ");
            var input = Console.ReadLine();

            return $"dec2bin({input})";
        }

        private string DecToBin(int number)
        {
            string bin = "";
            string answer = "";

            if (number == 0) return "0";
            while (number > 0)
            {
                if (bin.Length == 0)
                {
                    if (number % 2 != 0) bin = bin.Insert(0, "1");
                    else bin = bin.Insert(0, "0");
                    number /= 2;
                    continue;
                }
                if (number % 2 != 0) bin = bin.Insert(bin.Length - 1, "1");
                else bin = bin.Insert(bin.Length - 1, "0");
                number /= 2;
            }
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (answer.Length == 0)
                {
                    answer = answer.Insert(0, bin[i] + "");
                    continue;
                }
                answer = answer.Insert(answer.Length - 1, bin[i] + "");
            }

            return answer;
        }

        public override object Invoke(object[] args)
        {
            return DecToBin(int.Parse(args[0].ToString()));
        }
    }
}
