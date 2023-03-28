using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public interface IIntroductable
    {
        string GetName();
        void SetName(string value);

        int GetAge();
        void SetAge(int value);
        void IntroduceYourself();
    }
}
