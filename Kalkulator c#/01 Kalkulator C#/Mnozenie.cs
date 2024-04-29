namespace _01_Kalkulator_C_
{
    internal class Mnozenie
    {
        public double a, b;

        public Mnozenie(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Iloczyn() => a * b;

        public override string ToString() => $"Iloczyn {a} * {b} = {Iloczyn()}";
    }
}
