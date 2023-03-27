using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public abstract class Weapon : IShootable
    {
        private string _brand;

        public virtual string Shoot() { return "String"; }

        public virtual string ToString() { return "string2"; }

        public  Weapon (string brand)
        {

        }

        
    }

}
