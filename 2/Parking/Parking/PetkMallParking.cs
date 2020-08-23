using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class PetkMallParking
    {
        MallParking[] allMall;

        public PetkMallParking(MallParking[] AllMall)
        {
            for (int i = 0; i < AllMall.Length; i++)
            {
                AllMall[i] = new MallParking("ofer", 10);
            }
        }
       
    }
}
