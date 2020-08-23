using System;
using System.Collections.Generic;
using System.Text;

namespace school_project
{
    class Cookie
    {
            string backeryName;
            int calories;
            bool isKosher;

            //פעולה בונה לעוגיה
        public Cookie(string backeryname, int cal, bool kosher)
        {
            backeryName = backeryname;
            calories = cal;
            isKosher = kosher;
        }
        //פעולה בונה לעוגיה כשרה
        public Cookie(string backeryname, int cal)
        {
            backeryName = backeryname;
            calories = cal;
        }

       //פעולה בונה מעתיקה לעוגיה כשרה
        public Cookie(Cookie one)
        {
            backeryName = one.backeryName;
            calories = one.calories;
            isKosher = one.isKosher;
        }

        public int intComare(Cookie m)
        {
            if (m.calories == this.calories)
            {
                return 0;
            }

            else if (m.calories > this.calories)
            {
                return 1;
            }
            return -1;
        }
        //getter backery name
            public string getName()
            {
                return backeryName;
            }
        //setter calories
            public void setcalories(int calories)
            {

                this.calories = calories;
            }
        //getter calories
            public int getCal()
            {
                return calories;
            }
    }

}

