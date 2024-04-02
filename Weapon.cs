using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Weapon
    {
        private int _bulletCapacity;  // gulle tutmu
        public int _bulletCount; // gulle sayi
        private double _finishSeconds;  // bosalma saniyesi
        private string _weaponMode;  // atis modu

        public int BulletCapacity
        {
            get
            {
                return _bulletCapacity;
            }
            set
            {
                _bulletCapacity = value;
            }
        }
        public int BulletCount
        {
            get
            {
                return _bulletCount;
            }
            set
            {
                _bulletCount = value;
            }
        }
        public double FinishSeconds
        {
            get
            {
                return _finishSeconds;
            }
            set
            {
                _finishSeconds = value;
            }
        }
        public string WeaponMode
        {
            get
            {
                return _weaponMode;
            }
            set
            {
                _weaponMode = value;
            }
        }
        public Weapon(int bulletCapacity, int bulletCount, double finishSeconds, string weaponMode)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCount;
            FinishSeconds = finishSeconds;
            WeaponMode = weaponMode;

        }

        public void Shoot()
        {
            if (BulletCount > 0)
            {
                Console.WriteLine(" tvu tvuu  part part");
                BulletCount--;
            }
            else
            {
                Console.WriteLine("Gulle bitib zehmet olmasa yeniden doldurun");
            }

        }    
        public void Fire()
        {
            Console.WriteLine($"{_bulletCount} gulle atildi, serf olunan vaxt:{_bulletCount*_finishSeconds}" );
            _bulletCount = 0;
        }

        public void GetRemainBulletCount()
        {//--------------------*
            Console.WriteLine($"Dolması üçün lazım olan gülle: {_bulletCapacity - _bulletCount}");
        }
        public void Reload()
        { 
            BulletCount= BulletCapacity;
            Console.WriteLine($"Gulleniz dolduruldu: {BulletCount}");
        }
        public void ChangeFireMode()
        {
            if (_weaponMode == "Automatic")
            {
                _weaponMode = "Automatic";
            }
            else
            {
                _weaponMode = "Single";
            }

            Console.WriteLine($"Atis modu deyisildi {_weaponMode}");
        }

    }
}

