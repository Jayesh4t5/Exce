using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exce
{
    public class Program
    {
        static void Main(string[] args)
        {

            Student stud = new Student();
            try
            {
                stud.AcceptDetails("", 17);
            }
            catch (NameException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Calculation c = new Calculation();
            int res1 = c.Sqaure(2)
            Console.WriteLine(res1);

        }
    }
}