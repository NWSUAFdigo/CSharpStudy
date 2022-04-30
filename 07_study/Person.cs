using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_study
{
    public class Person
    {
        private int _id;
        private string _name;

        public int Id { get; set; }
        public string Name { get; set; }


        public virtual void SayHello()
        {
            Console.WriteLine("person sayHello");
        }
    }
}
