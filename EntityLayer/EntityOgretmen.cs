using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int OgretmenId;
        private string OgretmenAdSoyad;
        private int OgretmenBrans;

        public int OGRETMENID { get => OgretmenId; set => OgretmenId = value; }
        public string OGRETMENADSOYAD { get => OgretmenAdSoyad; set => OgretmenAdSoyad = value; }
        public int OGRETMENBRANS { get => OgretmenBrans; set => OgretmenBrans = value; }
    }
}
