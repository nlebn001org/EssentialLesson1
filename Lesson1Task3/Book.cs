using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Task3
{
    class Book
    {
        public Book()
        {

        }

        public Book(Author author, Title title, Content content)
        {
            author.Show();
            title.Show();
            content.Show();
            Console.ResetColor();
        }
        
    }
}
