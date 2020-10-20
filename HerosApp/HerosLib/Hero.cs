using System;

namespace HerosLib
{
   public class Hero// default modifier -> internal
    {
    // default modifier of members of a class is private
      /* int id;// value type => System.Int32
       public int Id{
           get{
               return id;
           }
           set{
               id=value;
           }
       }*/
       public int Id{get;set;}// autonomous property
       string name;// reference type
        // Constructor - default
        public Hero(){
           // id=1;
            name="Bombasto";
        }
        // snippet ctor + double <tab> key
        public Hero(int id, string name)
        {
           /// this.id=id;
           Id=id;
            this.name=name;
        }
    }
}
