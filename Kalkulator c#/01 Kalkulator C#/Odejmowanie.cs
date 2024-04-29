namespace _01_Kalkulator_C_
{
    internal class Odejmowanie
    {
        public double a, b;

        public Odejmowanie(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Roznica() => a - b;

        public override string ToString() => $"Różnica {a} - {b} = {Roznica()}";
    }
}
