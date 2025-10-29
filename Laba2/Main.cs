using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>\n>  ЗАДАНИЕ1. НОМЕР 2   <\n<<<<<<<<<<<<<<<<<");
            Console.WriteLine($"• {new Human("Клеопатра", 152)}");
            Console.WriteLine($"• {new Human("Пушкин", 167)}");
            Console.WriteLine($"• {new Human("Владимир", 189)}");

            // Console.WriteLine(">>>>>>>>>>>>>>>>>\n>   ЗАДАНИЕ1. НОМЕР 3   <\n<<<<<<<<<<<<<<<<<");
            // Console.WriteLine($"• {new Name("Клеопатра")}");
            // Console.WriteLine($"• {new Name("Пушкин", "Александр", "Сергеевич")}");
            // Console.WriteLine($"• {new Name("Маяковский", "Владимир")}");


            // Console.WriteLine(">>>>>>>>>>>>>>>>>\n>   ЗАДАНИЕ2 . НОМЕР 2   <\n<<<<<<<<<<<<<<<<<");
            // Console.WriteLine($"• {new Person(new Name("Клеопатра"), 152)}");
            // Console.WriteLine($"• {new Person(new Name("Пушкин", "Александр", "Сергеевич"), 167)}");
            // Console.WriteLine($"• {new Person(new Name("Маяковский", "Владимир"), 189)}");


            // Console.WriteLine(">>>>>>>>>>>>>>>>>\n>   ЗАДАНИЕ 3. НОМЕР 2   <\n<<<<<<<<<<<<<<<<<");
            // City cityA = new City("A");
            // City cityB = new City("B");
            // City cityC = new City("C");
            // City cityD = new City("D");
            // City cityE = new City("E");
            // City cityF = new City("F");

            // cityA.AddRoute(cityF, 1);
            // cityA.AddRoute(cityB, 5);
            // cityA.AddRoute(cityD, 6);

            // cityB.AddRoute(cityA, 5);
            // cityB.AddRoute(cityC, 3);

            // cityC.AddRoute(cityB, 3);
            // cityC.AddRoute(cityD, 4);

            // cityD.AddRoute(cityA, 6);
            // cityD.AddRoute(cityE, 2);
            // cityD.AddRoute(cityC, 4);

            // cityE.AddRoute(cityF, 2);

            // cityF.AddRoute(cityB, 1);
            // cityF.AddRoute(cityE, 2);

            // Console.WriteLine($"• {cityA}");
            // Console.WriteLine($"• {cityB}");
            // Console.WriteLine($"• {cityC}");
            // Console.WriteLine($"• {cityD}");
            // Console.WriteLine($"• {cityE}");
            // Console.WriteLine($"• {cityF}");

            
            // Console.WriteLine(">>>>>>>>>>>>>>>>>\n>   ЗАДАНИЕ 4. НОМЕР 2   <\n<<<<<<<<<<<<<<<<<");
            // UpdateCity updateCityA = new UpdateCity("A");
            // UpdateCity updateCityB = new UpdateCity("B");
            // UpdateCity updateCityC = new UpdateCity("C");
            // UpdateCity updateCityE = new UpdateCity("E");
            // UpdateCity updateCityD = new UpdateCity("D", new Dictionary<UpdateCity, int> { [updateCityA] = 6, [updateCityE] = 2,  [updateCityC] = 4 });
            // UpdateCity updateCityF = new UpdateCity("F", new Dictionary<UpdateCity, int> { [updateCityB] = 1, [updateCityE] = 2 });
            // UpdateCity updateCityG = new UpdateCity("G");

            // updateCityA.AddDictRoute(new Dictionary<UpdateCity, int> { [updateCityF] = 1, [updateCityB] = 5, [updateCityD] = 6 });
            // updateCityB.AddDictRoute(new Dictionary<UpdateCity, int> { [updateCityA] = 5, [updateCityC] = 3});
            // updateCityC.AddDictRoute(new Dictionary<UpdateCity, int> { [updateCityB] = 3, [updateCityD] = 4});
            // updateCityE.AddDictRoute(new Dictionary<UpdateCity, int> { [updateCityF] = 2 });

            // Console.WriteLine($"• {updateCityA}");
            // Console.WriteLine($"• {updateCityB}");
            // Console.WriteLine($"• {updateCityC}");
            // Console.WriteLine($"• {updateCityD}");
            // Console.WriteLine($"• {updateCityE}");
            // Console.WriteLine($"• {updateCityF}");
            // Console.WriteLine($"• {updateCityG}");


            // Console.WriteLine(">>>>>>>>>>>>>>>>>\n>   ЗАДАНИЕ 5. НОМЕР 2   <\n<<<<<<<<<<<<<<<<<");
            // Fraction fr1 = new Fraction(1, 2);
            // Fraction fr2 = new Fraction(4, 5);
            // Fraction fr3 = new Fraction(3, 7);
            // Fraction fr4 = new Fraction(8, 5);

            // Console.WriteLine($"{fr1} + {fr2} = {fr1 + fr2}");
            // Console.WriteLine($"{fr2} - {fr3} = {fr2 + fr3}");
            // Console.WriteLine($"{fr3} * {fr4} = {fr3 + fr4}");
            // Console.WriteLine($"{fr4} / {fr1} = {fr4 + fr1}");
            // Console.WriteLine($"{fr1} + {2} = {fr1 + 2}");
            // Console.WriteLine($"{fr1} - {1} = {fr1 + 1}");
            // Console.WriteLine($"{fr1} * {3} = {fr1 + 3}");
            // Console.WriteLine($"{fr1} / {4} = {fr1 + 4}");

            // Console.WriteLine($"{(fr1 + fr2) / fr3 - 5}");

        }
    }
}

