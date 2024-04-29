namespace _01_Kalkulator_C_
{
    internal class Dwojkowy
    {
        public int a;
        public string konwersja;

        public Dwojkowy(int a)
        {
            this.a = a;

            while (a > 0)
            {
                konwersja = (a % 2) + konwersja;
                a /= 2;
            }
        }

        public override string ToString() => $"Liczba {a} zapisana w systemie dwójkowym to: {konwersja}";
    }
}
