using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class BusinessRule
    {
        public BusinessRule()
        {

        }

        public bool LSeklindeGidebilirMi(Kare bulunduguKare, Kare gidecegiKare)
        {
            if (gidecegiKare.UzerindeBulunanTas == null ||
                (gidecegiKare.UzerindeBulunanTas != null && gidecegiKare.UzerindeBulunanTas.TasRengi != bulunduguKare.UzerindeBulunanTas.TasRengi))
            {
                if (gidecegiKare.KonumX == bulunduguKare.KonumX + 2 || gidecegiKare.KonumX == bulunduguKare.KonumX - 2)
                    if (gidecegiKare.KonumY == bulunduguKare.KonumY - 1 || gidecegiKare.KonumY == bulunduguKare.KonumY + 1)
                        return true;
                    else
                        return false;
                else if (gidecegiKare.KonumX == bulunduguKare.KonumX + 1 || gidecegiKare.KonumX == bulunduguKare.KonumX - 1)
                    if (gidecegiKare.KonumY == bulunduguKare.KonumY - 2 || gidecegiKare.KonumY == bulunduguKare.KonumY + 2)
                        return true;
                    else
                        return false;
            }

            return false;
        }
    }
}
