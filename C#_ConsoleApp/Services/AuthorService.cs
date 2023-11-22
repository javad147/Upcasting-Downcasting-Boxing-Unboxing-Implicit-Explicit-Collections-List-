// AuthorService.cs
using System;
using System.Linq;
using C__ConsoleApp.Data;
using C__ConsoleApp.Models;

namespace C__ConsoleApp.Services
{
    public class AuthorService
    {
        private DataDbContext dbContext;
        public Author LoggedInAuthor { get; private set; }

        public AuthorService(DataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void RegisterAuthor(string name, string surname, int age, string email, string password)
        {
            var newAuthor = new Author { Name = name, Surname = surname, Age = age, Email = email, Password = password };
            dbContext.Authors.Add(newAuthor);
            Console.WriteLine($"Author registration successful! Author ID: {newAuthor.Id}");
        }

        public bool Login(string email, string password)
        {
            int attempts = 0;

            while (attempts < 3)
            {
                var author = dbContext.Authors.FirstOrDefault(a => a.Email == email && a.Password == password);

                if (author != null)
                {
                    LoggedInAuthor = author;
                    Console.WriteLine($"Welcome, {LoggedInAuthor.Name} {LoggedInAuthor.Surname}!");
                    return true;
                }

                Console.WriteLine($"Author login failed. {2 - attempts} attempts left.");
                attempts++;

                if (attempts < 3)
                {
                    Console.Write("Enter author password again: ");
                    password = Console.ReadLine();
                }
            }

            Console.WriteLine("Author login failed. Returning to the main menu.");
            return false;
        }

        public void ShowAuthorsAbove40()
        {
            var authorsAbove40 = dbContext.Authors.Where(a => a.Age > 40);

            Console.WriteLine("Authors above the age of 40:");

            foreach (var author in authorsAbove40)
            {
                Console.WriteLine($"{author.Id}: {author.Name} {author.Surname}");
            }
        }

        public void ShowAllAuthors()
        {
            Console.WriteLine("All Authors:");

            foreach (var author in dbContext.Authors)
            {
                Console.WriteLine($"{author.Id}: {author.Name} {author.Surname}");
            }
        }
    }
}
