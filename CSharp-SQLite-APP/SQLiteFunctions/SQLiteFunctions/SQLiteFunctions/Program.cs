using System;
using System.Data;
using System.Data.SQLite;
using SQLiteFunctions.Functions;

namespace SQLiteFunctions
{
    class Program
    {
        static readonly SQLiteConnection ObjConnection = new SQLiteConnection("Data Source=Data/test.db;");

        static void Main(string[] args)
        {
            while (true)
            {
                PrintList();
                var input = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");
                switch (input)
                {
                    case 1:
                        ShowResult(new Pinger().ConstructCommand());
                        break;

                    case 2:
                        ShowResult(new PMT().ConstructCommand());
                        break;
                    
                    case 3:
                        ShowResult(new Bin2Dec().ConstructCommand());
                        break;

                    case 4:
                        ShowResult(new Dec2Bin().ConstructCommand());
                        break;

                    case 5:
                        ShowResult(new C2F().ConstructCommand());
                        break;

                    case 6:
                        ShowResult(new F2C().ConstructCommand());
                        break;

                    case 7:
                        ShowResult(new Factorial().ConstructCommand());
                        break;

                    case 8:
                        ShowResult(new Hex2Dec().ConstructCommand());
                        break;

                    case 9:
                        ShowResult(new Dec2Hex().ConstructCommand());
                        break;

                    case 10:
                        ShowResult(new SQLiteFunctions.Functions.StringComparison().ConstructCommand());
                        break;

                    case 11:
                        ShowResult(new Trim().ConstructCommand());
                        break;

                    case 12:
                        ShowResult(new Repeat().ConstructCommand());
                        break;

                    default:
                        return;
                }
            }
        }

        public static void ShowResult(string command)
        {
            SQLiteCommand ObjCommand = new SQLiteCommand($"select {command}", ObjConnection);
            ObjCommand.CommandType = CommandType.Text;
            SQLiteDataAdapter ObjDataAdapter = new SQLiteDataAdapter(ObjCommand);
            DataSet dataSet = new DataSet();
            ObjDataAdapter.Fill(dataSet);
            var dataSource = dataSet.Tables[0];
            Console.WriteLine(dataSource.Rows[0].ItemArray[0].ToString() + "\n");
        }

        static void PrintList()
        {
            Console.WriteLine("1) PING");
            Console.WriteLine("2) PMT");
            Console.WriteLine("3) BIN2DEC");
            Console.WriteLine("4) DEC2BIN");
            Console.WriteLine("5) C2F");
            Console.WriteLine("6) F2C");
            Console.WriteLine("7) Factorial");
            Console.WriteLine("8) HEX2DEC");
            Console.WriteLine("9) DEC2HEX");
            Console.WriteLine("10) COMPARESTRING");
            Console.WriteLine("11) TRIM");
            Console.WriteLine("12) REPEAT");
            Console.WriteLine("0) EXIT\n");
            Console.Write("Select function number: ");
        }
    }
}
