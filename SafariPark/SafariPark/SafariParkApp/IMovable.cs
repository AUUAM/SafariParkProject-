using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    // an interfaxe is a purly abstract "class2
    // any classes that implement an interface must implement its method
    // its pure abstract 
    // conventions - use the word interface rather than class
    // ALL members are public by default 
    // Cant take constants, fields or constructors
    // cant include propeties - but the implemetinf class must have them too 
    public interface IMovable
    {
        string Move();
        string Move(int items);

    }
}
