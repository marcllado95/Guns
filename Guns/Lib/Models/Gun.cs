using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Guns.Lib.Models
{
    public class Gun 
    {

        public interface IGun
        {
            string Shoot();
            string Model();

        }

        public class Revolver : IGun
        {
            public string Model()
            {
                return "Revolver";
            }
            public string Shoot()
            {
                return "Pum Pum ..";
            }
        }

        public class Rifle : IGun
        {
            public string Model()
            {
                return "Rifle";
            }
            public string Shoot()
            {
                return "Pum pum pum pum pum ..";
            }
        }

        public class Shotgun : IGun
        {
            public string Model()
            {
                return "Shotgun";
            }
            public string Shoot()
            {
                return "pum PUMMM !! ..";
            }
        }

        public class Gatling : IGun
        {
            public string Model()
            {
                return "Gatling";
            }
            public string Shoot()
            {
                return "Prrrrrrrrrapapapapaapapapapapapapapapapapapapappapapappaaapapapapapa !!!";
            }
        }

    }
}
