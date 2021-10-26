using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Task3
{
    class Content
    {
        public Content()
        {
        }

        public Content(string text)
        {
            Text = text;
        }

        public string Text { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Content is: {Text}");
        }

    }
}
