namespace _01_Kalkulator_C_
{
    internal class Dzielenie
    {
        public double a, b;

        public Dzielenie(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Iloraz() => a / b;

        public override string ToString() => $"Iloraz {a} / {b} = {Iloraz()}";
    }
}
