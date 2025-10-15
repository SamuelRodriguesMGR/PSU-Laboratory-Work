public class Cycle2
{
    public string reverseListNums(int x)
    {
        string result = "";

        for (int i = x; i >= 0; i--)
        {
            result += i;
            if (i > 0)
                result += " ";
        }

        return result;
    }

    public static void Launch()
    {
        Cycle2 proj = new Cycle2();
        Console.WriteLine("Введите число");
        Console.WriteLine(proj.reverseListNums(int.Parse(Console.ReadLine())));
    }
}

public class Cycle4
{
    public int pow(int x, int y)
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }

    public static void Launch()
    {
        Cycle4 proj = new Cycle4();
        Console.WriteLine("введите числа");
        Console.WriteLine(proj.pow(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
    }
}

public class Cycle6
{
    public bool equalNum(int x)
    {
        if (x < 10 && x > -10)
            return true;

        int lastDigit = Math.Abs(x % 10);
        int num = Math.Abs(x / 10);

        while (num > 0)
        {
            int currentDigit = num % 10;
            if (currentDigit != lastDigit)
                return false;
            num /= 10;
        }
        return true;
    }

    public static void Launch()
    {
        Cycle6 proj = new Cycle6();
        Console.WriteLine("Введите снова числы, ЖИВО!");
        Console.WriteLine(proj.equalNum(int.Parse(Console.ReadLine())));
    }
}
public class Cycle8
{
    public void leftTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }

    public static void Launch()
    {
        Cycle8 proj = new Cycle8();
        Console.WriteLine("Введите число, щас будет ёлочка");
        proj.leftTriangle(int.Parse(Console.ReadLine()));
    }
}

public class Cycle10
{
    public void guessGame()
    {
        Random random = new Random();
        int secretNumber = random.Next(0, 10);
        int attempts = 0;
        int userGuess;

        do
        {
            Console.WriteLine("Введите число от 0 до 9:");
            userGuess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (userGuess == secretNumber)
            {
                Console.WriteLine("Вы угадали!");
            }
            else
            {
                Console.WriteLine("Вы не угадали, введите число от 0 до 9:");
            }
        } while (userGuess != secretNumber);

        Console.WriteLine($"Вы отгадали число за {attempts} попытки");
    }

    public static void Launch()
    {
        Cycle10 proj = new Cycle10();
        proj.guessGame();
    }
}