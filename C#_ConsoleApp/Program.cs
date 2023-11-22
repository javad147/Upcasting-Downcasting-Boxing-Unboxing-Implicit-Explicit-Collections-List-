using System;
using C__ConsoleApp.Controller;
using C__ConsoleApp.Data;
using C__ConsoleApp.Services;

namespace C__ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataDbContext dataDbContext = new DataDbContext();
            AuthorService authorService = new AuthorService(dataDbContext);
            AuthorController authorController = new AuthorController(authorService);

            while (true)
            {
                Console.WriteLine("1. Register as Author");
                Console.WriteLine("2. Author Login");
                Console.WriteLine("3. Author Menu");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        authorController.RegisterAuthor();
                        break;
                    case "2":
                        authorController.AuthorLogin();
                        break;
                    case "3":
                        if (authorController.IsAuthorLoggedIn)
                        {
                            authorController.AuthorMenu();
                        }
                        else
                        {
                            Console.WriteLine("You need to login first.");
                        }
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
