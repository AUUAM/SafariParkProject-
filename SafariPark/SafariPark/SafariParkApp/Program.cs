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

            Hunter tahsin = new Hunter("Tahsin", "CH", new Camera("Nikon"));
            Hunter kevin = new Hunter("Kevin", "CO", new Camera("Canon"));



            list.Add(lazer);
            list.Add(water);
            list.Add(tahsin);
            list.Add(kevin);

            foreach (var weapon in list)
            {
                Console.WriteLine(weapon.Shoot());

            }

            kevin.Shooter = lazer;
            Console.WriteLine(kevin.Shoot());



            // Extra stuff

            /*            Console.WriteLine("Enter your name: ");
                        string name = Console.ReadLine(); //entering name

                        Console.WriteLine("Choose your weapon: ");
                        Console.Write("1. Water Pistol \n2. Lazer Gun");
                        Console.WriteLine();

                        string option = Console.ReadLine();
                        //int opt = Convert.ToInt32(option); //choosing weapon

                        if (option == "1")
                        {
                            Hunter inputName = new Hunter(name,"", new Camera("Nikon"));
                            inputName.Shooter = water;
                            list.Add(inputName);
                            foreach (var weapon in list)
                            {
                                Console.WriteLine(weapon.Shoot());

                            }
                        }
                        else if (option == "2")
                        {
                            Hunter inputName = new Hunter(name,"", new Camera("Nikon"));
                            inputName.Shooter = lazer;
                            list.Add(inputName);
                            foreach (var weapon in list)
                            {
                                Console.WriteLine(weapon.Shoot());

                            }
                        }*/

        }
    }
}