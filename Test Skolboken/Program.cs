using System;
using System.Collections.Generic;
using System.Linq;
namespace Test_Skolboken
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarering av olika variablar som används, även listan.
            int x, y, z, k;

            List<int> TotalSumma = new List<int>();
            bool sluta = true;
            char operation;
            char operation2;
            while (sluta)
            {

                Console.WriteLine("Hej och välkommen till min miniräknare! Tryck in två operatörer och tre nummer   \n Operatörer " +
                    "som går att välja är + - * / %" +
                    "");

                //Inmatning av operatörer


                Console.Write("Skriv operatör ett: ");
                operation = Convert.ToChar(Console.ReadLine());
                Console.Write("Skriv in operatör två: ");
                operation2 = Convert.ToChar(Console.ReadLine());

                //Inmatning av talen
                Console.Write("Skriv in ditt första tal: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Skriv in ditt andra tal: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Skriv in ditt tredje tal: ");
                z = Convert.ToInt32(Console.ReadLine());






                //Uträkningarna som utförs och även en if-sats för kolla om summan är större, mindre eller likamed 100
                if (operation == '+')
                {
                    //Plus som första operatör
                    if (operation2 == '+')
                    {
                        k = x + y + z;
                        Console.WriteLine("{0} + {1} + {2} = {3}", x, y, z, x + y + z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '-')
                    {
                        k = x + y - z;
                        Console.WriteLine("{0} + {1} - {2} = {3}", x, y, z, x + y - z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if ((operation2 == 'x') || (operation2 == '*'))
                    {
                        k = x + y * z;
                        Console.WriteLine("{0} + {1} * {2} = {3}", x, y, z, (x + y) * z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }

                    else if (operation2 == '/')
                    {
                        k = x + y / z;
                        Console.WriteLine("{0} + {1} - {2} = {3}", x, y, z, (x + y) / z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }

                    else if (operation2 == '%')
                    {
                        k = x + y % z;
                        Console.WriteLine("{0} + {1} % {2} = {3}", x, y, z, (x + y) % z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }


                }


                else if (operation == '-')
                {
                    //Minus som första operatör
                    if (operation2 == '+')
                    {
                        k = x - y + z;
                        Console.WriteLine("{0} - {1} + {2} = {3}", x, y, z, x - y + z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '-')
                    {
                        k = x - y - z;
                        Console.WriteLine("{0} - {1} - {2} = {3}", x, y, z, x - y - z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if ((operation2 == 'x') || (operation2 == '*'))
                    {
                        k = x - y * z;
                        Console.WriteLine("{0} - {1} * {2} = {3}", x, y, z, (x - y) * z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '/')
                    {
                        k = x - y / z;
                        Console.WriteLine("{0} - {1} / {2} = {3}", x, y, z, (x - y) / z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '%')
                    {
                        k = x - y % z;
                        Console.WriteLine("{0} - {1} % {2} = {3}", x, y, z, (x - y) % z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }

                }
                else if ((operation == 'x') || (operation == '*'))
                {
                    //Gånger som första operatör
                    if (operation2 == '+')
                    {
                        k = (x * y) + z;
                        Console.WriteLine("{0} * {1} + {2} = {3}", x, y, z, (x * y) + z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '-')
                    {
                        k = (x * y) - z;
                        Console.WriteLine("{0} * {1} - {2} = {3}", x, y, z, (x * y) - z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if ((operation2 == 'x') || (operation2 == '*'))
                    {
                        k = (x * y) * z;
                        Console.WriteLine("{0} * {1} * {2} = {3}", x, y, z, (x * y) * z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '/')
                    {
                        k = (x * y) / z;
                        Console.WriteLine("{0} * {1} / {2} = {3}", x, y, z, (x * y) / z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '%')
                    {
                        k = (x * y) % z;
                        Console.WriteLine("{0} * {1} % {2} = {3}", x, y, z, (x * y) % z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }

                }
                //Delat med som första operatör
                else if (operation == '/')
                {

                    if (operation2 == '+')
                    {
                        k = (x * y) + z;
                        Console.WriteLine("{0} / {1} + {2} = {3}", x, y, z, (x / y) + z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '-')
                    {
                        k = (x / y) - z;
                        Console.WriteLine("{0} / {1} - {2} = {3}", x, y, z, (x / y) - z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if ((operation2 == 'x') || (operation2 == '*'))
                    {
                        k = (x / y) * z;
                        Console.WriteLine("{0} / {1} * {2} = {3}", x, y, z, (x / y) * z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '/')
                    {
                        k = (x / y) / z;
                        Console.WriteLine("{0} / {1} / {2} = {3}", x, y, z, (x / y) / z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '%')
                    {
                        k = (x / y) % z;
                        Console.WriteLine("{0} / {1} % {2} = {3}", x, y, z, (x / y) % z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }

                }
                else if (operation == '%')
                {
                    //Modulus som första operatör
                    if (operation2 == '+')
                    {
                        k = (x % y) + z;
                        Console.WriteLine("{0} % {1} + {2} = {3}", x, y, z, (x % y) + z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '-')
                    {
                        k = (x % y) - z;
                        Console.WriteLine("{0} %{1} - {2} = {3}", x, y, z, (x % y) - z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if ((operation2 == 'x') || (operation2 == '*'))
                    {
                        k = (x % y) * z;
                        Console.WriteLine("{0} % {1} * {2} = {3}", x, y, z, (x % y) * z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '/')
                    {
                        k = (x % y) / z;
                        Console.WriteLine("{0} % {1} / {2} = {3}", x, y, z, (x % y) / z);
                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }
                    }
                    else if (operation2 == '%')
                    {
                        k = (x % y) % z;
                        Console.WriteLine("{0} %{1} % {2} = {3}", x, y, z, (x % y) % z);

                        TotalSumma.Add(k);
                        if (k > 100)
                        {
                            Console.WriteLine("More then a hundred");
                        }
                        else if (k < 100)
                        {
                            Console.WriteLine("Less then a hundred");
                        }
                        else if (k == 100)
                        {
                            Console.WriteLine("Cool, now you have a hundred, clap clap");
                        }

                    }



                }



                // Fortsätta eller avsluta 

                Console.WriteLine("Vill du fortsätta=J eller avsluta=N ? J/N");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "J")
                    sluta = true;

                // Summan av hela listan adderat tillsammans och omvandlad till int vid N som tangentslag vid valet
                if (answer == "N")
                {

                    Console.Write("Din totala summa för dagens räkningar är: " + TotalSumma.Sum(x => Convert.ToInt32(x)));
                    break;
                }
                //Vid fel karaktär ingivande
                else

                    Console.WriteLine("Wrong Character");

            }

        }
    }
}
