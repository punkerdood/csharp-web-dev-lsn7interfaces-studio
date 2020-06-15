using System;
namespace SpinningDiscs
{
   
    public class CD : IOpticalDiscs
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 

  
            public void SpinDisk()
            {
                Console.WriteLine("Spin : 22 GHz");
            }
            public void ShootLaser()
            {
                Console.WriteLine("Shooting Laser Beam: Red");
            }
            public void ReadData()
            {
                Console.WriteLine("Mmmm... Good Data.");
            }

        
    }
}
