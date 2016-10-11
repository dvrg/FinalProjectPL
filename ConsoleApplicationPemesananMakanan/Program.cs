using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPemesananMakanan
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mn = new Menu();
            Pegawai pg = new Pegawai();
            Pembayaran pby = new Pembayaran();

            char pilihan;

            Console.WriteLine("Masukan Pilihan: ");
            Console.WriteLine("1. Data Menu\n2. Data Pegawai\n3. Data Pembayaran");
            Console.Write("Pilihan Anda: ");
            pilihan = char.Parse(Console.ReadLine());

            if(pilihan == '1')
            {
                Console.Write("Nama Makanan: ");
                mn.SetNama(Console.ReadLine());

                Console.Write("Deskripsi Makanan: ");
                mn.SetDeskripsi(Console.ReadLine());

                Console.Write("Harga: ");
                mn.SetHarga(Double.Parse(Console.ReadLine()));

                Console.Write("Kategori Makanan: ");
                mn.SetKategori(Console.ReadLine());

                Console.Write("Status Makanan: ");
                mn.SetStatus(Console.ReadLine());
            }
            else if(pilihan == '2')
            {
                Console.Write("Nama Pegawai\t:");
                pg.SetNama(Console.ReadLine());

                Console.Write("Jabatan\t:");
                pg.SetJabatan(Console.ReadLine());

                Console.Write("Nomor Telpon\t:");
                pg.SetTelp(Int16.Parse(Console.ReadLine()));

                Console.Write("Nama Sandi\t:");
                pg.SetSandi(Console.ReadLine());
            }

            else if (pilihan == '3')
            {
                Console.Write("Kode Pembayaran\t:");
                pby.SetKodePembayaran(Console.ReadLine());

                Console.Write("Tanggal Pembayaran\t:");
                pby.SetTanggalPembayaran(Console.ReadLine());

                Console.Write("ID Pemesanan\t:");
                pby.SetIdPemesanan(Double.Parse(Console.ReadLine()));

                Console.Write("Metode\t:");
                pby.SetMetode(Console.ReadLine());
            }
        }
    }
}
