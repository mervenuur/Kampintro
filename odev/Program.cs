using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {


            Kitap kitap1 = new Kitap();
            kitap1.KitapAdi = "Şeker Portakalı";
            kitap1.KitapYazari = "Jose Mauro de Vasconcelos";
            kitap1.KitapNo = 1;

            Kitap kitap2 = new Kitap();
            kitap2.KitapAdi = "Açlık Oyunları";
            kitap2.KitapYazari = "Suzanne Collins";
            kitap2.KitapNo = 2;

            Kitap kitap3 = new Kitap();
            kitap3.KitapAdi = "Tansık";
            kitap3.KitapYazari = "Günay Uslu";
            kitap3.KitapNo = 3;

            Kitap[] kitaplar = new Kitap[] { kitap1, kitap2, kitap3 };

            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap.KitapAdi + " : " + kitap.KitapYazari);
            }

            Console.WriteLine("Foreach döngüsü burada bitii");

            for (int i = 0; i < kitaplar.Length; i = i + 1)
            {
                Console.WriteLine(kitaplar[i].KitapAdi + " : " + kitaplar[i].KitapYazari + " : " + kitaplar[i].KitapNo);
            }

            Console.WriteLine("For döngüsü burada bitti");
        }

            class Kitap
        {
            public string KitapAdi { get; set; }
            public string KitapYazari { get; set; }
            public int KitapNo { get; set; }
        }

        }
    }

