using System;

namespace _01_Kalkulator_C_
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Wybierz opcję z menu: \n" +
                    "1. Dodawanie\n" +
                    "2. Odejmowanie\n" +
                    "3. Mnożenie\n" +
                    "4. Dzielenie\n" +
                    "5. Potęgowanie\n" +
                    "6. Silnia\n" +
                    "7. Zamiana liczby na system binarny (dwójkowy)\n" +
                    "8. Zamiana liczby na system oktalny (ósemkowy)\n" +
                    "9. Zamiana liczby na system heksadecymalny (szesnastkowy)\n" +
                    "10. Wyjście z programu\n");

                int choice = 0;
                bool prawidloweDane;
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Proszę wybrać opcję. ({e.Message})");
                }

                switch (choice)
                {
                    case 1:
                        double x1 = 0;
                        double y1 = 0;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj pierwszą liczbę: ");
                                x1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Podaj drugą liczbę: ");
                                y1 = Convert.ToDouble(Console.ReadLine());
                                prawidloweDane = true;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Proszę wprowadzić prawidłową liczbę.");
                                //Console.WriteLine($"Błąd, proszę podać liczbę rzeczywistą. ({e.Message})");
                                prawidloweDane = false;
                                continue;
                            }
                        } while (!prawidloweDane);
                        Dodawanie suma = new Dodawanie(x1, y1);
                        Console.WriteLine($"{suma}");
                        break;
                    case 2:
                        double x2 = 0;
                        double y2 = 0;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj pierwszą liczbę: ");
                                x2 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Podaj drugą liczbę: ");
                                y2 = Convert.ToDouble(Console.ReadLine());
                                prawidloweDane = true;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Proszę wprowadzić prawidłową liczbę.");
                                //Console.WriteLine($"Błąd, proszę podać liczbę rzeczywistą. ({e.Message})");
                                prawidloweDane = false;
                                continue;
                            }
                        } while (!prawidloweDane);
                        Odejmowanie roznica = new Odejmowanie(x2, y2);
                        Console.WriteLine($"{roznica}");
                        break;
                    case 3:
                        double x3 = 0;
                        double y3 = 0;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj pierwszą liczbę: ");
                                x3 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Podaj drugą liczbę: ");
                                y3 = Convert.ToDouble(Console.ReadLine());
                                prawidloweDane = true;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Proszę wprowadzić prawidłową liczbę.");
                                //Console.WriteLine($"Błąd, proszę wpisać liczbę rzeczywistą. ({e.Message})");
                                prawidloweDane = false;
                                continue;
                            }
                        } while (!prawidloweDane);
                        Mnozenie iloczyn = new Mnozenie(x3, y3);
                        Console.WriteLine($"{iloczyn}");
                        break;
                    case 4:
                        double x4 = 0;
                        double y4 = 0;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj pierwszą liczbę: ");
                                x4 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Podaj drugą liczbę: ");
                                y4 = Convert.ToDouble(Console.ReadLine());
                                prawidloweDane = true;
                                if (y4 == 0)
                                {
                                    Console.WriteLine("Dzielenie przez 0 nie jest możliwe.");
                                    prawidloweDane = false;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Proszę wprowadzić prawidłową liczbę.");
                                //Console.WriteLine($"Błąd, proszę wpisać liczbę rzeczywistą. ({e.Message})");
                                prawidloweDane = false;
                                continue;
                            }
                        } while (!prawidloweDane);
                        Dzielenie iloraz = new Dzielenie(x4, y4);
                        Console.WriteLine($"{iloraz}");
                        break;
                    case 5:
                        long x5 = 0;
                        long y5 = 0;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj liczbę, którą chcesz spotęgować: ");
                                x5 = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Podaj potęgę: ");
                                y5 = Convert.ToInt64(Console.ReadLine());
                                prawidloweDane = true;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Proszę wprowadzić prawidłową liczbę.");
                                //Console.WriteLine($"Błąd, proszę wpisać liczbę całkowitą. ({e.Message})");
                                prawidloweDane = false;
                                continue;
                            }
                        } while (!prawidloweDane);
                        Potegowanie potega = new Potegowanie(x5, y5);
                        Console.WriteLine($"{potega}");
                        break;
                    case 6:
                        long x6 = 0;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj liczbę, z której będzie obliczona silnia: ");
                                x6 = Convert.ToInt64(Console.ReadLine());
                                prawidloweDane = true;
                                if (x6 < 0)
                                {
                                    Console.WriteLine("Wartość nie może być mniejsza niż 0.");
                                    prawidloweDane = false;
                                    continue;
                                }
                                else if (x6 == 0)
                                {
                                    Console.WriteLine("Silnia z 0 jest zawsze równa 1.");
                                    prawidloweDane = false;
                                    continue;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Proszę wprowadzić prawidłową liczbę.");
                                //Console.WriteLine($"Błąd, proszę wpisać liczbę całkowitą dodatnią. ({e.Message})");
                                prawidloweDane = false;
                                continue;
                            }
                        } while (!prawidloweDane);
                        Silnia factorial = new Silnia(x6);
                        Console.WriteLine($"{factorial}");
                        break;
                    case 7:
                        int x7 = 0;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj liczbę do zamiany na system dwójkowy: ");
                                x7 = Convert.ToInt32(Console.ReadLine());
                                prawidloweDane = true;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Proszę wprowadzić prawidłową liczbę.");
                                //Console.WriteLine($"Błąd, proszę wpisać liczbę całkowitą. ({e.Message})");
                                prawidloweDane = false;
                                continue;
                            }
                        } while (!prawidloweDane);
                        Dwojkowy naDwojkowy = new Dwojkowy(x7);
                        Console.WriteLine($"{naDwojkowy}");
                        break;
                    case 8:
                        int x8 = 0;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj liczbę do zamiany na system ósemkowy: ");
                                x8 = Convert.ToInt32(Console.ReadLine());
                                prawidloweDane = true;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Proszę wprowadzić prawidłową liczbę.");
                                //Console.WriteLine($"Błąd, proszę wpisać liczbę całkowitą. ({e.Message})");
                                prawidloweDane = false;
                                continue;
                            }
                        } while (!prawidloweDane);
                        Osemkowy naOsemkowy = new Osemkowy(x8);
                        Console.WriteLine($"{naOsemkowy}");
                        break;
                    case 9:
                        int x9 = 0;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Podaj liczbę do zamiany na system szesnastkowy: ");
                                x9 = Convert.ToInt32(Console.ReadLine());
                                prawidloweDane = true;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Proszę wprowadzić prawidłową liczbę.");
                                //Console.WriteLine($"Błąd, proszę wpisać liczbę całkowitą. ({e.Message})");
                                prawidloweDane = false;
                                continue;
                            }
                        } while (!prawidloweDane);
                        Szesnastkowy naSzesnastkowy = new Szesnastkowy(x9);
                        Console.WriteLine($"{naSzesnastkowy}");
                        break;
                    case 10:
                        Console.WriteLine("Program zostanie zamknięty. Naciśnij dowolny przycisk.");
                        Console.ReadKey();
                        return;
                }
            }
        }
    }
}