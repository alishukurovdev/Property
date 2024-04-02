using System.IO;

namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            Weapon weapon= new Weapon(15,15,3,"Automatic");
            do
            {
                Console.Clear();
                Console.WriteLine(@"0 - İnformasiya almaq üçün
1 - Shoot metodu üçün
2 - Fire metodu üçün
3 - GetRemainBulletCount metodu üçün
4 - Reload metodu üçün
5 - ChangeFireMode metodu üçün
6 - Proqramdan dayandırmaq üçün
qısayoldur.
7 - Redakte etmek üçün");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                switch (input)
                {
                    case 0:
                        Console.OutputEncoding = System.Text.Encoding.UTF8;
                        Console.WriteLine("Xoş gəlmisiz.\n" +
                            "Bura da siz seçdiyiniz rəqəmə görə silahın güllə tutumu, güllə sayı, boşalma saniysi və atış modun görə bilərsiz.");
                        Console.ReadKey();
                        break;
                    case 1:
                        weapon.Shoot();
                        Console.ReadKey();
                        break;
                    case 2:
                        weapon.Fire();
                        Console.ReadKey();
                        break;
                    case 3:
                        weapon.GetRemainBulletCount();
                        Console.ReadKey();
                        break;
                    case 4:
                        weapon.Reload();
                        Console.ReadKey();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                            Console.ReadKey();
                        break;
                    case 6:
                        isContinue = false;
                        break;

                    case 7:
                        Console.WriteLine("Enter option (T - Weapon Mode, S - Bullet Count, D - Reset Second):");
                        string option = Console.ReadLine();
                        Console.ReadKey();
                        switch (option)
                        {
                            case "T":
                                Console.WriteLine("Yeni silah daxil edin:");
                                weapon.WeaponMode = Console.ReadLine();
                                break;
                            case "S":
                                Console.WriteLine("Gulle sayi daxil edin:");
                                weapon.BulletCount = Convert.ToInt32(Console.ReadLine());
                                break;
                            case "D":
                                Console.WriteLine("Sifirlama saniyesin daxil edin:");
                                weapon.FinishSeconds = Convert.ToDouble(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Yalnis secdiniz!");
                                break;
                        }
                        break;

                }
            } while (isContinue);
        }
    }
}
