﻿namespace C__ConsoleApp.Models
{
    public class Author : BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
