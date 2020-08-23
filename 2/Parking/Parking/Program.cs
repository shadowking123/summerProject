using System;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking defult = new Parking(4,12);
            Parking defult1 = new Parking(1, 52);
            Parking defult2 = new Parking(5, 24);

            Parking[] defults = {defult, defult1,defult2 };
            //2
            MallParking one = new MallParking("ofer", 5);
            MallParking two = new MallParking("zhav", 10);
            MallParking three = new MallParking("idon'thave",12);
            MallParking four = new MallParking("anothername",15);

            MallParking[] allPark = { one, two, three, four };

            PetkMallParking parkingStations = new PetkMallParking(allPark);
            
            bool CheckForId()
            {
                for (int i = 0; i < defults.Length; i++)
                {
                    for (int j = 0; j < defults.Length; j++)
                    {
                        if (defults[i].getcarID() == defults[j].getcarID())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
            CheckForId();
        }
       
    }
}
