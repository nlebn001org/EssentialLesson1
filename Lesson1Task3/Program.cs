using System;

//Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать
//одно строковое поле и метод void Show().
//Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
//Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
//содержание.


namespace Lesson1Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Author author1 = new Author("Levickiy");
            Title title1 = new Title("Stalker");
            Content content1 = new Content("Weapon chosing");

            Book book1 = new Book(author1, title1, content1);
            
        }
    }
}
