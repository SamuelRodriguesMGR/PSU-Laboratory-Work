using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine($"• {new Human("Клеопатра", 152)}");
            // Console.WriteLine($"• {new Human("Пушкин", 167)}");
            // Console.WriteLine($"• {new Human("Владимир", 189)}");

            // Console.WriteLine($"• {new Name("Клеопатра")}");
            // Console.WriteLine($"• {new Name("Пушкин", "Александр", "Сергеевич")}");
            // Console.WriteLine($"• {new Name("Маяковский", "Владимир")}");

            // Console.WriteLine($"• {new Person(new Name("Клеопатра"), 152)}");
            // Console.WriteLine($"• {new Person(new Name("Пушкин", "Александр", "Сергеевич"), 167)}");
            // Console.WriteLine($"• {new Person(new Name("Маяковский", "Владимир"), 189)}");

            // Console.WriteLine($"• {new City("A", ["F", "B", "D"], [1, 5, 6])}");
            // Console.WriteLine($"• {new City("B", ["A", "C"], [5, 3])}");
            // Console.WriteLine($"• {new City("C", ["B", "D"], [3, 4])}");
            // Console.WriteLine($"• {new City("D", ["A", "E", "C"], [6, 2, 4])}");
            // Console.WriteLine($"• {new City("E", ["F"], [2])}");
            // Console.WriteLine($"• {new City("F", ["B", "E"], [1, 2])}");

            // Console.WriteLine($"• {new CityUpdate("F")}");

            Fraction fr1 = new Fraction(1, 2);
            Fraction fr2 = new Fraction(4, 5);
            Fraction fr3 = new Fraction(3, 7);
            Fraction fr4 = new Fraction(8, 5);

            Console.WriteLine($"{fr1} + {fr2} = {fr1 + fr2}");
            Console.WriteLine($"{fr2} - {fr3} = {fr2 + fr3}");
            Console.WriteLine($"{fr3} * {fr4} = {fr3 + fr4}");
            Console.WriteLine($"{fr4} / {fr1} = {fr4 + fr1}");
            Console.WriteLine($"{fr1} + {2} = {fr1 + 2}");
            Console.WriteLine($"{fr1} - {1} = {fr1 + 1}");
            Console.WriteLine($"{fr1} * {3} = {fr1 + 3}");
            Console.WriteLine($"{fr1} / {4} = {fr1 + 4}");

            Console.WriteLine($"{(fr1 + fr2) / fr3 - 5}");

        }
    }
}

