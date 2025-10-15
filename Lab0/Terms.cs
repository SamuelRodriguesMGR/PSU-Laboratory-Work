public class Term2
{
    public double safeDiv(int x, int y)
    {
        if (y == 0)
            return 0;
        return (double)x / y;
    }
    public static void Launch()
    {
        Term2 proj = new Term2();
        Console.WriteLine("Введите делимое и делитель");
        Console.WriteLine(proj.safeDiv(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
    }
}

public class Term4
{
    public string makeDecision(int x, int y)
    {
        if (x > y)
            return $"{x} > {y}";
        else if (x < y)
            return $"{x} < {y}";
        else
            return $"{x} == {y}";
    }
    public static void Launch()
    {
        Term4 proj = new Term4();
        Console.WriteLine("Введите 1 и 2 число");
        Console.WriteLine(proj.makeDecision(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
    }
}

public class Term6
{
    public bool sum3(int x, int y, int z)
    {
        return x + y == z || x + z == y || y + z == x;
    }

    public static void Launch()
    {
        Term6 proj = new Term6();
        Console.WriteLine("Введите 1, 2 и 3 число");
        Console.WriteLine(proj.sum3(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
    }
}

public class Term8
{
    public string age(int x)
    {
        int lastDigit = x % 10;
        int lastTwoDigits = x % 100;
        
        if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
            return $"{x} лет";
        else if (lastDigit == 1)
            return $"{x} год";
        else if (lastDigit >= 2 && lastDigit <= 4)
            return $"{x} года";
        else
            return $"{x} лет";
    }

    public static void Launch()
    {
        Term8 proj = new Term8();
        Console.WriteLine("Введите год");
        Console.WriteLine(proj.age(int.Parse(Console.ReadLine())));
    }
}

public class Term10
{
    public void printDays(string x)
    {
        switch (x.ToLower())
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "вторник":
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "среда":
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "четверг":
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "пятница":
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "суббота":
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            default:
                Console.WriteLine("это не день недели");
                break;
        }
    }

    public static void Launch()
    {
        Term10 proj = new Term10();
        Console.WriteLine("Введите день недели (Не знаю, но ввод readline не работает)");
        proj.printDays(Console.ReadLine());
        proj.printDays("понедельник");
    }
}