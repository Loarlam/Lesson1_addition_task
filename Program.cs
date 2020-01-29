/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс с именем Address. 
В теле класса требуется создать поля: index, country, city, street, house, apartment.  Для каждого поля, создать свойство с двумя методами доступа.  
Создать экземпляр класса Address.  
В поля экземпляра записать информацию о почтовом адресе.  
Выведите на экран значения полей, описывающих адрес. 
*/

using System;

namespace Addition_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 125009;
            address.House = 19;
            address.Apartment = 9;
            address.Country = "Russia";
            address.City = "Moscow";
            address.Street = "Tverskaya";
            Console.WriteLine("My index is {0}.\nMy house is {1}.\nMy apartment number is {2}.\nMy country is {3}.\nMy city is {4}.\nMy street is {5}.", address.Index, address.House, address.Apartment, address.Country, address.City, address.Street);
            Console.ReadKey();
        }
    }
}
