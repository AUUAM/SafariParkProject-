using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Sniper : Weapon, IStealthable
    {
        public Sniper(string brand) : base(brand) { }
        public string Sneak()
        {
            return "You are sneaking";
        }

        public string Hide()
        {
            return "You are hidden";
        }
        public string Run()
        {
            return "You are running away";
        }
        public string Kill()
        {
            return "You have killed the target";
        }
    }
}
