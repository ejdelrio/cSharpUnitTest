using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Person
    {
        public string name;
        int age;
        
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int getAge()
        {
            return age;
        }
        
        public void AgeOneYear()
        {
            age++;
        }
    }
}
