using System;

namespace Lesson1Task3
{
    class Title
    {
        public Title()
        {
        }

        public Title(string text)
        {
            Text = text;
        }

        public string Text { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Title is: {Text}");
        }

    }
}
