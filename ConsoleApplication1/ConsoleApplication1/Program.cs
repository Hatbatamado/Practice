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
            ConsoleKeyInfo asd;
            do
            {
                Console.Clear();
                Console.Write("1. feladat: 1\n2. feladat: 2\n3. feladat: 3\n4. feladat: 4\n5. feladat: 5"+
                    "\n6. feladat: 6\n7. feladat: 7\na. feladat: a\nb. feladat: b\nc. feladat: c\nd. feladat: d");

                asd = Console.ReadKey();
                switch (asd.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Fel1();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        Fel2();
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Fel3();
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        Fel4();
                        break;
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        Fel5();
                        break;
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.D6:
                        Fel6();
                        break;
                    case ConsoleKey.NumPad7:
                    case ConsoleKey.D7:
                        Fel7();
                        break;
                    case ConsoleKey.A:
                        Fel8();
                        break;
                    case ConsoleKey.B:
                        Fel9();
                        break;
                    case ConsoleKey.C:
                        Fel10();
                        break;
                    case ConsoleKey.D:
                        Fel11();
                        break;
                    default:
                        break;
                }
            } while (asd.Key != ConsoleKey.Escape);
        }

        static void Fel1()
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
        }

        static void Fel2()
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
        }

        static void Fel3()
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
            Console.Write(" => " + -(p2y - py) + "x +" + (p2x - px) + "y = " + (-(p2y - py) * px +
                (p2x - px) * py+"\n\n"));
            Console.Write("x0: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y0: " + (-(p2y - py) * x - (-(p2y - py) * px + (p2x - px) * py)) / -
                (p2x - px));
            Console.ReadKey();
        }

        static void Fel4()
        {
            Console.Clear();
            Console.Write("Évszám: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 4 == 0 && x % 100 != 0)
                Console.Write("Szökőév");
            else
                Console.Write("Nem szökőév");
            Console.ReadKey();
        }

        static void Fel5()
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
        }

        static void Fel6()
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
        }

        static void Fel7()
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
        }

        static void Fel8()
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
        }

        static void Fel9()
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
        }

        #region Fel01()
        static void Fel10()
        {
            Console.Clear();
            int[] magassagok = Tomb_fel();
            //-------------------------------------------------
            Console.Write("Mérések:\n");
            for (int i = 0; i < magassagok.Length; i++)
                Console.Write(magassagok[i] + "   ");
            //-------------------------------------------------
            int magas = Tomb_max(magassagok);
            Console.Write("\n\nA(z) " + magas + ". indexnél található az első max, magassága: " + magassagok[magas]);
            //------------------------------------------------
            int maxdb = Tomb_maxdb(magassagok, magas);
            Console.Write("\nA max magasság " + maxdb + " alkalommal szerepel");
            //------------------------------------------------
            int szhossz = Tomb_szhossz(magassagok);
            Console.Write("\n\nA leghosszabb sziget hossza: " + szhossz);
            //------------------------------------------------
            bool szhossz_m = Tomb_szhossz_m(magassagok,magas);
            if (szhossz_m)
                Console.Write("\n rajta van");
            else
                Console.Write("\n nincs rajta");

            Console.ReadKey();
        }

        static int[] Tomb_fel()
        {
            int[] tomb = new int[10];
            Random R = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                if (R.Next(0, 11) <= 4)
                    tomb[i] = R.Next(1, 11);
                else
                    tomb[i] = 0;
            }
            return tomb;
        }

        static int Tomb_max(int[] tomb)
        {
            int max = 0;
            for (int i = 1; i < tomb.Length; i++)
                if (tomb[max] < tomb[i])
                    max = i;

            return max;
        }

        static int Tomb_maxdb(int[] tomb, int max)
        {
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
                if (tomb[i] == tomb[max])
                    db++;

            return db;
        }

        static int Tomb_szhossz(int[] tomb)
        {
            int hossz = 0;
            int seged = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] != 0)
                    hossz++;
                else
                {
                    if (hossz > seged)
                        seged = hossz;
                    hossz = 0;
                }
            }
            if (hossz > seged)
                seged = hossz;
            return seged;
        }

        static bool Tomb_szhossz_m(int[] tomb, int index)
        {
            int hossz = 0;
            int seged = 0;
            int seged2 = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] != 0)
                    hossz++;
                else if (tomb[i] == 0)
                {
                    if (hossz > seged)
                    {
                        seged = hossz;
                        seged2 = i - seged;
                    }                    
                    hossz = 0;
                }
            }
            if (hossz > seged)
            {
                seged = hossz;
                seged2 = tomb.Length - seged;
            }
            if (index >= seged2 && index <= (seged2 + seged))
                return true;
            else return false;
        }
        #endregion

        static void Fel11()
        {
            #region feladat
            //Egy játéktábla mezői kétféle módon vannak megjelölve (pl. 
            //* és -). Kezdetben minden mező azonos jelölésű (-), kivéve 
            //a játéktábla közepén lévő mező, valamint annak négy 
            //közvetlen szomszédja. 
            //A játék során a felhasználó megadja a játéktábla egy 
            //koordinátáját. A kiválasztott koordinátájú mező, illetve 
            //annak négy szomszédja az addigival ellentétes jelölésűre 
            //változik. 
            //A játék akkor ér véget, ha a felhasználó minden mezőt *-ra 
            //tudott változtatni. 
            //Készítse el a játszást lehetővé tevő programot!

            //A játéktábla aktuális állapotát egy kétdimenziós logikai 
            //tömbben tárolja el! 

            //Megvalósítandó metódusok: 
            //1. static void init(bool[,] game) 
            //A játéktábla kezdeti állapotát előállító metódus 
            //2. static string state(bool[,] game) 
            //A játéktábla aktuális állapotát string formában megadó 
            //metódus 
            //3. static void shoot(bool[,] game, int x, int y) 
            //Kiválasztott pontra „lövést” megvalósító metódus 
            //4. static bool isOver(bool[,] game) 
            //A metódus vizsgálja, hogy minden mező *-gá vált-e
            #endregion
            Console.Clear();
            bool[,] tomb = new bool[5, 5];
            init(tomb);
            int x, y;
            bool vege = false;

            do
            {
                Console.Clear();
                kiir(tomb);
                Console.Write("\nLövés:\nX: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y: ");
                y = Convert.ToInt32(Console.ReadLine());
                shoot(tomb, x, y);
                vege = isOver(tomb);
            } while (!vege);

            Console.ReadKey();
        }

        static void kiir(bool[,] game)
        {
            for (int i = 0; i < game.GetLength(1); i++)
            {
                for (int j = 0; j < game.GetLength(0); j++)
                    if (game[i, j] == true)
                        Console.Write("+ ");
                    else
                        Console.Write("- ");
                Console.Write("\n");
            }
        }

        static void init(bool[,] game)
        {
            int felx = game.GetLength(1) / 2;
            int fely = game.GetLength(0) / 2;

            game[felx, fely] = true;
            kiir(game);
        }

        static void shoot(bool[,] game, int x, int y)
        {
            if (x < game.GetLength(0) && y < game.GetLength(1))
                game[x, y] = !game[x, y];
            if ((y + 1) < game.GetLength(1))                   //jobbra
                game[x, y + 1] = !game[x, y + 1];
            if ((y - 1) >= 0 )                                  //balra
                game[x, y - 1] = !game[x, y - 1];
            if ((x + 1) < game.GetLength(0))                   //le
                game[x + 1, y] = !game[x + 1, y];
            if ((x - 1) >= 0)                                   //fel
                game[x - 1, y] = !game[x - 1, y];
        }

        static bool isOver(bool[,] game)
        {
            int db = 0;
            for (int i = 0; i < game.GetLength(1); i++)
                for (int j = 0; j < game.GetLength(0); j++)
                    if (game[i, j] == false)
                        db++;
            if (db == 0)
                return true;
            else return false;
        }
    }
}
