using System;
using System.Data.SQLite;

namespace SQLiteFunctions.Functions
{
    [SQLiteFunction(Name = "trim", Arguments = 2, FuncType = FunctionType.Scalar)]
    public class Trim : SQLiteFunction
    {
        public string ConstructCommand()
        {
            Console.Write("value: ");
            var value = Console.ReadLine();
            Console.WriteLine();
            Console.Write("character: ");
            var c = Console.ReadLine();

            return $"trim({value}, {c})";
        }

        public override object Invoke(object[] args)
        {
            return TrimCharacter(args[0].ToString(), args[1].ToString());
        }

        public string TrimCharacter(string value, string character)
        {
            int i = 0;
            for (; i < value.Length; i++)
                if (value[i] != character[0]) break;

            value = value.Substring(i);
            for(i = value.Length - 1; i >= 0; i--)
                if(value[i] != character[0]) break;

            return value.Substring(0, i + 1);
        }
    }
}
