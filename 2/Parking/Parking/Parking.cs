using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Parking
    {
        int floor;
        int Capacity;
        int Current;
        string[] idArray;

        public Parking(int floor, int Capacity)
        {
            this.floor = floor;
            this.Capacity = Capacity;
            this.Current = 0;
            this.idArray = new string[Capacity];
        }

        private string[] addId(string id)
        {
            idArray[Capacity] = id;
            return idArray;
        }

        private bool removeId(string id)
        {
            for (int i = 0; i < idArray.Length; i++)
            {
                if (idArray[i] == id)
                {
                    idArray[i] = "";
                    return true;
                }
            }
            return false;
        }
        //get current
        public int getCurrent()
        {
            return Current;
        }
        //set current
        public void setCurrent(int current)
        {
            this.Current = current;
        }

        //getter cpacity
        public int getCapacity()
        {
            return Capacity;
        }

        public void setCapacity(int Capacity)
        {
            this.Capacity = Capacity;
        }
        
        //get car ID
        public string[] getcarID()
        {
            return idArray;
        }
    }
}
