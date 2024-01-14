using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi.tahmin.app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BİL KAZAN YARIŞMAMIZA HOŞGELDİNİZ DOĞRU TAHMİN EDİN BÜYÜK ÖDÜL SİZİN OLSUN!");

            Console.WriteLine("HANGİ ZORLUK SEVİYESİNDE YARIŞMAK İSTERSİNİZ? ");

            Console.WriteLine("1. Kolay (1-20 Aralığındaki Sayıları Tahmin Edin!)");

            Console.WriteLine("2. Orta (1-30 Aralığındaki Sayıları Tahmin Edin!)");

            Console.WriteLine("3. Zor (1-40 Aralığındaki Sayıları Tahmin Edin!)");




            int seviye = SecilenSeviye();

            int maksimumSayi;
            switch (seviye)
            {
                case 1:
                    maksimumSayi = 20;
                    break;
                case 2:
                    maksimumSayi = 30;
                    break;
                case 3:
                    maksimumSayi = 40;
                    break;
                default:
                    Console.WriteLine("Seviye geçersiz.Otomatik olarak orta seviye seçiliyor.");
                    maksimumSayi = 30;
                    break;
            }




            Random random = new Random();
            int dogruSayi = random.Next(1, maksimumSayi + 1);

            Console.WriteLine($"Bir sayı tahmin edin (1-{maksimumSayi} arası):");

            int tahmin = -1;
            int tahminSayisi = 0;
            int tahminHakki = 3;



            while (tahmin != dogruSayi && tahminHakki > 0)
            {
                if (int.TryParse(Console.ReadLine(), out tahmin))
                {
                    tahminSayisi++;

                    if (tahmin < 1 || tahmin > maksimumSayi)
                    {
                        Console.WriteLine($"Lütfen 1 ile {maksimumSayi} arasında bir sayı girin.");
                    }
                    else
                    {
                        if (tahmin < dogruSayi)
                        {
                            Console.WriteLine("Daha yüksek bir sayı tahmin edin.");
                        }
                        else if (tahmin > dogruSayi)
                        {
                            Console.WriteLine("Daha düşük bir sayı tahmin edin.");
                        }
                        else
                        {
                            Console.WriteLine($"Tebrikler! {tahminSayisi} tahminde doğru sayıyı buldunuz.");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı giriş. Lütfen bir sayı girin.");
                }


                tahminHakki--;

                if (tahminHakki > 0)
                {
                    Console.WriteLine($"Kalan tahmin hakkınız: {tahminHakki}. Yeniden deneyin:");
                }
                else
                {
                    Console.WriteLine($"Üzgünüz, tahmin hakkınız bitti. Doğru sayı: {dogruSayi}");
                }
            }
        }


        static int SecilenSeviye()
        {
            int seviye;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out seviye) && seviye >= 1 && seviye <= 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seviye. Lütfen 1, 2 veya 3 girin.");
                }
            }
            return seviye;
        }
    }








}
