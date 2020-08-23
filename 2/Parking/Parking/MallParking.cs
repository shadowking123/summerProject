using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class MallParking
    {
        string mallName;
        Parking[] park;
        
        public MallParking(string name, int maxZero)
        {
            for (int i = 0; i < park.Length; i++)
            {
                park[i].setCurrent(0);
            }
        }


    }
}
