using System;

namespace Part2_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            String inputChoice;
            Console.WriteLine("-------------part-2 of assignment containing Questions 19 to 31---------------- \n");
            Console.Write("enter the serial number of question you want (0 to exit): ");
            inputChoice = Console.ReadLine();
            Console.WriteLine();
            choice = Convert.ToInt32(inputChoice);
            while (choice != 0)
            {
                switch (choice)
                {
                    case 19:
                        Qstn19.Answer();
                        break;
                    case 20:
                        Qstn20.Answer();
                        break;
                    case 21:
                        Qstn21.Answer();
                        break;
                     case 22:
                         Qstn22.Answer();
                         break;
                    case 23:
                        Qstn23.Answer();
                        break;
                    case 24:
                        Qstn24.Answer();
                        break;
                    case 25:
                        Qstn25.Answer();
                        break;
                    case 26:
                        Qstn26.Answer();
                        break;
                    case 27:
                        Qstn27.Answer();
                        break;
                    case 28:
                        Qstn28.Answer();
                        break;
                    case 29:
                        Qstn29.Answer();
                        break;
                    case 30:
                        Qstn30.Answer();
                        break;
                    case 31:
                        Qstn31.Answer();
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
