using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPersonage
{
    class Person
    {
        public string name;
        public string surname;
        public int age;

        public Person()
        {
            name = "Tom";
            surname = "Johnson";
            age = 18;
        }
        public Person(string _name, string _surname, int _age)
        {
            name = _name;
            surname = _surname;
            age = _age;
        }

        public override string ToString()
        {
            return $"Name {name} Surname {surname} Age {age}";
        }


    }
    
}
