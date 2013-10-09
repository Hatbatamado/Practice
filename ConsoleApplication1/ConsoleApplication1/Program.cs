using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ujra = false;
            ConsoleKeyInfo asd;
            do
            {
                Console.Clear();
                Console.Write("1. feladat: 1");
                Console.Write("\n2. feladat: 2");
                Console.Write("\n3. feladat: 3");
                Console.Write("\n4. feladat: 4");
                Console.Write("\n5. feladat: 5");
                Console.Write("\n6. feladat: 6");
                Console.Write("\n7. feladat: 7");
                Console.Write("\na. feladat: a");
                Console.Write("\nb. feladat: b");

                asd = Console.ReadKey();
                switch (asd.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        ujra = Fel1();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        ujra = Fel2();
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        ujra = Fel3();
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        ujra = Fel4();
                        break;
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        ujra = Fel5();
                        break;
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.D6:
                        ujra = Fel6();
                        break;
                    case ConsoleKey.NumPad7:
                    case ConsoleKey.D7:
                        ujra = Fel7();
                        break;
                    case ConsoleKey.A:
                        ujra = Fel8();
                        break;
                    case ConsoleKey.B:
                        ujra = Fel9();
                        break;
                    default:
                        ujra = true;
                        break;
                }
            } while (ujra && asd.Key != ConsoleKey.Escape);
        }

        static bool Fel1()
        {
            Console.Clear();
            Console.Write("Neved: ");
            string asd = Console.ReadLine();
            asd = asd.ToUpper();

            switch (asd)
            {
                case "BÉLA":
                    Console.Write("Szia!");
                    break;
                case "BILL":
                    Console.Write("A király!");
                    break;
                case "JOE":
                    Console.Write("Szevasz!");
                    break;
                case "MALDINI":
                    Console.Write("Ciao!");
                    break;
                default:
                    Console.Write("Hello!");
                    break;
            }
            Console.ReadKey();
            return true;
        }

        static bool Fel2()
        {
            Console.Clear();
            Console.Write("ax^2 + bx + c = 0\n");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(b * b - 4.0 * a * c)) / (2.0 * a);
                double x2 = (-b - Math.Sqrt(b * b - 4.0 * a * c)) / (2.0 * a);
                Console.Write("\n2 megoldás: x1= " + x1 + ", x2 = " + x2);
            }
            else if (D == 0)
            {
                double x1 = -b / (2.0 * a);
                Console.Write("\n1 megoldás: " + x1);
            }
            else if (D < 0)
                Console.Write("\nNincs valós megoldás");
            Console.ReadKey();
            return true;
        }

        static bool Fel3()
        {
            Console.Clear();
            //---------------------------------P1 pont
            Console.Write("P1(x: ");
            double px = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("P1(x: " + px + ", y: ");
            double py = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("P1(x: " + px + ", y: " + py + ")\n");
            //---------------------------------P1 pont vége
            //---------------------------------P2 pont
            Console.Write("P2(x: ");
            double p2x = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("P1(x: " + px + ", y: " + py + ")\nP2(x: " + p2x + ", y: ");
            double p2y = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("P1(x: " + px + ", y: " + py + ")\nP2(x: " + p2x + ", y: " + p2y + ")\n");
            //---------------------------------P1 pont vége

            Console.Write("Irány vektor: v(" + (p2x - px) + ";" + (p2y - py) + ")\n");
            Console.Write("Normál vektor: n(" + -(p2y - py) + ";" + (p2x - px) + ")\n");
            Console.Write("Az egyenes egyenlete: " + -(p2y - py) + "x +" + (p2x - px) + "y = " +
                -(p2y - py) * px + " + " + (p2x - px) * py);
            Console.Write(" => " + -(p2y - py) + "x +" + (p2x - px) + "y = " + (-(p2y - py) * px + (p2x - px) * py+"\n\n"));
            Console.Write("x0: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y0: " + (-(p2y - py) * x - (-(p2y - py) * px + (p2x - px) * py)) / -(p2x - px));
            Console.ReadKey();
            return true;
        }

        static bool Fel4()
        {
            Console.Clear();
            Console.Write("Évszám: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 4 == 0 && x % 100 != 0)
                Console.Write("Szökőév");
            else
                Console.Write("Nem szökőév");
            Console.ReadKey();
            return true;
        }

        static bool Fel5()
        {
            Console.Clear();
            Console.Write("Év: ");
            int ev = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Év: " + ev + " hónap: ");
            int honap = Convert.ToInt32(Console.ReadLine());
            
            int nap = 0;
            if (honap >= 8)
                honap++;
            if (honap == 2)
                if (ev % 4 == 0 && ev % 100 != 0)
                    nap = 29;
                else
                    nap = 28;
            else if (honap % 2 == 0)
                nap = 30;
            else nap = 31;
            if (honap >= 9)
                honap--;
            Console.Write("A " + honap + ". hónap " + nap + " napos.");

            Console.ReadKey();
            return true;
        }

        static bool Fel6()
        {
            Console.Clear();
            Console.Write("Szám: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int gyok = (int)Math.Sqrt(szam);
            int db = 0;
            if (szam >= 2)
            {
                for (int i = 1; i <= gyok; i++)
                    if (szam % i == 0)
                        db++;
                if (db == 1)
                    Console.Write("Prím");
                else
                    Console.Write("Nem prím");
            }
            else
                Console.Write("Nem prím");

            Console.ReadKey();
            return true;
        }

        static bool Fel7()
        {
            Console.Clear();
            Console.Write("1. nebuló: ");
            int neb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. nebuló: ");
            int neb2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. nebuló: ");
            int neb3 = Convert.ToInt32(Console.ReadLine());
            int osszeg = neb1 + neb2 + neb3;
            double atlag = osszeg / 3;
            Console.Write("Nebulók átlaga: " + atlag);
            Console.ReadKey();
            return true;
            
        }

        static bool Fel8()
        {
            Console.Clear();
            Console.Write("Osztály létszám: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] osztaly = new int[n];
            Random R = new Random();
            int ossz = 0;
            for (int i = 0; i < osztaly.Length; i++)
            {
                osztaly[i] = R.Next(1, 5);
                ossz = ossz + osztaly[i];
            }
            double atlag = ossz / osztaly.Length;
            Console.Write("Átlag: " + atlag);
            Console.ReadKey();
            return true;
        }

        static bool Fel9()
        {
            Console.Clear();
            Console.Write("Hány db betyű: ");
            int db = Convert.ToInt32(Console.ReadLine());
            Random R = new Random();
            string szoveg = "";
            for (int i = 0; i < db; i++)
            {
                int dec = R.Next(65, 90);
                string anyad = dec.ToString("X");
                int an = Convert.ToInt32(anyad, 16);
                char asd = (char)an;
                szoveg += asd;
            }
            Console.Write(szoveg);
            Console.ReadKey();
            return true;
        }
    }
}
