using System;

//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс с именем Address.
//В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого
//поля, создать свойство с двумя методами доступа.
//Создать экземпляр класса Address.
//В поля экземпляра записать информацию о почтовом адресе.
//Выведите на экран значения полей, описывающих адрес.


namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address ad = new Address();
            ad.Index = 210000;
            ad.Country = "Kazakhstan";
            ad.City = "Almaty";
            ad.Street = "Shevchenko";
            ad.House = 84;
            ad.Apartment = 52;

            Address ad1 = new Address(1231, "Czhech Republic", "Prague", "Massarykova", 32, 17);

            ad.getAll();
            ad1.getAll();

        }
    }
}
