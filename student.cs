using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBO
{
   public class Student
    {
        private string name;
        private long contact;
        private string city;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public long Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }
        public Student(string sname,long scont,string scity)
        {
            this.name = sname;
            this.Contact = scont;
            this.city = scity;
        }
    }
}
