using System;

namespace part1_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            String inputChoice;
            Console.WriteLine("-------------part-1 of assignment containing 18 Questions---------------- \n");
            Console.Write("enter the serial number of question you want (0 to exit): ");
            inputChoice= Console.ReadLine();
            Console.WriteLine();
            choice = Convert.ToInt32(inputChoice);
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        Qstn1.Answer();
                        break;
                    case 2:
                        Qstn2.Answer();
                        break;
                    case 3:
                        Qstn3.Answer();
                        break;
                    case 4:
                        Qstn4.Answer();
                        break;
                    case 5:
                        Qstn5.Answer();
                        break;
                    case 6:
                        Qstn6.Answer();
                        break;
                    case 7:
                        Qstn7.Answer();
                        break;
                    case 8:
                        Qstn8.Answer();
                        break;
                    case 9:
                        Qstn9.Answer();
                        break;
                    case 10:
                        Qstn10.Answer();
                        break;
                    case 11:
                        Qstn11.Answer();
                        break;
                    case 12:
                        Qstn12.Answer();
                        break;
                    case 13:
                        Qstn13.Answer();
                        break;
                    case 14:
                        Qstn14.Answer();
                        break;
                    case 15:
                        Qstn15.Answer();
                        break;
                    case 16:
                        Qstn16.Answer();
                        break;
                    case 17:
                        Qstn17.Answer();
                        break;
                    case 18:
                        Qstn18.Answer();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.Write("\n\nenter the serial number of question you want (0 to exit): ");
                inputChoice = Console.ReadLine();
                Console.WriteLine();
                choice = Convert.ToInt32(inputChoice);
            }       
        }
    }
}
