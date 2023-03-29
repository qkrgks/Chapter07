using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p240_ex1
{

    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }


    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Piih");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            Employee tigger = new Employee();
            pooh.SetName("Tigger");
            pooh.SetPosition("Cleaner");
            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

        }
    }
}
