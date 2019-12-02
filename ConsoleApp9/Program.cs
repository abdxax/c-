using System;

namespace ConsoleApp9
{
    class Program
    {
        static String[] drug = new String[] { "d1", "d2", "d3", "d4", "d5", "d6", "d7", "d8", "d9", "d10" };
        static int[] quan = new int[] { 2, 3, 4, 8, 5, 6, 7, 8, 9, 10 };
        static double[] price = new double[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        static void disolayStok()
        {
            for (int i = 0; i < drug.Length; i++)
            {
                Console.WriteLine(drug[i] + " " + quan[i]);
            }

        }

        static Boolean enterOrder()
        {
            Console.WriteLine("Please Enter the name drgugs");
            String named = Console.ReadLine();
            Console.WriteLine("Please Enter the quantity");
            int q = int.Parse(Console.ReadLine());
            Boolean isFound = false;

            for (int i = 0; i < drug.Length; i++)
            {
                if (named == drug[i])
                {
                    isFound = true;
                }
                else
                {

                    //break;
                }
                if (isFound)

                {
                    if (quan[i] >= q)
                    {
                        int qu = quan[i] - q;
                        quan[i] = qu;
                        Console.WriteLine("The drug is " + named + " The quantit " + q + " The price is " + (price[i] * q));
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("The Quantity availble in stoke is " + quan[i]);
                        return true;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("The drug not availible now try again ");
            }
            return false;


        }





        static void Main(string[] args)
        {
            //  String drugs[] = new string[20];

            Console.WriteLine("Hello World!");

            Boolean wh = true;

            while (wh)
            {
                Console.WriteLine("Please Choise from option \n 1- stoke detels \n 2- enter order  \n 3-exeit the system ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Program.disolayStok();
                        break;

                    case 2:
                        Boolean o = Program.enterOrder();
                        if (o)
                        {
                            Console.WriteLine("Order Complite ");
                        }

                        break;

                    case 3:

                        System.Environment.Exit(1);
                        break;



                }

                // Console.WriteLine("Hello World!");

            }
            Console.ReadKey();
        }
    }
}


