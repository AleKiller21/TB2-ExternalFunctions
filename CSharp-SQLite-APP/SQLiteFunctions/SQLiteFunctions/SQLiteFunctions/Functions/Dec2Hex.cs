using System;
using System.Data.SQLite;

namespace SQLiteFunctions.Functions
{
    [SQLiteFunction(Name = "dec2hex", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class Dec2Hex : SQLiteFunction
    {
        public string ConstructCommand()
        {
            Console.Write("Decimal value: ");
            var input = Console.ReadLine();

            return $"dec2hex({input})";
        }

        public override object Invoke(object[] args)
        {
            return DecToHex(int.Parse(args[0].ToString()));
        }

        private string DecToHex(int dec)
        {
            string bin = DecToBin(dec);
            string answer = "";
            string padLeft = "";
            string finalBin = "";
            int counter = 0;

            for (int i = bin.Length - 1; i >= 0; i--)
            {
                counter++;
                if (counter == 4) counter = 0;
            }
            if (counter != 0)
            {
                for (int i = 4; i > counter; i--)
                {
                    padLeft = Concat(padLeft, "0");
                }
            }

            finalBin = padLeft + bin;
            for (int i = 0; i < finalBin.Length; i += 4)
            {
                string hexDigit = "";
                for (int x = 0; x < 4; x++)
                {
                    if(x + i >= finalBin.Length) break;
                    hexDigit = Concat(hexDigit, finalBin[i + x] + "");
                }

                answer = Concat(answer, GetHexDigit(hexDigit));
            }

            return answer;
        }

        private string GetHexDigit(string bin)
        {
            switch (bin)
            {
                case "0000":
                    return "0";
                case "0001":
                    return "1";
                case "0010":
                    return "2";
                case "0011":
                    return "3";
                case "0100":
                    return "4";
                case "0101":
                    return "5";
                case "0110":
                    return "6";
                case "0111":
                    return "7";
                case "1000":
                    return "8";
                case "1001":
                    return "9";
                case "1010":
                    return "A";
                case "1011":
                    return "B";
                case "1100":
                    return "C";
                case "1101":
                    return "D";
                case "1110":
                    return "E";
                case "1111":
                    return "F";
                default:
                    return "";
            }
        }

        private string Concat(string holder, string value)
        {
            return holder.Length == 0 ? holder.Insert(0, value) : holder + value;
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
    }
}
