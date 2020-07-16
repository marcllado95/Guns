using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Lib.Models
{
    public class Tank
    {
        public string Name { get; set; }

        public Canon.ICanon canon;

        public Tank(Canon.ICanon c, string name)
        {
            this.canon = c;
            this.Name = name;
        }

        public string Blast()
        {
            return this.canon.Blast();
        }

        public interface INewChange
        {
            string ChangeWeapon();
        }
    }
}
