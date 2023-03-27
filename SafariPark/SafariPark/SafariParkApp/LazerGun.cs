﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class LazerGun : Weapon 
    {
        public LazerGun(string brand) : base(brand) { }

        public override string Shoot() { return $"Zing!! Shooting a {base.ToString()}"; }

/*        public override string ToString()
        {
            return "Shooting a " + base.ToString();
        }*/

    }
}
