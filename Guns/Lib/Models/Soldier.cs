using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Lib.Models
{
    public class Soldier 
    {
        public string Name { get; set; }
       // public List<Gun> Guns_List { get; set; }

        public Gun.IGun gun;

        public Soldier(Gun.IGun x, string name)
        {
            this.gun = x;
            this.Name = name;
        }

        public string Shoot()
        {
            return this.gun.Shoot();
        }

        public interface INewChange
        {
            string ChangeWeapon();
        }
        /*
        public string DispararRevolver()
        {
            return new Gun.Revolver().Shoot();   
        }

        public string DispararRifle()
        {
            return new Gun.Rifle().Shoot();
        }

        public string DispararEscopeta()
        {
            return new Gun.Shotgun().Shoot();
        }

        public string ShootGatling()
        {
            return new Gun.Gatling().Shoot();
        }
        */
        
    }
}
