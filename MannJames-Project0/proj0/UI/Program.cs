using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            StartingMenu start = new StartingMenu();
            start.StartMenu();
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
