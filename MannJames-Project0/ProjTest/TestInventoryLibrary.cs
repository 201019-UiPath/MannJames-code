﻿using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace ProjTest
{
    public  class TestInventoryLibrary
    {
        public int locId = 1;
        public Location location1 = new Location(1, "testLoc", "A", "B", 6);
        
        public Location location2 = new Location(2, "testLoc", "d", "c", 11);
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
