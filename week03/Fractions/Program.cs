using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        string fractionString1 = fraction1.GetFractionString();
        double fractionDecimal1 = fraction1.GetDecimalValue();
        Console.WriteLine(fractionString1);
        Console.WriteLine(fractionDecimal1);

        Fraction fraction2 = new Fraction(5);
        string fractionString2 = fraction2.GetFractionString();
        double fractionDecimal2 = fraction2.GetDecimalValue();
        Console.WriteLine(fractionString2);
        Console.WriteLine(fractionDecimal2);

        Fraction fraction3 = new Fraction(3, 4);
        string fractionString3 = fraction3.GetFractionString();
        double fractionDecimal3 = fraction3.GetDecimalValue();
        Console.WriteLine(fractionString3);
        Console.WriteLine(fractionDecimal3);

        Fraction fraction4 = new Fraction(1, 3);
        string fractionString4 = fraction4.GetFractionString();
        double fractionDecimal4 = fraction4.GetDecimalValue();
        Console.WriteLine(fractionString4);
        Console.WriteLine(fractionDecimal4);
    }
}