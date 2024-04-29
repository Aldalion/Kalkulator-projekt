namespace _01_Kalkulator_C_
{
    internal class Silnia
    {
        public double a;

        public Silnia(double a)
        {
            this.a = a;
        }

        public double WynikSilnia()
        {
            double wynik = 1;
            for (double i = a; i > 1; i--)
            {
                wynik *= i;
            }
            return wynik;
        }

        public override string ToString() => $"Silnia {a}! = {WynikSilnia()}";
    }
}
