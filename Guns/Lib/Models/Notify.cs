using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Lib.Models
{
    public class Notify 
    {

        public void NotifyInfo(Soldier y)
        {
            Console.WriteLine("Current gun:  " + y.gun.Model() + " carried by soldier " + y.Name);
        }
        public void NotifyInfo(Tank t)
        {
            Console.WriteLine("Current canon:  " + t.canon.Model() + " carried by tank " + t.Name);
        }

    }
}
