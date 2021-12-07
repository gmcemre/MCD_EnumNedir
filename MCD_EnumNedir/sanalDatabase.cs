using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace MCD_EnumNedir
{
    public class sanalDatabase
    {
        ArrayList sanalDB = new ArrayList();

        public musteriReturnValue musteriYeniKayit(Musteri m)
        {
            // parametre Kontrol

            //kayıt kontrol

            sanalDB.Add(m);
            return musteriReturnValue.kayitBasarili;
        }
    }
}
