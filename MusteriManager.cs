using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine(musteri.ID + " numaralı müşteri  "+musteri.AdiSoyadi+" listeye eklenmiştir.");
            
        } 
        public void MusteriListele(Musteri musteri) 
        {
            Console.WriteLine("Müşteri ID: "+musteri.ID );
            Console.WriteLine("Müşsteri Adı Soyadı: "+ musteri.AdiSoyadi);
            Console.WriteLine("Müşteri Uyruğu: "+musteri.Uyruk);
            Console.WriteLine("Müşteri Mesleği: "+musteri.Meslegi);
            Console.WriteLine("Müşteri Yaşı: "+musteri.Yasi);


        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.ID+" numaralı  müşteri  "+ musteri.AdiSoyadi +"  silinmiştir.");
            Console.WriteLine("                                                                    ");
            //Console.WriteLine("-----------");
        }
    }
}
