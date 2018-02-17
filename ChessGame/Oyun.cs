using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Oyun
    {
        private static Oyun oyun;
        public static Oyun GetInstance()
        {
            if (oyun == null)
                oyun = new Oyun();

            return oyun;
        }

        private List<Tas> elenenTaslar;
        public List<Tas> ElenenTaslar
        {
            get { return elenenTaslar; }
            set { elenenTaslar = value; }
        }

    }
}
