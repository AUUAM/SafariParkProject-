using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public abstract class Weapon
    {
        private string _brand;

        public abstract string Shoot();

        public abstract string ToString();

        public  Weapon (string brand)
        {

        }

        
    }

}
