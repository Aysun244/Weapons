using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    public class Weapon
    {
        private int bulletCapacity;
        private int currentBullets;
        private bool isAutomatic;

        public Weapon(int capacity)
        {
            bulletCapacity = capacity;
            currentBullets = 0;
            isAutomatic = false;
        }

        public void Shoot()
        {
            if (currentBullets > 0)
            {
                if (isAutomatic)
                {
                    Console.WriteLine("Avtomatik atis: " + currentBullets + " gulle atildi.");
                    currentBullets = 0;
                }
                else
                {
                    Console.WriteLine("Tekli atis:1gulle atildi.");
                    currentBullets--;
                }
            }
            else
            {
                Console.WriteLine("Gulle qalmayib!");
            }
        }

        public int GetRemainBulletCount()
        {
            return bulletCapacity - currentBullets;
        }

        public void Reload(int bullets)
        {
            if (currentBullets + bullets <= bulletCapacity)
            {
                currentBullets += bullets;
                Console.WriteLine(bullets + "gulle elave edildi.Cari gulle sayi " + currentBullets);
            }
            else
            {
                Console.WriteLine("Oops");
            }
        }

        public void ChangeFireMode()
        {
            isAutomatic = !isAutomatic;
            string mode = isAutomatic ? "Avtomatik" : "Tekli";
            Console.WriteLine("Atış modu deyisdi: " + mode);
        }
    }
}



