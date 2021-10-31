using System;

namespace Lesson1Task3
{
    class Author
    {
        public Author()
        {
        }

        public Author(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Author is: {Name}");
        }

    }
}
