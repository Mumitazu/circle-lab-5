using System;
using System.Collections.Generic;
using System.Text;

namespace Oop___Lab_5
{
    //Mumtaz MOhamud [NET22]
    class Program
    {
        static void Main(string[] args)
        {
            //Calls the constructor and gives an output.
            Circle C1 = new Circle(5);
            Console.WriteLine("Arean av cirkel 1  är : " + C1.getArea());
            Circle C2 = new Circle(6);
            Console.WriteLine("Area av cirkel 2 är : " + C2.getArea());
        }

    }





}