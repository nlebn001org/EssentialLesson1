using System;

//Задание 4
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать классы Point и Figure.
//Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
//аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
//аргументов типа Point.
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
//стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
//многоугольника.
//Написать программу, которая выводит на экран название и периметр многоугольника.


namespace Lesson1Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point("p1", 1, 1);
            Point p2 = new Point("p2", 3, 1);
            Point p3 = new Point("p3", 20, 4);
            Point p4 = new Point("p4", -3, 5);
            Point p5 = new Point("p5", 3, 4);

            Figure triangle1 = new Figure(p1, p2, p3);
            Figure rectangle1 = new Figure(p1, p2, p3, p4);
            Figure pentagon1 = new Figure(p1, p2, p3, p4, p5);

            Console.WriteLine($"Figure name: {triangle1.FigureName}, Perimeter: {triangle1.Perimeter}");
            Console.WriteLine($"Figure name: {rectangle1.FigureName}, Perimeter: {rectangle1.Perimeter}");
            Console.WriteLine($"Figure name: {pentagon1.FigureName}, Perimeter: {pentagon1.Perimeter}");

        }
    }
}
