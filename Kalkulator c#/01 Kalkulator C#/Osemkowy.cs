namespace _01_Kalkulator_C_
{
    internal class Osemkowy
    {
        public int a;
        public string konwersja;

        public Osemkowy(int a)
        {
            this.a = a;

            while (a > 0)
            {
                konwersja = (a % 8) + konwersja;
                a /= 8;
            }
        }

        public override string ToString() => $"Liczba {a} zapisana w systemie ósemkowym to: {konwersja}";
    }
}
