using System;
using HerosLib;

namespace HerosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region default constructor
            /*Hero obj=new Hero();
            Console.WriteLine($"{obj.id} {obj.name}" );*/
            #endregion
            #region Parameterized constructor
            Hero obj1=new Hero(2, "Narco");
           //Program obj1=new Program();
           //Console.WriteLine($"{obj1.id} {obj1.name}" );// cannot access the variable if they arenot public
            #endregion
            #region Access via Properties
            Console.WriteLine(obj1.Id);// read property value
            obj1.Id=3;
            Console.Write($"New Id = {obj1.Id}");// write into a property
            #endregion
        }
    }
}
