using System;
using System.Collections;

namespace BLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a location number: ");
            SelectLocation locList = new SelectLocation();
            locList.LocationFilter();
        }
    }
}
