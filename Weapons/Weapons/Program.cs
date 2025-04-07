namespace Weapons
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Daragin gulle tutumunu daxil edin:");
            int capacity = int.Parse(Console.ReadLine());
            Weapon weapon = new Weapon(capacity);

            while (true)
            {
                Console.WriteLine("Secim edin: 0 - Melumat, 1 - Atıs, 2 - Gulle Sayi, 3 - Yeniden Doldur, 4 - Mod Dəyis, 5 - cixis");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Daragi gulle tutumu: " + capacity + ", Cari gulle sayi: " + weapon.GetRemainBulletCount());
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        Console.WriteLine("Daragin dolmasi ücün lazim olan gulle sayi: " + weapon.GetRemainBulletCount());
                        break;
                    case 3:
                        Console.WriteLine("Yeniden doldurmaq ucun gulle sayini daxil edin:");
                        int bullets = int.Parse(Console.ReadLine());
                        weapon.Reload(bullets);
                        break;
                    case 4:
                        weapon.ChangeFireMode();
                        break;
                    case 5:
                        Console.WriteLine("Proqramdan cixilir...");
                        return;
                    default:
                        Console.WriteLine("Yanlis secim, yeniden cehd edin.");
                        break;
                }
            }
        }
    }
}
