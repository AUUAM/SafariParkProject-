using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{


    public class Hunter : Person, IShootable // 
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
            //_camera = camera;
        }

        public Hunter() { }

        public string Shoot()
        {
            return $"{GetFullName()} : {Shooter.Shoot()}";
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
