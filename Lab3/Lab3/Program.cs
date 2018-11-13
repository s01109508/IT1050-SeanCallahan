using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*If-single selection statements are true or false statements.
             * Repetition statements rely on more than one variable to be true or false.
             * A repetition and if-single statement may both be true if only one variable
             exists. An if-single statement will be false if only one of the conditions are met,
             compared to a repetition statement.*/
            int speedLimit = 35;
            int speed = 42;
            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }
            Boolean isTrue = true;
            if (isTrue == true)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }
            double Fahrenheight;
            double Celsius;

            Console.Write("Enter Fahrenheight: ");
            Fahrenheight = Convert.ToDouble(Console.ReadLine());

            Celsius = (Fahrenheight - 32d) * 5d / 9d;

            Console.Write("Celsius is {0}", Celsius);

            int value1 = 1;

            while (value1 <= 11)
            while (value1 >=1)
            {
                value1 = 1 * value1;
            }

            int value2 = 5;

            while (value2 >=20)
            while (value2 <=60)
                    {
                    value2 = 5 * value2;
                    }

            int value3 = 2;

            while (value3 >=10)
            while (value3 <=20)
                {
                    value3 = 2 * value3;
                }
            
        }
    }
}
