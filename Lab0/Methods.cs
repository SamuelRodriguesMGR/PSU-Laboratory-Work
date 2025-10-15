
public class Method2
{
    public int sumLastNums(int x)
    {
        int n1 = x % 10;
        int n2 = x / 10 % 10;

        return n1 + n2;
    }
    
    public static void Launch()
    {
        Method2 proj = new Method2();
        Console.WriteLine(" > Введите число : ");
        Console.WriteLine("Сумма последних 2 цифр : " + proj.sumLastNums(int.Parse(Console.ReadLine())));
    }
}
 
public class Method4
{
    public bool isPositive(int x)
    {
        if (x >= 0)
        {
            return true;
            
        }
        else
            return false;
    }
    public static void Launch()
    {
        Method4 proj = new Method4();
        Console.WriteLine(" > Введите число : ");
        bool posit = proj.isPositive(int.Parse(Console.ReadLine()));
        Console.WriteLine(posit ? "положительно" : "отрицательно");
    }
}
 
public class Method6
{
    public bool isUpperCase(char x)
    {
        return x >= 'A' && x <= 'Z';
    }
    public static void Launch()
    {
        Method6 proj = new Method6();
        Console.WriteLine(" > Введите букву на англ : ");
        bool upper = proj.isUpperCase(char.Parse(Console.ReadLine()));
        Console.WriteLine(upper ? "Заглавная" : "Не заглавная");
    }
}

public class Method8
{
    public bool isDivisor(int a, int b)
    {
        return (a != 0 && b % a == 0) || (b != 0 && a % b == 0);
    }
    public static void Launch()
    {
        Method8 proj = new Method8();
        Console.WriteLine(" > Введите числа : ");
        Console.WriteLine(proj.isDivisor(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())) ? "Делятся" : "Не делятся");
    }
}

public class Method10
{
    public int lastNumSum(int a, int b)
    {
        return (a % 10) + (b % 10);
    }
    public static void Launch()
    {
        Method10 proj = new Method10();

        Console.WriteLine(" > Вводите числа : ");
        int result = 0;
        result = proj.lastNumSum(result, int.Parse(Console.ReadLine()));   
        result = proj.lastNumSum(result, int.Parse(Console.ReadLine()));  
        result = proj.lastNumSum(result, int.Parse(Console.ReadLine())); 
        result = proj.lastNumSum(result, int.Parse(Console.ReadLine()));  
        result = proj.lastNumSum(result, int.Parse(Console.ReadLine()));  

        Console.WriteLine("Итого : " + result); 
    }
}