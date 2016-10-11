using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPemesananMakanan
{
    class Menu
    {
        private string nama;
        private string deskripsi;
        private double harga;
        private string kategori;
        private string status;

        public void SetNama(string Nama)
        {
            nama = Nama;
        }
        public string GetNama()
        {
            return nama;
        }

        public void SetDeskripsi(string Deskripsi)
        {
            deskripsi = Deskripsi;
        }
        public string GetDeskripsi()
        {
            return deskripsi;
        }

        public void SetHarga(double Harga)
        {
            harga = Harga;
        }
        public double GetHarga()
        {
            return harga;
        }

        public void SetKategori(string Kategori)
        {
            kategori = Kategori;
        }
        public string GetKategori()
        {
            return kategori;
        }

        public void SetStatus(string Status)
        {
            status = Status;
        }
        public string GetStatus()
        {
            return status;
        }
    }
}
