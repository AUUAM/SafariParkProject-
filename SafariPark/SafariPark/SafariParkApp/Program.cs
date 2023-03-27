using SafariParkApp.Extra;

namespace SafariParkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Declaring and initialising alex
            //Person alex = new Person("Alexander", "Blunt");
            //alex.Age = 23;
            //Console.WriteLine(alex.GetFullName());
            ////Declaring nish
            //Person nish;
            //// making room on the heap by creating a new object and assingning to the nish variable

            ////Person cormac = new Person("Cormac");

            //var tahsin = new Person();

            //Spartan suheyb = new Spartan { FirstName = "Suheyb", LastName = "Adam", Age = 100};

            //var shopList = new ShoppingList { Apples = 1, ClingFilm = 3 };

            //nish = new Person("Nish", "Mandal") { Age = 33 };
            //var man = new Person("Man Him", "Yeung") { Age = 12345 };

            //// You can construct a struct using the new key word (like objects)
            //// Or you can just declare it and set the values after declaration - which we can't do with objects
            //// You cannot inherit from structs
            //Point3d pt3d;
            //pt3d.x = 1;
            //pt3d.y = 2;
            //pt3d.z = 3;

            //DemoMethod(pt3d, nish);

            //    var hunter = new Hunter("Gharzay", "Wali", "Gameboy Camera") { Age = 19 };
            //    Console.WriteLine(hunter.Age);
            //    Console.WriteLine(hunter.Shoot());
            //    var hunter2 = new Hunter("Ali", "Cengiz");
            //    //Console.WriteLine($"Hunter equals hunter2? {hunter.Equals(hunter2)}");  
            //    //Console.WriteLine($"Hunter hashcode? {hunter.GetHashCode()}");  
            //    //Console.WriteLine($"Hunter Type? {hunter.GetType()}");  
            //    //Console.WriteLine($"Hunter ToString? {hunter}");
            //    //Console.WriteLine(hunter);

            //    Rectangle rect = new Rectangle { Width = 10, Height = 5 };
            //    Triangle tri = new Triangle { Width = 10, Height = 5 };
            //    Console.WriteLine(rect);
            //    Console.WriteLine(tri);
            //    Console.WriteLine(tri.CalculateArea());
            //    Console.WriteLine(rect.CalculateArea());

            //    var shapeList = new List<Shape> { rect, tri };
            //    foreach (var shape in shapeList)
            //    {
            //        Console.WriteLine($"Rectangle Area: {rect.CalculateArea()}");
            //        Console.WriteLine($"Triangle Area: {tri.CalculateArea()}");
            //    }

            //    var airPlane = new Airplane(10, 10, "Sparta Air") { NumPassengers = 5};
            //    Console.WriteLine(airPlane);

            //    var spartan = new Spartan { FullName = "Cormac Smith", Age = 22, Stream = "C# TAE", SpartanScore = 100 };


            //    Console.WriteLine(spartan.SpartanDetails());
            //    //}

            //    static void DemoMethod(Point3d pt, Person p)
            //{
            //    pt.y = 1000;
            //    p.Age = 45;


            // implemeting interface 

            //var list = new List<IMovable>(); // when youre defining the list  you have to define its type as IMovable



            //Vehicle v1 = new Vehicle();
            //Person p1 = new Person();



            //list.Add(v1);
            //list.Add(p1);



            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Move());
            //}

            var list = new List<IShootable>();

            LazerGun lazer = new LazerGun("Lazer1");
            WaterPistol water = new WaterPistol("Water 1");

            Hunter tahsin = new Hunter("Shoot");
            Hunter kevin = new Hunter("shoot");

            Camera Canon = new Camera("Canon");

            list.Add(lazer);
            list.Add(water);
            list.Add(tahsin);
            list.Add(kevin);
            list.Add(Canon);



            foreach(var weapon in list)
            {
                Console.WriteLine(weapon.Shoot());

            }








        }
    }
}