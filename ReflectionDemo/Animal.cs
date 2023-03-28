using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Animal : IIntroductable
    {
        private string name;

        public Animal()
        {

        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public string Age { get; set; }
        public void IntroduceYourself()
        {
            Console.WriteLine();
        }

        public int GetAge()
        {
            throw new NotImplementedException();
        }

        public void SetAge(int value)
        {
            throw new NotImplementedException();
        }
    }
}
