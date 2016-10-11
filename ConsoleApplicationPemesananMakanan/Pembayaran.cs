using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPemesananMakanan
{
    class Pembayaran
    {
        private string kodePembayaran;
        private string tanggalPembayaran;
        private double idPemesanan;
        private string metode;

        public void SetKodePembayaran(string kdPembayaran)
        {
            kodePembayaran = kdPembayaran;
        }
        public string GetKodePembayaran()
        {
            return kodePembayaran;
        }

        public void SetTanggalPembayaran(string tglPembayaran)
        {
            tanggalPembayaran = tglPembayaran;
        }
        public string GetTanggalPembayaran()
        {
            return tanggalPembayaran;
        }

        public void SetIdPemesanan(double idPesan)
        {
            idPemesanan = idPesan;
        }
        public double GetIdPemesanan()
        {
            return idPemesanan;
        }

        public void SetMetode(string Metode)
        {
            metode = Metode;
        }
        public string GetMetode()
        {
            return metode;
        }

    }
}
