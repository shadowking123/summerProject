using System;

namespace school_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ofek itzhaki project

            //1
            Cookie one = new Cookie("CoffeTime", 52, true);
            Cookie two = new Cookie("CoffeTime", 14, false);
           
            //setting the calories to 41
            one.setcalories(41);
            
            //prints just to be sure(:
            Console.WriteLine(one.getCal());
            Console.WriteLine(one.intComare(two));
            Console.WriteLine(one.getName());

            /*
             * לא הצלחתי לעשות פה טבלה אז הסברתי
             * 
             * Cookie m1=new Cookie ("aviv",150,true);
                Cookie m2=new Cookie ("Israel",180,false);
                Cookie m3=new Cookie (m1);
                Cookie m4=new Cookie("angel",250);

            //True, m3 Calories (150, copy of m1) are smaller than m2 calories
            
                if (m3.Compare(m2)==1)
                  Console.WriteLine(m1.getName());
            //print aviv
            
                
            //m3 is a copy of m1 so it returns true
            if (m1==m3)

             Console.WriteLine("good luck");
             //print good luck
            
                m3.setcalories(m4.getcalories());//m3 Calories = m4 calories = 250
                
            //return false because 250 != 150
            
            if (m1.Compare(m3)==0)
                    Console.WriteLine("happy day");
             */


        }
    }
}
