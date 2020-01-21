using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class library
    {

        protected book data;
        public book Data
        {
            get { return data; }
            set { data = value; }

        }
        public library()
        {

        }
        public void show(book data)
        {
            this.data = data;
        }

    }
}
