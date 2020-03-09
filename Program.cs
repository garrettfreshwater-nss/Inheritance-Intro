using System;

namespace InheritanceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBike = new Zero();
            // i can still reference the inherited property
            myBike.MainColor = "Black";
            myBike.MainOccupancy = 2;

            var myTesla = new Tesla();

            myTesla.MainColor = "White";
            myTesla.MainOccupancy = 6;

            var myRam = new Ram();
            var myCessna = new Cessna();

            myBike.Drive();
            myTesla.Drive();
            myRam.Drive();
            myCessna.Drive();

        }
    }
}