using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign.Static_NonStatic
{
    internal class Pattern
    {
        //Global Variables

        int Number1 { get; set; }

        int Number2 { get; set; }

        //public int Number3 { get; set; }

        public int Number4 { get; set; }

        public int Number5 { get; set; }

        void GetNumberFromUser1()
        {


            Console.WriteLine("Please enter any number ");
            Number1 = Convert.ToInt32(Console.ReadLine());

        }

        public int GetNumberFromUser2()
        {
            Console.WriteLine("Please enter any number ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            return Number2;
        }



        public static void Pattern0()
        {

            Pattern patternobj = new Pattern();
            patternobj.GetNumberFromUser2();


            for (int i = 1; i <= patternobj.Number2; i++)
            {
                for (int j = 1; j <= patternobj.Number2; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        public void Pattern1()
        {


            GetNumberFromUser1();

            for (int i = Number1; i >= 1; i--)
            {
                for (int j = Number1; j >= 1; j--)
                {
                    Console.Write(" " + Convert.ToChar(64 + j));
                }

                Console.WriteLine();

            }

        }


        //static to static call

        public static int GetNumberFromUser3()
        {
            Pattern obj = new Pattern();

            Console.WriteLine("Please enter any number ");
            obj.Number4 = Convert.ToInt32(Console.ReadLine());
            return obj.Number4;
        }

        public static void Pattern2()
        {
            Pattern obj = new Pattern();

            Pattern.GetNumberFromUser3();

            for (int i = obj.Number4; i >= 1; i--)
            {
                for (int j = obj.Number4; j >= 1; j--)
                {
                    Console.Write(" " + Convert.ToChar(64 + j));
                }

                Console.WriteLine();

            }

        }
    }
}
