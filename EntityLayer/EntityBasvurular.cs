using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvurular
    {
        private int BasvuruId;
        private int OgrenciId;
        private int DersId;

        public int BASVURUID { get => BasvuruId; set => BasvuruId = value; }
        public int OGRENCİID { get => OgrenciId; set => OgrenciId = value; }
        public int DERSID { get => DersId; set => DersId = value; }
    }
}
