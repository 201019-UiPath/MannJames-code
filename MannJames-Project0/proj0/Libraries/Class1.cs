using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Libraries
{
    public class Class1
    {
        public int locId = 1;

        IEnumerable<InvProduct> InvProdList = new List<InvProduct>()
            {
                new InvProduct(1,1,"spam",7),
                new InvProduct(2,1,"red fish", 9),
                new InvProduct(1,2,"blue fish",7),
                new InvProduct(2,2,"one fish", 9),
                new InvProduct(3,2,"two",7),
                new InvProduct(4,2,"haggis", 9)
            };
    }
}
