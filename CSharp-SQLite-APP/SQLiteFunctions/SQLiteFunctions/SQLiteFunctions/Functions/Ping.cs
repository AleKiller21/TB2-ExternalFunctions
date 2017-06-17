using System;
using System.Data.SQLite;
using System.Net.NetworkInformation;

namespace SQLiteFunctions.Functions
{
    [SQLiteFunction(Name = "ping", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class Pinger : SQLiteFunction
    {
        public string ConstructCommand()
        {
            Console.Write("Ip or hostname: ");
            var input = Console.ReadLine();

            return $"ping({input})";
        }

        public override object Invoke(object[] args)
        {
            return PingHost(args[0].ToString());
        }

        private string PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(nameOrAddress);
                if (reply.Status == IPStatus.Success) return "1";
            }
            catch (PingException)
            {
                
            }

            return "-1";
        }
    }
}
