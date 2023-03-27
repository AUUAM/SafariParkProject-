using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Sniper : Weapon, IShootable
    {
        public Sniper(string brand) : base(brand) { }

        public override string Shoot() { return $"Zing!! Shooting a {base.ToString()}"; }

    }
}
