using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Person : IIntroductable
    {
        public Person();

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        private int age;

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            age = value;
        }

        public void IntroduceYourself()
        {
            throw new NotImplementedException();
        }
    }


    
}

namespace ReflectionDemo
{
    public void IntroduceYourself() => Console.WriteLine($"Hello I am a person. My name is "
        + "Name.I am years old");
}


        

