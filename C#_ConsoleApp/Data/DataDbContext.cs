// DataDbContext.cs
using System.Collections.Generic;
using C__ConsoleApp.Models;

namespace C__ConsoleApp.Data
{
    public class DataDbContext
    {
        public List<Author> Authors { get; set; }

        public DataDbContext()
        {
            Authors = new List<Author>();
        }
    }
}
