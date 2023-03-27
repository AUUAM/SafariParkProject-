using SafariParkApp.Extra;

namespace SafariParkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var list = new List<IShootable>();

            LazerGun lazer = new LazerGun("Lazer 1.0");
            WaterPistol water = new WaterPistol("Water Pistol 1.0");

            Hunter tahsin = new Hunter("Tahsin", "Last", " ");
            Hunter kevin = new Hunter("Kevin", "Last", " ");

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