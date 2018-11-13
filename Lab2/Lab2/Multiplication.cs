using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        int number1;
        int number2;
        int product;

        Console.Write("Enter first integer: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second integer: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        product = number1 * number2;

        Console.Write("Product is {0}", product);

        Console.WriteLine("Hello World!", "From Sean");
        /*a. The Main is where execution begins in our C# Console Application.
         b. The difference between an integer type variable and a double or
         floating point variable is that an integer has to be a whole number.
         An integer can be even or odd. Double or floating point variables can be
         numbers between two integers, such as 5.75.
         c. Using a public and private method to keep users from entering bad
         values helps validate integers. This helps control and reduce errors.
         d. To read; Get accessor. To assign; Set accessor.
         e. A class is a template for objects. You can create munltiple instances
         within a class. These store a value within the individual variables.*/
    }
}