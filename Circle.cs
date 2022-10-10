using System;
using System.Collections.Generic;
using System.Text;

namespace Oop___Lab_5
{
    //Mumtaz MOhamud [NET22]
    class Circle
    {
        //Saves variables to call it later.
        float _pi = 3.141f;
        int _Radius;
        //Constructor
        public Circle(int _Radius)
        {
            this._Radius = _Radius;
        }
        //Method that retuns area
        public double getArea()
        {
            double Area = _Radius * _Radius * _pi;
            return Area;
        }


    }
}
