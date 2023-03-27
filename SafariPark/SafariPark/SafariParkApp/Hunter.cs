using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{


    public class Hunter : Person, IShootable, IStealthable // 
    {
        //private string _camera;
        // Base consutrctor called immediately after Hunter constructor called THEN hunder sonctructor method body is executed
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public IShootable Shooter { get; set; }

        public Hunter(string fName, string camera = "") : base(fName)
        {

        }

        public Hunter() { }

        public string Shoot()
        {
            return $"{GetFullName()} : {Shooter.Shoot()}";
        }

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
            return $"{base.ToString()} Shooter: {Shooter}";
        }

    }

    //public class MonsterHunter : Hunter
    //{
    //    private string _weapon;

    //    public override string ToString()
    //    {
    //        return $"{base.ToString()} with weapon {_weapon}";
    //    }
    //}
}
