using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Library
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Book> banyakBuku = new List<Book>()
            {
                new Book{NameBook = "Sejarah", QuantityBook = 21},
                new Book{NameBook = "Kimia", QuantityBook = 32},
                new Book{NameBook = "Bahasa Indonesia", QuantityBook = 42},
                new Book{NameBook = "Bahasa Francis", QuantityBook = 24 }
            };

        one:
            Console.Clear();
            try
            {
                Console.WriteLine("  Perpustakaan");
                Console.WriteLine("1. Tampilkan Buku");
                Console.WriteLine("2. Tambah Buku");
                Console.WriteLine("3. Hapus Buku");
                Console.WriteLine("4. Keluar");
                Console.Write("Masukan Pilihan : ");
                int pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (pilihan)
                {
                    case 1:
                        int i = 0;
                        foreach (Book buku in banyakBuku)
                        {
                            i++;
                            Console.Write(i); buku.ShowBook();
                        }
                        Console.ReadKey();
                        goto one;
                    case 2:
                        Console.WriteLine(" Tambah Buku");
                        Console.Write("Nama Buku   = "); string tampungNama = Convert.ToString(Console.ReadLine());
                        Console.Write("Jumlah Buku = "); int tampungJumlah = Convert.ToInt32(Console.ReadLine());

                        banyakBuku.Add(new Book { NameBook = tampungNama, QuantityBook = tampungJumlah });
                        goto one;
                    case 3:
                        delete:
                        Console.WriteLine("  Hapus Buku");
                        int j = 0;
                        foreach (Book buku in banyakBuku)
                        {
                            j++;
                            Console.Write(j); buku.ShowBook();
                        }
                        Console.Write("Pilih Nomor Buku = "); int noBuku = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.Write($"Yakin ingin menghapus buku {banyakBuku[noBuku-1].NameBook}? (1/0) ");int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            banyakBuku.RemoveAt(noBuku - 1);
                            goto one;
                        }
                        else if (choice == 0)
                        {
                            goto one;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Tidak ada Pilihan!!");
                            Console.ReadKey();
                            Console.Clear();
                            goto delete;
                        }
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Terimakasih :)");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Tidak Ada di Pilihan!!");
                        Console.ReadKey();
                        Console.Clear();
                        goto one;
                }
            }
            catch (Exception e)
            {
                if (e is FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Harus Angka!!");
                    Console.ReadKey();
                    Console.Clear();
                    goto one;
                }
                else if (e is ArgumentOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Tidak Ada di Pilihan!!");
                    Console.ReadKey();
                    Console.Clear();
                    goto one;
                }
                throw;
            }
        }
    }
}
