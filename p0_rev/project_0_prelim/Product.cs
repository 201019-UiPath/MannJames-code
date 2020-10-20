using System;

namespace project_0
{
    class Product
    {
        int productID{get;set;}
        //list locations;
        string productName{get;set;}
        string productType{get;set;}
        //convert name to lowercase
        float productPrice{get;set;}

        public Product(int productID, string productName, string productType, float productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productType = productType;
            this.productPrice = productPrice;

        }

    }
}