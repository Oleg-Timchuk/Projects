using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person client = new Client();
            ((Employee)client).FindWorker();
        }

    }
    class Person
    {
        public virtual void Foo()
        {
            Console.WriteLine("Class Person");
        }
    }
    class Employee : Person
    {
        public void FindWorker()
        {
            Console.WriteLine("Ищу работника");
        }
        public override void Foo()
        {
            Console.WriteLine("Class Employee");
        }
    }
    class Client : Employee
    {
        public void FindWork()
        {
            Console.WriteLine("Ищу работу!");
        }
        public override void Foo()
        {
            Console.WriteLine("Class Client");
        }
    }

}

