using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Başarı ile " + musteri.Name + " " + musteri.Surname + " adlı kaydınızı oluşturdunuz");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri " + musteri.Name + " " + musteri.Surname + "silme işlemi başarı ile sonuçlandı");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("Müşterinin adı :" + musteri.Name + "\n" + "Müşterinin soyadı :" + musteri.Surname + "\n" + "Müşterinin TC'si :" + musteri.IdenNumber);
        }



    }
}
