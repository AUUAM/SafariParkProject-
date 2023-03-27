using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Assasin : Person , IStealthable, IShootable
    {
        public Assasin(string fName, string lName, IStealthable hitman) : base(fName, lName)
        {
            Hitman = hitman;
        }

        public IStealthable Hitman { get; set; }

       
        public Assasin() { }

        

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
        //you can override dervied methods which have the virtual keyword in their singature OR override
        public sealed override string ToString()
        {
            return $"{base.ToString()} Hitman: {Hitman}";
        }
        public string Shoot()
        {
            return $"{GetFullName()} : {Hitman.Shoot()}";
        }


    }
}
