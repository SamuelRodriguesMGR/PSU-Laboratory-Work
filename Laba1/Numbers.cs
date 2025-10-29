public class Numbers
{
    public int sumLastNums(int x)
    {
        int n1 = x % 10;
        int n2 = x / 10 % 10;

        return n1 + n2;
    }

    public bool isPositive(int x)
    {
        if (x >= 0)
        {
            return true;

        }
        else
            return false;
    }

    public bool isUpperCase(char x)
    {
        return x >= 'A' && x <= 'Z';
    }

    public bool isDivisor(int a, int b)
    {
        return (a != 0 && b % a == 0) || (b != 0 && a % b == 0);
    }

    public int lastNumSum(int a, int b)
    {
        return (a % 10) + (b % 10);
    }


    public double safeDiv(int x, int y)
    {
        if (y == 0)
            return 0;
        return (double)x / y;
    }

    public string makeDecision(int x, int y)
    {
        if (x > y)
            return $"{x} > {y}";
        else if (x < y)
            return $"{x} < {y}";
        else
            return $"{x} == {y}";
    }

    public bool sum3(int x, int y, int z)
    {
        return x + y == z || x + z == y || y + z == x;
    }

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

    public int pow(int x, int y)
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }

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


    public int findLast(int[] arr, int x)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }

    public int[] add(int[] arr, int x, int pos)
    {
        int[] newArr = new int[arr.Length + 1];

        for (int i = 0; i < pos; i++)
            newArr[i] = arr[i];

        newArr[pos] = x;

        for (int i = pos; i < arr.Length; i++)
            newArr[i + 1] = arr[i];

        return newArr;
    }

    public void reverse(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
    }

    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
            result[i] = arr1[i];

        for (int i = 0; i < arr2.Length; i++)
            result[arr1.Length + i] = arr2[i];

        return result;
    }
    
    public int[] deleteNegative(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
                count++;
        }
        
        int[] result = new int[count];
        int index = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                result[index] = arr[i];
                index++;
            }
        }
        
        return result;
    }
}