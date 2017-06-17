using System;
using System.Data.SQLite;

namespace SQLiteFunctions.Functions
{
    [SQLiteFunction(Name = "hex2dec", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class Hex2Dec : SQLiteFunction
    {
        public string ConstructCommand()
        {
            Console.Write("Hexadecimal value: ");
            var input = Console.ReadLine();

            return $"hex2dec({input})";
        }

        public override object Invoke(object[] args)
        {
            return ConvertHexToDec(args[0].ToString());
        }

        public int ConvertHexToDec(string hex)
        {
            string bin = "";
            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case '0':
                        bin = Concat(bin, "0000");
                        break;
                    case '1':
                        bin = Concat(bin, "0001");
                        break;
                    case '2':
                        bin = Concat(bin, "0010");
                        break;
                    case '3':
                        bin = Concat(bin, "0011");
                        break;
                    case '4':
                        bin = Concat(bin, "0100");
                        break;
                    case '5':
                        bin = Concat(bin, "0101");
                        break;
                    case '6':
                        bin = Concat(bin, "0110");
                        break;
                    case '7':
                        bin = Concat(bin, "0111");
                        break;
                    case '8':
                        bin = Concat(bin, "1000");
                        break;
                    case '9':
                        bin = Concat(bin, "1001");
                        break;
                    case 'A':
                        bin = Concat(bin, "1010");
                        break;
                    case 'B':
                        bin = Concat(bin, "1011");
                        break;
                    case 'C':
                        bin = Concat(bin, "1100");
                        break;
                    case 'D':
                        bin = Concat(bin, "1101");
                        break;
                    case 'E':
                        bin = Concat(bin, "1110");
                        break;
                    case 'F':
                        bin = Concat(bin, "1111");
                        break;
                }
            }

            return BinToDecimal(bin);
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

        private string Concat(string holder, string value)
        {
            return holder.Length == 0 ? holder.Insert(0, value) : holder + value;
        }
    }
}
