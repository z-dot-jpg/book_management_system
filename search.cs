using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class search
    
    {
        protected bill srch;
        public bill Srch
        {
            get {return srch ; }
            set {srch=value ;}
        }
        public search()
        {

        }
        public void showMe(bill srch) 
        {
            this.srch=srch;
        }


        

    }
}
