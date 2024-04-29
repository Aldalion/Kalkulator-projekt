namespace _01_Kalkulator_C_
{
    internal class Dodawanie
    {
        public double a, b;

        public Dodawanie(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Suma() => a + b;

        public override string ToString() => $"Suma {a} + {b} = {Suma()}";
    }
}
