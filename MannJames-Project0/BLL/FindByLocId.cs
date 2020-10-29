using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace BLL
{
    public class FindByLocId
    {
        List<Location> locations;
        int locId;
        public FindByLocId(int locId)
        {
            var result = locations.
                Where(r => locations.Contains(locId));
        }
    }
}
