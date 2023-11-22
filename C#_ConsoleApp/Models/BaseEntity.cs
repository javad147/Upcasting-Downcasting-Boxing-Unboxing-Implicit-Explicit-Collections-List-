// BaseEntity.cs

namespace C__ConsoleApp.Models
{
    public class BaseEntity
    {
        private static int _idCounter = 0;

        public int Id { get; private set; }

        public BaseEntity()
        {
            Id = ++_idCounter;
        }
    }
}
