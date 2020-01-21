using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class Program
    {
        static void Main(string[] args)
        {
            //AMMAra
            //Composition b/wcashier and bill
            try
            
            {
                cashier c = new cashier();
                c.showbill();
            }
            catch (Exception)
            { }
            //IQRA
            //composition b/w bill nd customer
            coustomer c2 = new coustomer();
            c2.showDATA();
            //aggregation b/w search and bill
            search s2 = new search();
            bill b3 = new bill();
            b3.showUs(s2);

            //MAHNOOR

// aggregation between book and library
            book b = new book();
            library L = new library();
            L.show(b);
           // agrregation b/w bill nd search
            bill b2 = new bill();
            search s = new search();
            s.showMe(b2);
            //


            Console.ReadKey();
        }
    }
}
