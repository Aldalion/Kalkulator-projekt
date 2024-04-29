using System;

namespace _01_Kalkulator_C_
{
    internal class Potegowanie
    {
        public long a, b;

        public Potegowanie(long a, long b)
        {
            this.a = a;
            this.b = b;
        }

        public double Potega() => Math.Pow(a, b);

        public override string ToString() => $"Potęga {a} ^ {b} = {Potega()}";
    }
}
