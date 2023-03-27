using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Assasin : Person , IStealthable, IShootable
    {
        public Assasin(string fName, IShootable weapon) : base(fName)
        {
            weapons = weapon;
        }

        public string Shoot()
        {
            return weapons.Shoot();
        }

        public IStealthable Hitman { get; set; }

        public IShootable weapons { get; set; }
        public Assasin() { }

        
        public string Ambush()
        {
            return $"You jump out of a bush and kill your target.";
        }
        public string LongRangeKill() //only works with sniper weapon
        {
            return $"You use your sniper to take out the target enemy.";
        }
        public string ShortRangeKill()
        {
            return $"You have killed the target.";
        }
        //you can override dervied methods which have the virtual keyword in their singature OR override
        public sealed override string ToString()
        {
            return $"{base.ToString()} Hitman: {Hitman}";
        }


    }
}
