using System;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс с именем Rectangle.

//В теле класса создать два поля, описывающие длины сторон double side1, side2.
//Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
//поля side1 и side2 инициализируются значениями аргументов.
//Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
//прямоугольника - double PerimeterCalculator().
//Создать два свойства double Area и double Perimeter с одним методом доступа get.
//Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
//на экран периметр и площадь.


namespace Lesson1Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(2, 4);

            Console.WriteLine($"Perimeter is: {rec.Perimeter}, Area is: {rec.Area}");
        }
    }
}
