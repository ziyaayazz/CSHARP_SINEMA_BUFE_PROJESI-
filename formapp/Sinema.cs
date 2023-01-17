using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace formapp
{
     class Sinema
    {
        int toplamKoltukSayısı ;
        int bosKoltukSayısı;
        double bakıye;
        string SalonNo;

        const double TAM = 40.0;
        const double INDIRIMLI = 30.0;

        public Sinema(string salonn, int koltukSayısı) 
            // kurucu metot
        {
            toplamKoltukSayısı = koltukSayısı;
            SalonNo = salonn;
            bosKoltukSayısı = toplamKoltukSayısı;
            bakıye = 0;
        }

        public void BiletSat(bool ındırımlı)
        {
            bosKoltukSayısı--;
            if (ındırımlı)
                bakıye += INDIRIMLI;
            else
                bakıye += TAM;
        }
        
        public void BiletIptal(bool ındırımlı)
        {
            bosKoltukSayısı++;
            if(ındırımlı)
                bakıye -= INDIRIMLI;    
            else 
                bakıye -= TAM; 
        }

        public int BosKoltukOgren()
        {
            return bosKoltukSayısı;
        }

        public double BakıyeOgren()
        {
            return bakıye;
        }
    }
}
