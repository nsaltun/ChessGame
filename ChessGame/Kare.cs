using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Kare
    {
        private int konumX;
        private int konumY;
        private Tas uzerindeBulunanTas;

        public int KonumX
        {
            get { return konumX; }
        }

        public int KonumY
        {
            get { return konumY; }
        }

        public Tas UzerindeBulunanTas
        {
            get { return uzerindeBulunanTas; }
            set { uzerindeBulunanTas = value; }
        }

        public Kare(int konumX, int konumY)
        {

        }
    }
}
