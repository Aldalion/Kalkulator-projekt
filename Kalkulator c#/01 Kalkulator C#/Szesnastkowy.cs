namespace _01_Kalkulator_C_
{
    internal class Szesnastkowy
    {
        public int a;
        public string konwersja;

        public Szesnastkowy(int a)
        {
            this.a = a;
            konwersja = a.ToString("X");

            //    while (a > 0)
            //    {
            //        if ((a % 16) <= 9)
            //        {
            //            konwersja = (a % 16) + konwersja;
            //        }
            //        else if ((a % 16) == 10)
            //        {
            //            konwersja += konwersja + "A";
            //        }
            //        else if ((a % 16) == 11)
            //        {
            //            konwersja += konwersja + "B";
            //        }
            //        else if ((a % 16) == 12)
            //        {
            //            konwersja += konwersja + "C";
            //        }
            //        else if ((a % 16) == 13)
            //        {
            //            konwersja += konwersja + "D";
            //        }
            //        else if ((a % 16) == 14)
            //        {
            //            konwersja += konwersja + "E";
            //        }
            //        else if ((a % 16) == 15)
            //        {
            //            konwersja += konwersja + "F";
            //        }
            //        a /= 16;
            //    }
        }
        public override string ToString() => $"Liczba {a} zapisana w systemie szesnastkowym to: {konwersja}";
    }
}

