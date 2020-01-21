using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class bill
    {      
        
        public int quantity;
        protected int bill_no;
        protected int date;
        public int item;
        protected float total_price;
        public int add;
    
       
        public int Bill_no
        {
            get { return bill_no; }
            set { bill_no = value; }

        }
        public int Date
        {
            get { return date; }
            set { date = value; }

        }
        public float Total_price
        {
            get { return total_price; }
            set { total_price = value; }

        }
        public search variable;
        public void showUs(search variable)
        {
            this.variable = variable;
        }
       
       public void add()
        {
           if(total_price==300 && quantity==3)
           {

               total_price = total_price * quantity;
           }
        }
    
       


    }
}
 