using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Tahta
    {
        private List<Kare> kareler;
        public List<Kare> Kareler
        {
            get
            {
                return kareler;
            }
        }


        Tahta(List<Kare> kareler)
        {
            this.kareler = kareler;
        }
    }
}
