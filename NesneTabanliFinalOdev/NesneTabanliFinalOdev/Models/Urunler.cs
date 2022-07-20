using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneTabanliFinalOdev.Models
{
    public class Urunler : Interfaces.ISQL_Islemleri

    {
        private int data_ürünNo = 0;
        public int Data_ÜrünNo
        {
            get
            {
                return data_ürünNo;
            }
            set
            {
                data_ürünNo = Math.Abs(value);
            }
        }
        private string data_ürünAd = "";
        public string Data_ÜrünAd
        {
            get
            {
                return data_ürünAd;
            }
            set
            {
                data_ürünAd = value.ToUpper();
            }
        }
        private int data_birimFiyat = 0;
        public int Data_BirimFiyat
        {
            get
            {
                return data_birimFiyat;
            }
            set
            {
                data_birimFiyat = Math.Abs(value);
            }
        }
        private int data_stokMiktarı =0;
        public int Data_StokMiktarı
        {
            get
            {
                return data_stokMiktarı;
            }
            set
            {
                data_stokMiktarı = Math.Abs(value);
            }
        }
        public Urunler()
        {
        }

        public Urunler(int UrunNo, string UrunAd, int KategoriNo, int BirimFiyat, int StokMiktarı)
        {
            this.Data_ÜrünNo = UrunNo;
            this.Data_ÜrünAd = UrunAd;
            this.Data_BirimFiyat = BirimFiyat;
            this.Data_StokMiktarı = StokMiktarı;
        }


        public void Kaydet()
        {
            Classes.SQLConnectionClass.Command(""
                 + "   INSERT INTO[dbo].[Ürünler]                    "
                 + "           ([ÜrünNo]                             "
                 + "         ,[ÜrünAd]                               "
                 + "         ,[BirimFiyat]                           "
                 + "         ,[StokMiktarı] )                         "
                 + "    VALUES                                       "
                 + "          (" + Data_ÜrünNo + "                       "
                 + "          ,'" + Data_ÜrünAd + "'                     "
                 + "          ," + Data_BirimFiyat + "                   "
                 + "          ," + Data_StokMiktarı + "  )                "
                );
        }

        public void Sil()
        {
            Classes.SQLConnectionClass.Command( "DELETE FROM Ürünler WHERE ÜrünNo=" + Data_ÜrünNo );
        }
    }
}