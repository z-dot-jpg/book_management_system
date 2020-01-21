using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class person
    {
        
        protected string name;
        protected  string address;
       protected double phone_no;
        protected double salary;
        protected string gender;
        protected double cnic;
        protected string experience;
        protected string hire_date;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double Phone_no
        {
            get { return phone_no; }
            set { phone_no = value; }
        }
        public  double Salary
        {
            get { return salary; }
            set { salary = value; }

        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public  double Cnic
        {
            get { return cnic; }
            set { cnic = value; }
        }
        public string Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        public string Hire_date
        {
            get { return hire_date; }
            set { hire_date = value; }
        }
//default constructor
        public person()
        {

        }
       

    }
}
