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

            //MainMenu start = new MainMenu();
            //start.StartMenu();
            //customer
            //location
            //inv
            //view
            //order
            //custinfo
            //orderlists
            //employee
            //location
            //inv
            //view
            //edit
            //custinfoList
            //order



            //location
            //inv
            //view
            //order
            //login
            //edit (employees only)
            //login
            //custinfo
            //loginEmployee
            //custinfoList (employees only)
            //all orders
            //open
            //closed
            //loginCustomer
            //orderlists (customerView)
            //edit info

    }
    }
}
