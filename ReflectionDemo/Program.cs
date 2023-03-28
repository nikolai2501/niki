using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            string name = Console.ReadLine();
             int age = int.Parse(Console.ReadLine());

            var createdObject = (IIntroductable)Activator.CreateInstance
                (Type.GetType("ReflectionDemo" + type));
            createdObject.SetName(Console.ReadLine());
            createdObject.SetAge(int.Parse(Console.ReadLine()));
            createdObject.IntroduceYourself();

        }
    }
}
