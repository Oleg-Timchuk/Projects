using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_APP
{
    class PersonBirthdayComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Birthday > y.Birthday)
            {
                return 1;
            }
            else if (x.Birthday < y.Birthday)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
