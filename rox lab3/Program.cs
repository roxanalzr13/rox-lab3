using System;

namespace TEMA_LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex51();
            //Ex6();
            //Ex7();
            Ex8();
            //EX9();
            //Ex10()
            Console.ReadLine();
        }
        static void Ex1()
        //  program care sa calculeze max. a trei numere citite de la tastatura
        {

            Console.WriteLine("Introduceti numarul a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul c=");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                    Console.WriteLine("Cel mai mare numar este a");
                else
                {
                    Console.WriteLine("Cel mai mare numar este c");
                }
            }


            else if (b > c)
            {
                Console.WriteLine("Cel mai mare numar este b");
            }

            else
            {
                Console.WriteLine("Cel mai mare numar este c");

            }
        }
        static void Ex2()
        // citirea unui numar intreg poz de la tastatura care sa afiseze val in baza2
        {
            int index = 0;
            int[] nrbaza2 = new int[20];

            Console.WriteLine("Introduceti numarul in baza 10");
            int nrbaza10 = int.Parse(Console.ReadLine());

            while (nrbaza10 != 0)
            {
                nrbaza2[index] = nrbaza10 % 2;
                nrbaza10 = nrbaza10 / 2;
                index++;
            }

            for (int i = index - 1; i >= 0; i--)
                Console.Write(nrbaza2[i]);

            Console.Read();

        }

        static void Ex3()
        {
            // nr n citit de la tastatura este patrat perfect

            Console.WriteLine("Citeste numarul a=");
            int a = int.Parse(Console.ReadLine());
            int radacina = (int)Math.Sqrt((double)a);

            if (a == radacina * radacina)
            {
                Console.WriteLine("a este patrat perfect");
            }
            else
            {
                Console.WriteLine("a nu este patrat perfect");
            }
        }
        static void Ex4()
        // se citesc numere , apoi sa se calculeze suma lor
        {


            Console.WriteLine("Cate numere veti introduce?");
            int n = int.Parse(Console.ReadLine());



            long suma = 0;
            int numar = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("introduceti numarul");
                numar = int.Parse(Console.ReadLine());
                if (numar != 0)
                {
                    suma = suma + numar;
                    numar++;
                }
            }


            Console.WriteLine("suma " + suma);
        }

        static void Ex5()

        // se citesc numere pana apare 0, apoi sa se calculeze suma lor
        {
            int suma = 0;
            int numar = -1;
            while (numar != 0)
            {
                numar = int.Parse(Console.ReadLine());
                suma = suma + numar;
            }
            Console.WriteLine("suma" + suma);
            return;
        }

        static void Ex51()
        // se citesc numere de la tastatura pana cand se introduc doua numere consecutive egale.Sa se calculeze suma lor.
        {
            int suma = 0;

            int numar1 = -1;
            int numar2 = -2;
            while (numar1 != numar2)
            {

                numar1 = numar2;
                numar2 = int.Parse(Console.ReadLine());

                suma = suma + numar2;

            }
            Console.WriteLine("suma" + suma);
            return;

        }

        static void Ex6()
        //daca n este prim, va afisa "prim", altfel va afisa numarul cu care este divizibil
        //a=1,b=n,n/ab,n/a,n/b
        {
            int numar;
            bool prim = true;
            int i = 2;

            numar = int.Parse(Console.ReadLine());

            while (i <= numar / 2)
            {

                if (numar % i == 0)
                    prim = false;
                i += 1;
            }

            if (prim)
            {
                Console.WriteLine("Numarul {0} este prim", numar);
            }
            else
            {
                Console.WriteLine("Numarul {0} nu este prim", numar);
            }

            Console.Read();
        }
        static void Ex7()
        {
            // se citesc 2 numere de la tastatura. Sa se scrie un progr care sa afiseze cel mai mare divizor comun
            {
                int a, b, n, m;
                Console.Write("Introduceti a ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Introduceti b ");
                b = int.Parse(Console.ReadLine());
                n = a; m = b;
                while (a != b)
                {

                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                        Console.WriteLine("c.m.m.d.c. ({0},{1}) = {2}", n, m, a);
                        Console.ReadLine();
                    }
                }
            }
        }

        static void Ex8()
        {


            //  Scrie un program care afiseaza numerele de la 1 la N. Daca numarul
            //este multiplu de 3, sa se afiseze Fizz, daca este multiplu de 3 sa se afiseze
            //Buzz, daca e multiplu si de 3 si de 5(ex: 15) sa se afiseze FizzBuzz, in restul
            //cazurilor sa se afiseze numarul
            {
                int i;    
                i = 1;
                int n;
                n = int.Parse(Console.ReadLine());

                for ( i = 1; i <= n; i++)

                {
                    if (i % 15 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                ;
                }
            }
        }

    }

}
                
    

          
    





































