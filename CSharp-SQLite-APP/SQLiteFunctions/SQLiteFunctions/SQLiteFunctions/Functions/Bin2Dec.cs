using System;
using System.Data.SQLite;

namespace SQLiteFunctions.Functions
{
    [SQLiteFunction(Name = "bin2dec", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class Bin2Dec : SQLiteFunction
    {
        public string ConstructCommand()
        {
            Console.Write("Binary value: ");
            var input = Console.ReadLine();

            return $"bin2dec({input})";
        }

        public override object Invoke(object[] args)
        {
            return BinToDecimal(args[0].ToString());
        }

        private int BinToDecimal(string bin)
        {
            int value = 0;
            int counter = 1;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (i == bin.Length - 1)
                {
                    if (bin[i] == '1') value = 1;
                    counter *= 2;
                    continue;
                }
                if (bin[i] == '1') value += counter;
                counter *= 2;
            }

            return value;
        }
    }
}
