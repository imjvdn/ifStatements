using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isMale = false;
            //bool isTall = false;
            bool isGaming = false;
            bool isSleeping = true;

            if (isGaming)
            {
                Console.WriteLine("You are gaming");
            }
            else if (isSleeping)
            {
                Console.WriteLine("You are sleeping");

            }
            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male.");
            //}
            //else if (isMale && !isTall) {

            //    Console.WriteLine("You are a short male");


            //}
            //else if (!isMale && isTall) {

            //    Console.WriteLine("You are not male but are Tall");
            
            //} else
            //{
            //    Console.WriteLine("You are not male and not tall.");
            //}

            Console.ReadLine();
        }
    }
}
