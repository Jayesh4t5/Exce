using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exce
{
    public class NameException : Exception
    {
        public NameException(string message) : base(message)
        {

        }
    }

    public class Student
    {
        private string name;
        private int age;

        public void AcceptDetails(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameException("Name is Reqeuired");
            }
            else
            {
                this.name = name;
                this.age = age;
            }
         
        }
    }


}
