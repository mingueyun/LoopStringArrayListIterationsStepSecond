using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopStringArrayListIterationsStepSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Months = { "January", "Feb", "March" };
            Console.WriteLine("what is the last food you ate? \n");
            string food = Console.ReadLine();


            for (int k = 0; k < Months.Length; k++) { Months[k] = Months[k] + food; }

            foreach (string month in Months)
            {
                Console.WriteLine(month);
            }
            Console.ReadLine();


            //Infinite Loop

            //List<int> myaAges = new List<int> { 12, 7, 55, 33, 70, 50 };
            //for (int a = 0; a < myaAges.Count; a--)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();



            List<int> myaAges = new List<int> { 12, 7, 55, 33, 70, 50 };
            for (int a = 0; a < myaAges.Count; a++)
            {
                Console.WriteLine(myaAges[a]);
            }
            Console.ReadLine();





            List<int> numerals = new List<int> { 12, 7, 55, 33, 70, 50 };
            for (int a = 0; a < numerals.Count; a++)
            {
                if (numerals[a] < 50)
                    Console.WriteLine("The ages list are " + numerals[a]);
            }
            Console.ReadLine();


            List<int> numerals1 = new List<int> { 12, 7, 55, 33, 70, 50 };
            for (int a = 0; a < numerals1.Count; a++)
            {
                if (numerals1[a] <= 50)
                    Console.WriteLine("The ages list are " + numerals1[a]);
            }
            Console.ReadLine();




            List<string> carColors = new List<string>() { "red", "yellow", "blue", "green", "pink" };
            Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            string myColors = Console.ReadLine();
            Console.WriteLine("Index of  : {0}", carColors.IndexOf(myColors));
            Console.ReadLine();


            List<string> carColors2 = new List<string>() { "red", "yellow", "blue", "green", "pink" };
            Console.WriteLine("what is your favorit car color? choose from below \n 0 =red, \n1 = yellow, \n2 = blue, \n 3 = green, \n4 = pink");
            int myColors2 = Convert.ToInt32(Console.ReadLine());
            if (myColors2 > -1 && myColors2 < 5)
            {
                Console.WriteLine("Index of " + carColors2[myColors2]);
            }
            else
            {
                Console.WriteLine(" you entered something wrong");
            }
            Console.ReadLine();


            List<string> carColors3 = new List<string>() { "red", "yellow" };
            Console.WriteLine("what is your favorit car color? choose from below \nred, yellow");
            string myColors3 = Console.ReadLine();
            bool imGuessing = false;

            do
            {
                switch (myColors3)
                {
                    case "red":
                        Console.WriteLine("Index value is {0}", "1");
                        imGuessing = true;

                        break;
                    case "yellow":
                        Console.WriteLine("Index value is {0}", "2");
                        imGuessing = true;

                        break;
                    default:
                        Console.WriteLine("try again");
                        Console.WriteLine("what is your favorit car color? choose from below \nred, yellow");
                        myColors3 = Console.ReadLine();
                        break;
                }
            }
            while (!imGuessing);
            Console.ReadLine();


            string[] colorAr = { "red", "yellow", "blue", "green", "pink", "red" };
            Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            string myColors4 = Console.ReadLine();

            int index = -1;
            do
            {
                index = Array.IndexOf(colorAr, myColors4, index + 1);
                System.Console.WriteLine("The matching string are in index: " + index);
            } while (0 == index);

            Console.ReadLine();



            string[] colorAr2 = { "red", "yellow", "blue", "green", "pink", "red" };
            Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            string myColors5 = Console.ReadLine();

            int index2 = -1;
            do
            {
                if (colorAr2.Any(x => x == myColors5))
                {
                    index2 = Array.IndexOf(colorAr2, myColors5, index2 + 1);
                    System.Console.WriteLine("The matching string are in index: " + index2);
                }
                else
                {
                    Console.WriteLine(" you entered something wrong");
                }
            } while (0 == index2);

            Console.ReadLine();

            List<string> cColors = new List<string>() { "red", "yellow", "blue", "green", "pink", "blue" };
            List<string> sameColors = new List<string>();

            for (int i = 0; i < cColors.Count; i++)
            {
                for (int j = i + 1; j < cColors.Count; j++)
                {
                    if (cColors[j] == cColors[i])
                    {
                        if (!sameColors.Contains(cColors[i]))
                        {
                            sameColors.Add(cColors[i]);
                        }
                    }
                }
            }
            foreach (string sColors in sameColors)
            {
                Console.WriteLine("Just to let you kow " + sColors + " has appeard already.");
            }
            Console.ReadLine();


        }
    }
}
