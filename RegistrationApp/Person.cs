using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;   

namespace RegistrationApp
{
    class Person : IComparer<Person>, IEnumerable<Person>
    {
        ObservableCollection<Person> listPersons = new ObservableCollection<Person>();

        public int ID { get; set; } = 0;

        public int Age { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string Number { get; set; }

        public DateTime Birthday { get; set; }

        public Person Current { get; }


        public Person()
        {
            ID++;
        }

        public Person(int Age, string Name)
        {
            this.Age = Age;

            this.Name = Name;

            ID++;
        }

        public Person(int Age, string Name, DateTime Birthday) : this(Age, Name)
        {
            this.Birthday = Birthday;
        }

        public Person(int Age, string Name, string SurName, DateTime Birthday) : this(Age, Name)
        {
            this.Birthday = Birthday;
            this.SurName = SurName;
            ID++;
        }

        public override string ToString()
        {
            return this.Name + " " + this.SurName + " " + this.Age + " " + this.Birthday;
        }

        public int Compare(Person x, Person y)
        {
            if (x.Age > y.Age)
            {
                return 1;
            }
            else if (x.Age < y.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return listPersons.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
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
    class PersonNameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.Length > y.Name.Length)
            {
                return 1;
            }
            else if (x.Name.Length < y.Name.Length)
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
