using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
   
        class cashier:person
        {    
            protected string qualification;
            public string Qualification
            {
                get { return qualification; }
                set { qualification = value; }
            }
            //default constructor
            public cashier()
            {

            }
           
        
            public void showbill()
            { 
                bill b = new bill();
               
                b.quantity = Convert.ToInt32(Console.ReadLine());
                b.Bill_no = Convert.ToInt32(Console.ReadLine());
            }   
            public void add()
            {

            }
        }
            
        }
 

