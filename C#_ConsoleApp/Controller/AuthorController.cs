using System;
using C__ConsoleApp.Services;

namespace C__ConsoleApp.Controller
{
    public class AuthorController
    {
        private AuthorService authorService;
        public bool IsAuthorLoggedIn { get; private set; }

        public AuthorController(AuthorService authorService)
        {
            this.authorService = authorService;
        }

        public void RegisterAuthor()
        {
            Console.Write("Enter author name: ");
            string name = Console.ReadLine();
            Console.Write("Enter author surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter author age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter author email: ");
            string email = Console.ReadLine();
            Console.Write("Enter author password: ");
            string password = Console.ReadLine();

            authorService.RegisterAuthor(name, surname, age, email, password);
        }

        public void AuthorLogin()
        {
            Console.Write("Enter author email: ");
            string email = Console.ReadLine();
            Console.Write("Enter author password: ");
            string password = Console.ReadLine();

            IsAuthorLoggedIn = authorService.Login(email, password);
        }

        public void AuthorMenu()
        {
            while (true)
            {
                Console.WriteLine($"Author Menu - Welcome, {authorService.LoggedInAuthor.Name} {authorService.LoggedInAuthor.Surname}!");
                Console.WriteLine("1. Show Authors above 40");
                Console.WriteLine("2. Show All Authors");
                Console.WriteLine("3. Back to Main Menu");
                Console.Write("Choose an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        authorService.ShowAuthorsAbove40();
                        break;
                    case "2":
                        authorService.ShowAllAuthors();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
