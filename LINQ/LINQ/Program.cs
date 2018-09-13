using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            SQLBox();
            Console.WriteLine("Нажмите Enter что бы увидеть методы");
            Console.ReadKey();
            CBox();
            Console.ReadKey();
        }

        private static List<Person> GetPerson()
        {
            return new List<Person>()
            {
                new Person(){ Name = "Andrey", Age = 24, City = "Kyiv" },
                new Person(){ Name = "Liza", Age = 18, City = "Moscow" },
                new Person(){ Name = "Oleg", Age = 15, City = "London" },
                new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },
                new Person(){ Name = "Sergey", Age = 32, City = "Kyiv" }
            };
        } 

        private static void CBox()
        {
            List<Person> person = GetPerson();

            var Year25 = person.Where(p => p.Age > 25);
                foreach (var item in Year25)
                {
                    Console.WriteLine(item.Name);
                }
            Console.WriteLine();

            var NonCity = person.Where(p => p.City != "Kyiv");
                foreach (var item in NonCity)
                {
                    Console.WriteLine(item.Name);
                }
            Console.WriteLine();

            var CityKyiv = person.Where(p => p.City == "Kyiv");
                foreach (var item in CityKyiv)
                {
                    Console.WriteLine(item.Name);
                }
            Console.WriteLine();

            var Year35 = person.Where(p => p.Age > 35).Where(p => p.Name == "Sergey");
                foreach (var item in Year35)
                {
                    Console.WriteLine(item.Name);
                }
            Console.WriteLine();

            var CityMoscow = person.Where(p => p.City == "Moscow");
                foreach (var item in CityMoscow)
                {
                    Console.WriteLine(item.Name);
                }
        }

        private static void SQLBox()
        {
            List<Person> person = GetPerson();

            var Year25Sql = from p in person where p.Age > 25 select p;
                foreach (var item in Year25Sql)
                {
                    Console.WriteLine(item.Name);
                }
            Console.WriteLine();

            var NonCitySql = from p in person where p.City != "Kyiv" select p;
                foreach (var item in NonCitySql)
                {
                    Console.WriteLine(item.Name);
                }
            Console.WriteLine();

            var CityKyivSql = from p in person where p.City == "Kyiv" select p;
                foreach (var item in CityKyivSql)
                {
                    Console.WriteLine(item.Name);
                }
            Console.WriteLine();

            var Year35Sql = from p in person where p.Age > 35 && p.Name == "Sergey" select p;
                foreach (var item in Year35Sql)
                {
                    Console.WriteLine(item.Name);
                }
            Console.WriteLine();

            var CityMoscowSql = from p in person where p.City == "Moscow" select p;
                foreach (var item in CityMoscowSql)
                {
                    Console.WriteLine(item.Name);
                }
            Console.WriteLine();
        }

       
    }
}
