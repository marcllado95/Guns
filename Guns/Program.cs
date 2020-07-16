using System;
using Guns.Lib.Models;

namespace Guns
{
    class Program
    {

        public static void NewChange(Soldier s)
        {
            Console.WriteLine("Change of weapon detected");
            var Ad = new Notify();
            Ad.NotifyInfo(s);
            Console.WriteLine(s.Shoot());
        }
        public static void NewChange(Tank t)
        {
            Console.WriteLine("Change of canon-tank detected");
            var Ad = new Notify();
            Ad.NotifyInfo(t);
            Console.WriteLine(t.Blast());
        }

        static void Main(string[] args)
        {
            var Arnold = new Soldier(new Gun.Revolver(), "Schwarzenegger");

            var Silvester = new Soldier(new Gun.Gatling(), "Stallone");

            Arnold = new Soldier(new Gun.Shotgun(), "Schwarzenegger");
            NewChange(Arnold);

            var Walle = new Tank(new Canon.Breda35(), "Wall-e");

            Walle = new Tank(new Canon.KBM(), "Wall-e");
            NewChange(Walle);

            var Zlatan = new Tank(new Canon.Breda35(), "Zlatan");

            Zlatan = new Tank(new Canon.TNsh(), "Zlatan");
            NewChange(Zlatan);


        }
    }
}
