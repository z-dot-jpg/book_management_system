using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class book
    {
                protected int book_id;
        protected string book_name;
        protected int book_price;
        protected string book_author;

        public int Book_id
        {
            get { return book_id;}
            set {book_id=value ;}
        }
        public string Book_name
        {
            get {return book_name ;}
            set {book_name=value ;}
        }
        public int Book_price
        {
            get {return book_price ;}
            set {book_price=value ;}
        }
       
        public string Book_author
        {
            get { return book_author; }
            set { book_author = value; }
        }
        public book()
        {

        }
    }
}
