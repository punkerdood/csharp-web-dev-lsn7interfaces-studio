using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
             MyCD = new CD();
             MyDVD = new DVD();

            // TODO: Call each CD and DVD method to verify that they work as expected.
            MyCD.ShootLaser();
            MyDVD.ShootLaser();
        }
    }
}
