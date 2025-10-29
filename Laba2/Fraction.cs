public class Fraction
{
    private int Numerator { get; set; }
    private int Denominator { get; set; }

    public Fraction(int numerator, int denominator = 1)
    {
        if (denominator == 0)
            Console.WriteLine("• На ноль делить нельзя");

        Numerator = numerator;
        Denominator = denominator;
    }

    // Сложение с другой дробью
    public static Fraction operator +(Fraction a, Fraction b)
    {
        int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
        int denominator = a.Denominator * b.Denominator;
        return new Fraction(numerator, denominator);
    }

    // Вычитание с другой дробью
    public static Fraction operator -(Fraction a, Fraction b)
    {
        int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
        int denominator = a.Denominator * b.Denominator;
        return new Fraction(numerator, denominator);
    }

    // Умножение на другую дробь
    public static Fraction operator *(Fraction a, Fraction b)
    {
        int numerator = a.Numerator * b.Numerator;
        int denominator = a.Denominator * b.Denominator;
        return new Fraction(numerator, denominator);
    }

    // Деление на другую дробь
    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b.Numerator == 0)
            Console.WriteLine("• На ноль делить нельзя");

        int numerator = a.Numerator * b.Denominator;
        int denominator = a.Denominator * b.Numerator;
        return new Fraction(numerator, denominator);
    }


    // Сложение с целым числом
    public static Fraction operator +(Fraction a, int b)
    {
        return a + new Fraction(b);
    }

    // Вычитание с целым числом
    public static Fraction operator -(Fraction a, int b)
    {
        return a - new Fraction(b);
    }


    // Умножение на целым числом
    public static Fraction operator *(Fraction a, int b)
    {
        return a * new Fraction(b);
    }

    // Деление на целым числом
    public static Fraction operator /(Fraction a, int b)
    {
        if (b == 0)
            Console.WriteLine("• На ноль делить нельзя");

        return a / new Fraction(b);
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}