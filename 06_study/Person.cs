using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_study
{
    public class Person
    {
        private int _id;
        private string _name;

        public int Id { get; set; }
        public string Name { get { return _name; } set { _name = value; } }

        public void sayHello()
        {
            Console.WriteLine("Person sayHello");
        }
    }
}
