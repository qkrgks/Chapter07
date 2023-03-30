using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p253_ex1
{
    class Base
    {

        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }
        ~Base()
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }

        public void BaseMEthod()
        {

            Console.WriteLine($"{Name}.BaseMethod()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethod()");
        }
    
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        { 
        Console.WriteLine($"{Name}.Derived()");

        }

        ~Derived()
        { 
        Console.WriteLine($"{this.Name}.~Derived()");
        }

        public void DerivedMethod()
        {
            Console.WriteLine($"{Name}.DerivedMethod()");
        }

    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMEthod();

            Derived b = new Derived("b");
            b.BaseMEthod();
            b.DerivedMethod();

        }
    }
}
