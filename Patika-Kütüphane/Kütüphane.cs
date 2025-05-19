using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_Kütüphane
{
    public class Kütüphane//Kütüphane adında sınıfımızı oluşturduk.
    {
        //Fields(Alanlar)
        private string _kitapAd;
        private string _yazarAd;
        private string _yazarSoyAd;
        private int _sayfaSayisi;
        private string _yayinEvi;
        private DateTime _kayitTarihi;

        //Properties
        public string KitapAd { get { return _kitapAd; } set { _kitapAd = value; } }
        public string YazarAd { get { return _yazarAd; } set { _yazarAd = value; } }
        public string YazarSoyAd { get { return _yazarSoyAd; } set { _yazarSoyAd = value; } }
        public int SayfaSayisi { get { return _sayfaSayisi; } set { _sayfaSayisi = value; } }
        public string YayinEvi { get { return _yayinEvi; } set { _yayinEvi = value; } }
        public DateTime KayitTarihi { get { return _kayitTarihi; } set { _kayitTarihi = value; } }

        // Null constructor
        public Kütüphane()
        {
            _kayitTarihi = DateTime.Now;
        }
        //constructor
        public Kütüphane(string kitapAd,string yazarAd,string yazarSoyAd,int sayfaSayisi,string yayinEvi)
        {
            _kitapAd=kitapAd;
            _yazarAd = yazarAd;
            _yazarSoyAd=yazarSoyAd;
            _sayfaSayisi=sayfaSayisi;
            _yayinEvi=yayinEvi;
            _kayitTarihi=DateTime.Now;
        }

        //Method
        public void BilgileriYazdir()
        {
            Console.WriteLine($" Kitabın Adı :{_kitapAd} , Yazarın Adı : {_yazarAd} , Yazarın Soyadı : {_yazarSoyAd} , Sayfa sayısı : {_sayfaSayisi} , Yayın evi : {_yayinEvi} , Kayıt Tarihi : {_kayitTarihi.ToShortDateString()}");
        }
    }
}
