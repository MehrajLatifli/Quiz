using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Quiz
{
    class Program
    {

        static void Sual()
        {
            Suallar();

        }
        static void Suallar()
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int total = 0;
            int xal1 = 10;
            int xal2 = 10;
            int xal3 = 10;
            int xal4 = 10;
            int xal5 = 10;
            int xal6 = 10;
            int xal7 = 10;
            int xal8 = 10;
            int xal9 = 10;
            int xal10 = 10;


            // 1-ci sual;
            Console.WriteLine("\n Azərbaycanın paytaxtı hansı şəhərdir ? ");
            string[] variant1 = new string[] { "Bakı", "Tərtər", "Dərbənd", "Gəncə" };
            char[] char1 = new char[] { 'A', 'B', 'C', 'D' };

            Random r1 = new Random();
            int n = variant1.Length;



            Console.WriteLine("\n");


            while (n > 1)
            {
                n--;
                int k = r1.Next(n + 1);
                string value = variant1[k];
                variant1[k] = variant1[n];
                variant1[n] = value;
            }

            for (int i = 0; i < variant1.Length; i++)
            {
                Console.WriteLine(" {0}) {1} ", char1[0], variant1[0]);
                Console.WriteLine(" {0}) {1} ", char1[1], variant1[1]);
                Console.WriteLine(" {0}) {1} ", char1[2], variant1[2]);
                Console.WriteLine(" {0}) {1} ", char1[3], variant1[3]);
                break;
            }

            Console.Write("\n Cavabınızı daxil edin: ");

            char cavab1 = Convert.ToChar(Console.ReadLine());

            if (cavab1 == char1[0] && variant1[0] == "Bakı")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal1);
                total += xal1;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab1 == char1[0] && variant1[0] != "Bakı")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal1 - 10);
                total += xal1 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab1 == char1[1] && variant1[1] == "Bakı")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal1);
                total += xal1;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab1 == char1[1] && variant1[1] != "Bakı")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal1 - 10);
                total += xal1 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab1 == char1[2] && variant1[2] == "Bakı")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal1);
                total += xal1;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab1 == char1[2] && variant1[2] != "Bakı")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal1 - 10);
                total += xal1 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab1 == char1[3] && variant1[3] == "Bakı")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal1);
                total += xal1;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab1 == char1[3] && variant1[3] != "Bakı")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal1 - 10);
                total += xal1 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }




            // 2-ci sual;

            Console.WriteLine("\n Fillandiyanın paytaxtı hansı şəhərdir ? ");
            string[] variant2 = new string[] { "Bakı", "Oslo", "Helsinki", "Stockholm" };
            char[] char2 = new char[] { 'A', 'B', 'C', 'D' };

            Random r2 = new Random();
            int n2 = variant2.Length;



            Console.WriteLine("\n");


            while (n2 > 1)
            {
                n2--;
                int k2 = r2.Next(n2 + 1);
                string value2 = variant2[k2];
                variant2[k2] = variant2[n2];
                variant2[n2] = value2;
            }

            for (int i = 0; i < variant2.Length; i++)
            {
                Console.WriteLine(" {0}) {1} ", char2[0], variant2[0]);
                Console.WriteLine(" {0}) {1} ", char2[1], variant2[1]);
                Console.WriteLine(" {0}) {1} ", char2[2], variant2[2]);
                Console.WriteLine(" {0}) {1} ", char2[3], variant2[3]);
                break;
            }

            Console.Write("\n Cavabınızı daxil edin: ");

            char cavab2 = Convert.ToChar(Console.ReadLine());

            if (cavab2 == char2[0] && variant2[0] == "Helsinki")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal2);
                total += xal2;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab2 == char2[0] && variant2[0] != "Helsinki")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal2 - 10);
                total += xal2 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab2 == char2[1] && variant2[1] == "Helsinki")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal2);
                total += xal2;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab2 == char2[1] && variant2[1] != "Helsinki")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal2 - 10);
                total += xal2 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab2 == char2[2] && variant2[2] == "Helsinki")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal2);
                total += xal2;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab2 == char2[2] && variant2[2] != "Helsinki")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal2 - 10);
                total += xal2 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab2 == char2[3] && variant2[3] == "Helsinki")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal2);
                total += xal2;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab2 == char2[3] && variant2[3] != "Helsinki")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal2 - 10);
                total += xal2 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }



            // 3-ci sual;
            Console.WriteLine("\n Bunlardan hansı göldür ? ");
            string[] variant3 = new string[] { "Qara dəniz", "Aralıq dənizi", "Xəzər dənizi", "Şərqi Çin dənizi" };
            char[] char3 = new char[] { 'A', 'B', 'C', 'D' };

            Random r3 = new Random();
            int n3 = variant3.Length;



            Console.WriteLine("\n");


            while (n3 > 1)
            {
                n3--;
                int k3 = r3.Next(n3 + 1);
                string value3 = variant3[k3];
                variant3[k3] = variant3[n3];
                variant3[n3] = value3;
            }

            for (int i = 0; i < variant3.Length; i++)
            {
                Console.WriteLine(" {0}) {1} ", char3[0], variant3[0]);
                Console.WriteLine(" {0}) {1} ", char3[1], variant3[1]);
                Console.WriteLine(" {0}) {1} ", char3[2], variant3[2]);
                Console.WriteLine(" {0}) {1} ", char3[3], variant3[3]);
                break;
            }

            Console.Write("\n Cavabınızı daxil edin: ");

            char cavab3 = Convert.ToChar(Console.ReadLine());

            if (cavab3 == char3[0] && variant3[0] == "Xəzər dənizi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal3);
                total += xal3;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab3 == char3[0] && variant3[0] != "Xəzər dənizi")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal3 - 10);
                total += xal3 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab3 == char3[1] && variant3[1] == "Xəzər dənizi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal3);
                total += xal3;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab3 == char3[1] && variant3[1] != "Xəzər dənizi")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal3 - 10);
                total += xal3 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab3 == char3[2] && variant3[2] == "Xəzər dənizi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal3);
                total += xal3;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab3 == char3[2] && variant3[2] != "Xəzər dənizi")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal3 - 10);
                total += xal3 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab3 == char3[3] && variant3[3] == "Xəzər dənizi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal3);
                total += xal3;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab3 == char3[3] && variant3[3] != "Xəzər dənizi")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal3 - 10);
                total += xal3 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }



            // 4-ci sual;
            Console.WriteLine("\n Bunlardan hansı proqramlaşdırma dili deyil ? ");
            string[] variant4 = new string[] { "C++", "C#", "Erlang", "F++" };
            char[] char4 = new char[] { 'A', 'B', 'C', 'D' };

            Random r4 = new Random();
            int n4 = variant4.Length;



            Console.WriteLine("\n");


            while (n4 > 1)
            {
                n4--;
                int k4 = r4.Next(n4 + 1);
                string value4 = variant4[k4];
                variant4[k4] = variant4[n4];
                variant4[n4] = value4;
            }

            for (int i = 0; i < variant4.Length; i++)
            {
                Console.WriteLine(" {0}) {1} ", char4[0], variant4[0]);
                Console.WriteLine(" {0}) {1} ", char4[1], variant4[1]);
                Console.WriteLine(" {0}) {1} ", char4[2], variant4[2]);
                Console.WriteLine(" {0}) {1} ", char4[3], variant4[3]);
                break;
            }

            Console.Write("\n Cavabınızı daxil edin: ");

            char cavab4 = Convert.ToChar(Console.ReadLine());

            if (cavab4 == char4[0] && variant4[0] == "F++")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal4);
                total += xal4;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab4 == char4[0] && variant4[0] != "F++")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal4 - 10);
                total += xal4 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab4 == char4[1] && variant4[1] == "F++")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal4);
                total += xal4;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab4 == char4[1] && variant4[1] != "F++")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal4 - 10);
                total += xal4 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab4 == char4[2] && variant4[2] == "F++")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal4);
                total += xal4;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab4 == char4[2] && variant4[2] != "F++")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal4 - 10);
                total += xal4 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab4 == char4[3] && variant4[3] == "F++")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal4);
                total += xal4;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab4 == char4[3] && variant4[3] != "F++")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal4 - 10);
                total += xal4 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }



            // 5-ci sual;
            Console.WriteLine("\n Azərbaycan-türk ordusu Bakını nə vaxt düşməndən azad etdi ? ");
            string[] variant5 = new string[] { "1918-ci il sentyabrın 15-də", "1920-ci il sentyabrın 15-də", "1991-ci il sentyabrın 15-də", "1998-ci il sentyabrın 15-də" };
            char[] char5 = new char[] { 'A', 'B', 'C', 'D' };

            Random r5 = new Random();
            int n5 = variant5.Length;



            Console.WriteLine("\n");


            while (n5 > 1)
            {
                n5--;
                int k5 = r5.Next(n5 + 1);
                string value5 = variant5[k5];
                variant5[k5] = variant5[n5];
                variant5[n5] = value5;
            }

            for (int i = 0; i < variant5.Length; i++)
            {
                Console.WriteLine(" {0}) {1} ", char5[0], variant5[0]);
                Console.WriteLine(" {0}) {1} ", char5[1], variant5[1]);
                Console.WriteLine(" {0}) {1} ", char5[2], variant5[2]);
                Console.WriteLine(" {0}) {1} ", char5[3], variant5[3]);
                break;
            }

            Console.Write("\n Cavabınızı daxil edin: ");

            char cavab5 = Convert.ToChar(Console.ReadLine());

            if (cavab5 == char5[0] && variant5[0] == "1918-ci il sentyabrın 15-də")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal5);
                total += xal5;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab5 == char5[0] && variant5[0] != "1918-ci il sentyabrın 15-də")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal5 - 10);
                total += xal5 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab5 == char5[1] && variant5[1] == "1918-ci il sentyabrın 15-də")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal5);
                total += xal5;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab5 == char5[1] && variant5[1] != "1918-ci il sentyabrın 15-də")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal5 - 10);
                total += xal5 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab5 == char5[2] && variant5[2] == "1918-ci il sentyabrın 15-də")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal5);
                total += xal5;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab5 == char5[2] && variant5[2] != "1918-ci il sentyabrın 15-də")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal5 - 10);
                total += xal5 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab5 == char5[3] && variant5[3] == "1918-ci il sentyabrın 15-də")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal5);
                total += xal5;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab5 == char5[3] && variant5[3] != "1918-ci il sentyabrın 15-də")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal5 - 10);
                total += xal5 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            // 6-ci sual;
            Console.WriteLine("\n İnternetə qoşulmaq üçün hansı qurğudan istifadə edilir ? ");
            string[] variant6 = new string[] { "Modem", "Monitor", "Skaner", "UPS" };
            char[] char6 = new char[] { 'A', 'B', 'C', 'D' };

            Random r6 = new Random();
            int n6 = variant6.Length;



            Console.WriteLine("\n");


            while (n6 > 1)
            {
                n6--;
                int k6 = r6.Next(n6 + 1);
                string value6 = variant6[k6];
                variant6[k6] = variant6[n6];
                variant6[n6] = value6;
            }

            for (int i = 0; i < variant6.Length; i++)
            {
                Console.WriteLine(" {0}) {1} ", char6[0], variant6[0]);
                Console.WriteLine(" {0}) {1} ", char6[1], variant6[1]);
                Console.WriteLine(" {0}) {1} ", char6[2], variant6[2]);
                Console.WriteLine(" {0}) {1} ", char6[3], variant6[3]);
                break;
            }

            Console.Write("\n Cavabınızı daxil edin: ");

            char cavab6 = Convert.ToChar(Console.ReadLine());

            if (cavab6 == char6[0] && variant6[0] == "Modem")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal6);
                total += xal6;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab6 == char6[0] && variant6[0] != "Modem")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal6 - 10);
                total += xal6 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab6 == char6[1] && variant6[1] == "Modem")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal6);
                total += xal6;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab6 == char6[1] && variant6[1] != "Modem")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal6 - 10);
                total += xal6 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab6 == char6[2] && variant6[2] == "Modem")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal6);
                total += xal6;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab6 == char6[2] && variant6[2] != "Modem")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal6 - 10);
                total += xal6 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab6 == char6[3] && variant6[3] == "Modem")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal6);
                total += xal6;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab6 == char6[3] && variant6[3] != "Modem")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal6 - 10);
                total += xal6 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }



            // 7-ci sual;
            Console.WriteLine("\n Bu üslubda beynəlmiləl səciyyə daşıyan sözlər çox işlənir. Söhbət hansı üslubdan gedir ? ");
            string[] variant7 = new string[] { "Bədii", "Elmi", "Rəsmi", "Publisistik" };
            char[] char7 = new char[] { 'A', 'B', 'C', 'D' };

            Random r7 = new Random();
            int n7 = variant7.Length;



            Console.WriteLine("\n");


            while (n7 > 1)
            {
                n7--;
                int k7 = r7.Next(n7 + 1);
                string value7 = variant7[k7];
                variant7[k7] = variant7[n7];
                variant7[n7] = value7;
            }

            for (int i = 0; i < variant7.Length; i++)
            {
                Console.WriteLine(" {0}) {1} ", char7[0], variant7[0]);
                Console.WriteLine(" {0}) {1} ", char7[1], variant7[1]);
                Console.WriteLine(" {0}) {1} ", char7[2], variant7[2]);
                Console.WriteLine(" {0}) {1} ", char7[3], variant7[3]);
                break;
            }

            Console.Write("\n Cavabınızı daxil edin: ");

            char cavab7 = Convert.ToChar(Console.ReadLine());

            if (cavab7 == char7[0] && variant7[0] == "Elmi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal7);
                total += xal7;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab7 == char7[0] && variant7[0] != "Elmi")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal7 - 10);
                total += xal7 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab7 == char7[1] && variant7[1] == "Elmi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal7);
                total += xal7;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab7 == char7[1] && variant7[1] != "Elmi")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal7 - 10);
                total += xal7 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab7 == char7[2] && variant7[2] == "Elmi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal7);
                total += xal7;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab7 == char7[2] && variant7[2] != "Elmi")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal7 - 10);
                total += xal7 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab7 == char7[3] && variant7[3] == "Elmi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal7);
                total += xal7;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab7 == char7[3] && variant7[3] != "Elmi")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal7 - 10);
                total += xal7 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }



            // 8-ci sual;
            Console.WriteLine("\n They will buy new furniture.Translate that into Azerbaycan. ");
            string[] variant8 = new string[] { "O yeni mebel aldı.", "Onlar yeni mebel alırlar.", "Onlar mebel alacaqlar.", "Onlar yeni mebel alacaqlar." };
            char[] char8 = new char[] { 'A', 'B', 'C', 'D' };

            Random r8 = new Random();
            int n8 = variant8.Length;



            Console.WriteLine("\n");


            while (n8 > 1)
            {
                n8--;
                int k8 = r8.Next(n8 + 1);
                string value8 = variant8[k8];
                variant8[k8] = variant8[n8];
                variant8[n8] = value8;
            }

            for (int i = 0; i < variant8.Length; i++)
            {
                Console.WriteLine(" {0}) {1} ", char8[0], variant8[0]);
                Console.WriteLine(" {0}) {1} ", char8[1], variant8[1]);
                Console.WriteLine(" {0}) {1} ", char8[2], variant8[2]);
                Console.WriteLine(" {0}) {1} ", char8[3], variant8[3]);
                break;
            }

            Console.Write("\n Cavabınızı daxil edin: ");

            char cavab8 = Convert.ToChar(Console.ReadLine());

            if (cavab8 == char8[0] && variant8[0] == "Onlar yeni mebel alacaqlar.")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal8);
                total += xal8;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab8 == char8[0] && variant8[0] != "Onlar yeni mebel alacaqlar.")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal8 - 10);
                total += xal8 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab8 == char8[1] && variant8[1] == "Onlar yeni mebel alacaqlar.")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal8);
                total += xal8;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab8 == char8[1] && variant8[1] != "Onlar yeni mebel alacaqlar.")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal8 - 10);
                total += xal8 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab8 == char8[2] && variant8[2] == "Onlar yeni mebel alacaqlar.")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal8);
                total += xal8;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab8 == char8[2] && variant8[2] != "Onlar yeni mebel alacaqlar.")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal8 - 10);
                total += xal8 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab8 == char8[3] && variant8[3] == "Onlar yeni mebel alacaqlar.")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal8);
                total += xal8;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab8 == char8[3] && variant8[3] != "Onlar yeni mebel alacaqlar.")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal8 - 10);
                total += xal8 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }





            // 9-ci sual;
            Console.WriteLine();
            Console.WriteLine(@" Bir cisim digər cismə hansı qüvvə ilə təsir edirsə ikinci cisim də birinci cismə 
 modulca bərabər və əks istiqamətə yönələn qüvvə ilə təsir edir. Bu qanun adlanır ? ");
            string[] variant9 = new string[] { "Nyutonun üçüncü qanunu", "Ümumdünya cazibə qanunu", "Paskal qanunu", "Nyutonun ikinci qanunu" };
            char[] char9 = new char[] { 'A', 'B', 'C', 'D' };

            Random r9 = new Random();
            int n9 = variant9.Length;



            Console.WriteLine("\n");


            while (n9 > 1)
            {
                n9--;
                int k9 = r9.Next(n9 + 1);
                string value9 = variant9[k9];
                variant9[k9] = variant9[n9];
                variant9[n9] = value9;
            }

            for (int i = 0; i < variant9.Length; i++)
            {
                Console.WriteLine(" {0}) {1} ", char9[0], variant9[0]);
                Console.WriteLine(" {0}) {1} ", char9[1], variant9[1]);
                Console.WriteLine(" {0}) {1} ", char9[2], variant9[2]);
                Console.WriteLine(" {0}) {1} ", char9[3], variant9[3]);
                break;
            }

            Console.Write("\n Cavabınızı daxil edin: ");

            char cavab9 = Convert.ToChar(Console.ReadLine());

            if (cavab9 == char9[0] && variant9[0] == "Nyutonun üçüncü qanunu")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal9);
                total += xal9;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab9 == char9[0] && variant9[0] != "Nyutonun üçüncü qanunu")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal9 - 10);
                total += xal9 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab9 == char9[1] && variant9[1] == "Nyutonun üçüncü qanunu")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal9);
                total += xal9;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab9 == char9[1] && variant9[1] != "Nyutonun üçüncü qanunu")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal9 - 10);
                total += xal9 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab9 == char9[2] && variant9[2] == "Nyutonun üçüncü qanunu")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal9);
                total += xal9;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab9 == char9[2] && variant9[2] != "Nyutonun üçüncü qanunu")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal9 - 10);
                total += xal9 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab9 == char9[3] && variant9[3] == "Nyutonun üçüncü qanunu")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal9);
                total += xal9;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab9 == char9[3] && variant9[3] != "Nyutonun üçüncü qanunu")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal9 - 10);
                total += xal9 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }




            // 10-ci sual;
            Console.WriteLine("\n Viruslar xaricdən nə ilə örtülüdür ?");
            string[] variant10 = new string[] { "Membran ilə", "Zülalla", "Sitoplazma ilə", "Nüvə ilə" };
            char[] char10 = new char[] { 'A', 'B', 'C', 'D' };

            Random r10 = new Random();
            int n10 = variant10.Length;



            Console.WriteLine("\n");


            while (n10 > 1)
            {
                n10--;
                int k10 = r10.Next(n10 + 1);
                string value10 = variant10[k10];
                variant10[k10] = variant10[n10];
                variant10[n10] = value10;
            }

            for (int i = 0; i < variant10.Length; i++)
            {
                Console.WriteLine(" {0}) {1} ", char10[0], variant10[0]);
                Console.WriteLine(" {0}) {1} ", char10[1], variant10[1]);
                Console.WriteLine(" {0}) {1} ", char10[2], variant10[2]);
                Console.WriteLine(" {0}) {1} ", char10[3], variant10[3]);
                break;
            }

            Console.Write("\n Cavabınızı daxil edin: ");

            char cavab10 = Convert.ToChar(Console.ReadLine());

            if (cavab10 == char10[0] && variant10[0] == "Zülalla")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal10);
                total += xal10;

            }

            if (cavab10 == char10[0] && variant10[0] != "Zülalla")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal10 - 10);
                total += xal10 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab10 == char10[1] && variant10[1] == "Zülalla")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal10);
                total += xal10;
                Thread.Sleep(2500);
                Console.Clear();

            }

            if (cavab10 == char10[1] && variant10[1] != "Zülalla")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal10 - 10);
                total += xal10 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab10 == char10[2] && variant10[2] == "Zülalla")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal10);
                total += xal10;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab10 == char10[2] && variant10[2] != "Zülalla")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal10 - 10);
                total += xal10 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }


            if (cavab10 == char10[3] && variant10[3] == "Zülalla")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Doğru cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal10);
                total += xal10;
                Thread.Sleep(2500);
                Console.Clear();
            }

            if (cavab10 == char10[3] && variant10[3] != "Zülalla")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Səhv cavab ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Sizin xalınız: {0}", xal10 - 10);
                total += xal10 - 10;
                Thread.Sleep(2500);
                Console.Clear();
            }





            Console.WriteLine($"\n\n Cəm: {total}");
        }


        static void Main(string[] args)
        {

            Sual();


            Console.ReadKey();
        }
    }
}
