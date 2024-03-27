using CommandForCursach.command;
using System;

namespace CommandForCursach
{
    class Program
    {
        static void Main(string[] args)
        {
            //PageNavigator navigator = new PageNavigator();

            //bool exit = false;
            //do
            //{
            //    Console.WriteLine("Available pages: home, cart, profile");
            //    Console.Write("Enter page title (or 'exit' to complete): ");
            //    string page = Console.ReadLine().ToLower();

            //    if (page == "exit")
            //    {
            //        exit = true;
            //    }
            //    else
            //    {
            //        navigator.ExecuteCommand(page);
            //    }

            //} while (!exit);

            //Console.WriteLine("Work completed.");
            //Console.ReadLine();

            Invoker invoker = new Invoker();
            bool exit = false;

            do
            {
                // Запрашиваем у пользователя выбор страницы
                Console.WriteLine("Select page to go to:");
                Console.WriteLine("1. Home page");
                Console.WriteLine("2. Cart page");
                Console.WriteLine("3. Personal page");
                Console.WriteLine("0. Go out");
                Console.Write("Enter page number: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        invoker.AddCommand(new HomePageCommand());
                        break;
                    case "2":
                        invoker.AddCommand(new CartPageCommand());
                        break;
                    case "3":
                        invoker.AddCommand(new ProfilePageCommand());
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect choice.");
                        break;
                }

                if (exit)
                    break;

                invoker.ExecuteCommands();

                invoker = new Invoker();

                Console.Write("Do you want to continue? (yes/no): ");
                string continueChoice = Console.ReadLine();
                exit = (continueChoice.ToLower() != "yes");
                Console.Clear();

            } while (!exit);

            Console.WriteLine("Work completed.");
            Console.ReadLine();
        }
    }
}
