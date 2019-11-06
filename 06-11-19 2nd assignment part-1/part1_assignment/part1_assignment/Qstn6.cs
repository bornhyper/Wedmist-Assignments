using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
     static class Qstn6
    {
        
        public  static void Answer()
        {
            Console.WriteLine("Question no 6. Write program, which reads two number (assume that both have same number of digits).");
            Console.WriteLine("The program outputs the sum of product of corresponding digits.Input 327 and 539 output 3x5+2x3+7x9= 84.");
            int num1, num2;
            String num1String, num2String;
            Console.WriteLine("\nenter two numbers :");
            num1String = Console.ReadLine();
            num2String = Console.ReadLine();
            num1 = Convert.ToInt32(num1String);
            num2 = Convert.ToInt32(num2String);
            int res=0;
            while (num1 != 0 || num2 !=0)
            {
                res = res+((num1 % 10) * (num2 % 10));
                num1 = num1 / 10;
                num2 = num2 / 10;
            }
            Console.WriteLine("Result is : {0}" ,res);
        }

    }
}
