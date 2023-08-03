using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDersler
    {
        private string DersAd;
        private int DersId;
        private int MinKont;
        private int MaksKont;


        //kapsülleme
        public string DERSAD
        {
            get { return DersAd; }
            set { DersAd = value; }
        }

        public int MINKONT { get => MinKont; set => MinKont = value; }
        public int MAKSKONT { get => MaksKont; set => MaksKont = value; }
        public int DERSID { get => DersId; set => DersId = value; }
    }
}
