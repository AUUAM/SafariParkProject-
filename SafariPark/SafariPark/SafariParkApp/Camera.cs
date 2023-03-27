using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Camera : IShootable
    {
        private string _brand;

        public  string Shoot() { return $"Zing!! "; }
        public  string ToString()
        {
            throw new NotImplementedException();
        }

        public Camera(string brand) { }
    }
}
