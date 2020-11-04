using Serilog;
using System;

namespace UI
{
    class Program
    {

        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("logs/log.txt",
                outputTemplate: "{Timestamp: yyyy-MM-dd HH:mm:ss.fff zzz}[{ Level: u3}]{ Message: lj}{ NewLine}{ Exception}")
                .CreateLogger();

            if (Log.Logger == null) 
            { throw new Exception("Logger not working."); }

            IMenu main = new MainMenu(new StoreDB.StoreDBContext());
            main.Start();


        }
    }
}
