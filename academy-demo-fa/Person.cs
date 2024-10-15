using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        // This is the default constructor - if ones is not created C# creates on automatically 
        public Person(string name, int age) {
            Name = name;
            Age = age;
        }
        /*Wait! How come we can set the Name property? I thought it was private? 
         * Yes - and it still is - the class is accessing it, not the external 
         * calling code. The class itself has access to everything else inside 
         * it, the external calling code only has access to the public methods and public properties.
         */

        public string introduce()
        {
            return "Hello, my name is " + Name;
        }

        public string sayAge()
        {
            return "I am " + Age + " years old";
        }

        public void updateName(string name)
        {
            Name = name;
        }

        public void updateAge(int age) 
        {
            Age = age;
        }

        public void updateNameAndAge(string name, int age)
        {
            Name = name;
            Age = age;

        }

    }
}
