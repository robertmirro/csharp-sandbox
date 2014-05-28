using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OverloadOperator
{
    static void Main(string[] args)
    {
        Rational r1 = new Rational(3, 2);
        Rational r2 = new Rational(2, 3);

        Rational result = null;

        // Testing + operator on types
        result = r1 + r2;        
        //Console.WriteLine("result: {0}/{1}", result.Value);
        //Console.WriteLine("result: {0} / {1} = {2}", result.Numerator, result.Denominator, result.Value);
        Console.WriteLine("adding {0}/{1} + {2}/{3} = {4}/{5} = {6}", 
                r1.Numerator, 
                r1.Denominator, 
                r2.Numerator, 
                r2.Denominator,
                result.Numerator,
                result.Denominator,
                result.Value
                );
    }
}

class Rational
{
    // Private vairables to hold the data
    int numerator;
    int denominator;

    // Constructor
    public Rational(int num, int den)
    {
        numerator = num;
        denominator = den;
    }

    public int Numerator
    {
        get { return numerator; }
    }

    public int Denominator 
    {
        get { return denominator; }
    }

    public double Value
    {
        get
        {
            return ((double)numerator) / denominator;
        }
    }
    
    // Let us overload the Binary operators                
    public static Rational operator +(Rational rational1, Rational rational2)
    {
        int resultingDenominator = rational1.denominator * rational2.denominator;
        int resultingNumerator = rational1.numerator * rational2.denominator +
            rational1.denominator * rational2.numerator;

        return new Rational(resultingNumerator, resultingDenominator);
    }
}