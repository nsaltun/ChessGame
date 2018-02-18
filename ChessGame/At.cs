using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class At : Tas
    {
        private Kare bulunduguKare;
        private TakimRengi tasRengi;
        public At(TakimRengi tasRengi, Kare bulunduguKare)
            : base(tasRengi, bulunduguKare)
        {
            this.bulunduguKare = bulunduguKare;
            this.tasRengi = tasRengi;
        }

        public override bool IlerleyebilirMi(Kare gidecegiKare)
        {
            return base.ruleManager.LSeklindeGidebilirMi(this.bulunduguKare, gidecegiKare);
        }
    }
}
