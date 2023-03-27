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

            var list2 = new List<IStealthable>();

            /*            list.Add(lazer);
                        list.Add(water);
                        list.Add(tahsin);
                        list.Add(kevin);*/



            /*            foreach (var weapon in list)
                        {
                            Console.WriteLine(weapon.Shoot());

                        }

                        kevin.Shooter = lazer;
                        Console.WriteLine(kevin.Shoot());*/



            // Extra stuff

            /*
             * 
             * if choice - hunter then present an animal to hunt
               if choice - assassi then present new target to kill
               if choice - soldier then rescue civilian from building
             *
             * 
             */

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine(); //entering name

            //choose character
            Console.WriteLine($"{name}, Choose your Character: ");
            Console.Write("1. Assassin \n2. Hunter \n3. Soldier");
            Console.WriteLine();
            string selectCharacter = Console.ReadLine();

            if(selectCharacter == "1") { Console.WriteLine("You've selected Assassin\n"); }
            else if(selectCharacter == "2") { Console.WriteLine("You've selected Hunter\n"); }
            else if (selectCharacter == "3") { Console.WriteLine("You've selected Soldier\n"); }

            //choose weapon
            Console.WriteLine($"Now choose your weapon: ");
            Console.Write("1. Water Pistol \n2. Lazer Gun\n3. Sniper");
            Console.WriteLine();
            string selectWeapon = Console.ReadLine();

            //if(selectCharacter == "1" && selectWeapon == "1") { Assasin assassin = new Assasin(name, new WaterPistol("Water Pistol V1.0")); }

            if (selectWeapon == "1") { Console.WriteLine("hmmm... Interesting choice\n"); }
            else if (selectWeapon == "2") { Console.WriteLine("You've selected the Lazer Gun.\n"); }
            else if (selectWeapon == "3") { Console.WriteLine("You've selected a Sniper rifle\n"); }

            Console.WriteLine($"{name}, Type OK, if you are ready to start.");
            string start = Console.ReadLine();
            if (start.ToUpper() == "OK") { Console.Clear(); }


            if (selectCharacter == "1") //select assassin
            {
                Console.WriteLine($"Hello Agent {name}, Your next target has been found.. ");
                Console.WriteLine($"Choose an attack style: \n1. Ambush\n2. Long Range\n3. Short Range");
                string attackStyle = Console.ReadLine();
                
                if(selectWeapon == "1") { Console.WriteLine("Your Weapon was ineffective, You've died because of your poor choice."); }
                
                else if( selectWeapon == "2" && attackStyle == "1") 
                {
                    Assasin assassin = new Assasin(name, new LazerGun("c"));
                    Console.WriteLine(assassin.Ambush(), assassin.Shoot());
                }
                else if (selectWeapon == "3" && attackStyle == "1")
                {
                    Assasin assassin = new Assasin(name, new Sniper("Barrett M82"));
                    Console.WriteLine(assassin.Ambush(), assassin.Shoot());
                }
                else if (selectWeapon == "2" && attackStyle == "2")
                {
                    Assasin assassin = new Assasin(name, new LazerGun("Lazer Gun V1.0"));
                    Console.WriteLine(assassin.LongRangeKill(), assassin.Shoot());
                }
                else if (selectWeapon == "3" && attackStyle == "2")
                {
                    Assasin assassin = new Assasin(name, new Sniper("Barrett M82"));
                    Console.WriteLine(assassin.LongRangeKill(), assassin.Shoot());
                }

            }

            if (selectCharacter == "2") //select hunter
            {
                Console.WriteLine($"Hello Hunter {name}, You've found an unsuspecting deer...");
                Console.WriteLine($"Choose an attack style: \n1. Ambush\n2. Long Range\n3. Short Range");
                string attackStyle = Console.ReadLine();

                if (selectWeapon == "1") { Console.WriteLine("Your Weapon was ineffective, You've died because of your poor choice."); }

                else if (selectWeapon == "2" && attackStyle == "1")
                {
                    Assasin assassin = new Assasin(name, new LazerGun("Lazer Gun V1.0"));
                    Console.WriteLine("You attempt to ambush the deer... \nThe deer hears you from a far and runs away. Game Over.");
                }
                else if (selectWeapon == "3" && attackStyle == "1")
                {
                    Assasin assassin = new Assasin(name, new Sniper("Barrett M82"));
                    Console.WriteLine(assassin.Ambush(), assassin.Shoot());
                }
                else if (selectWeapon == "2" && attackStyle == "2")
                {
                    Assasin assassin = new Assasin(name, new LazerGun("Lazer Gun V1.0"));
                    Console.WriteLine(assassin.LongRangeKill(), assassin.Shoot());
                }
                else if (selectWeapon == "3" && attackStyle == "2")
                {
                    Assasin assassin = new Assasin(name, new Sniper("Barrett M82"));
                    Console.WriteLine(assassin.LongRangeKill(), assassin.Shoot());
                }
            }

            string move1 = Console.ReadLine();
        }
    }
}