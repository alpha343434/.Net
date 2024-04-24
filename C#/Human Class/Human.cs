using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace human
{
    class Human
    {
        // member variable
        private string firstName;

        private string lastName;

        private string eyeColor;

        private int age = 0;

        // property
        public int Number { get; set; }

        public Human()
        {
            Console.WriteLine("constructer called, object created");
        }

        //parameterized constructer
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public string EyeColor
        {
            get
            {
                return eyeColor;
            }
            set
            {
                eyeColor = value;
            }
        }

        // changing a private variable
        public void setAge(int age)
        {
            if (age < 0)
            {
                throw new Exception("age should be equal or higher than 0");
            }
            this.age = age;
        }

        // accessing a private variable
        public int getAge()
        {
            return this.age;
        }
        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine("hi, I'm {0} {1} and {3} years old. My eye color is {2} ", firstName, lastName, eyeColor, age);
        }
    }
}
