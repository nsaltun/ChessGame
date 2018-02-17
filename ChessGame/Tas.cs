using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public abstract class Tas
    {
        private TakimRengi takimRengi;
        private Kare bulunduguKare;
        BusinessRule businessRule;

        public TakimRengi TakimRengi
        {
            get { return takimRengi; }
        }

        public Kare BulunduguKare
        {
            get { return bulunduguKare; }
            set { bulunduguKare = value; }
        }

        Tas(TakimRengi takimRengi, Kare bulunduguKare)
        {
            this.takimRengi = takimRengi;
            this.bulunduguKare = bulunduguKare;
        }

        public abstract bool IlerleyebilirMi(Kare gidecegiKare);

        public bool Ilerle(Kare gidecegiKare)
        {
            if (IlerleyebilirMi(gidecegiKare))
            {
                if (gidecegiKare.UzerindeBulunanTas != null)
                    Oyun.GetInstance().ElenenTaslar.Add(gidecegiKare.UzerindeBulunanTas);

                this.bulunduguKare.UzerindeBulunanTas = null;
                this.bulunduguKare = gidecegiKare;
                gidecegiKare.UzerindeBulunanTas = this;

                return true;
            }
            else
                return false;
        }

        public virtual bool Ye(Kare kare)
        {
            if (IlerleyebilirMi(kare))
            {
                Oyun.GetInstance().ElenenTaslar.Add(kare.UzerindeBulunanTas);
                this.bulunduguKare.UzerindeBulunanTas = null;
                this.bulunduguKare = kare;
                kare.UzerindeBulunanTas = this;

                return true;
            }
            else
                return false;
        }



    }
}
