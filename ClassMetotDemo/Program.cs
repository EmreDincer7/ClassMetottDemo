using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.ID = 1;
            musteri1.Name = "Emre";
            musteri1.Surname = "Dinçer";
            musteri1.IdenNumber = 123456789;

            Musteri musteri2 = new Musteri();

            musteri2.ID = 2;
            musteri2.Name = "Kerim";
            musteri2.Surname = "Dinçer";
            musteri2.IdenNumber = 987654321;

            Musteri musteri3 = new Musteri();

            musteri3.ID = 3;
            musteri3.Name = "Meryem";
            musteri3.Surname = "Dinçer";
            musteri3.IdenNumber = 1122334455;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach ( Musteri item in musteriler)
            {
                Console.WriteLine("Müşterinin ismi : " + item.Name);
                Console.WriteLine("Müşterinin Soy ismi : " + item.Surname);
                Console.WriteLine("Müşterinin TC : " + item.IdenNumber);


            }

            Console.WriteLine("                      ");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);


            Console.WriteLine("                      ");


            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);



            Console.WriteLine("                      ");



            musteriManager.List(musteri1);
            musteriManager.List(musteri2);
            musteriManager.List(musteri3);

        }
    }
}
