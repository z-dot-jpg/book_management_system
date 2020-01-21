using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
   class employee:person
    {
        protected string emp_designation;
        public string Emp_designation
        {
            get { return emp_designation; }
            set {emp_designation = value ;}
        }
      // default constructor
        public employee()
        { }

        
           //method
           public void save()
           {

           }
    }
}

