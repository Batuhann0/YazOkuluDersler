using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        //BURALAR ENTİTY LAYER KATMANI(VARLIK KATMANI)

        private string ad;
        private string soyad;
        private int OgrenciId;
        private string numara;
        private string fotograf;
        private double bakiye;
        private string Sifre;

        //KAPSÜLLEME İŞLEMİ
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int OGRENCİId { get => OgrenciId; set => OgrenciId = value; }
        public string Numara { get => numara; set => numara = value; }
        public string Fotograf { get => fotograf; set => fotograf = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
        public string SIFRE { get => Sifre; set => Sifre = value; }
    }
}
