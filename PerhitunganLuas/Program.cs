using System;

namespace PerhitunganLuas
{
    class Program
    {
        /// <summary>
        /// Metode utama untuk menjalankan program hitung luas bangun datar.
        /// </summary>
        /// <param name="args">Argumen baris perintah (tidak digunakan).</param>
        static void Main(string[] args)
        {
            string pilihan;
            do
            {
                Console.Clear();
                Console.WriteLine("===== Program Hitung Luas Bangun Datar =====");
                Console.WriteLine("1. Hitung Luas Segitiga");
                Console.WriteLine("2. Hitung Luas Persegi Panjang");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilihan: ");
                pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        HitungLuasSegitiga();
                        break;
                    case "2":
                        HitungLuasPersegiPanjang();
                        break;
                    case "3":
                        Console.WriteLine("Terima kasih! Sampai jumpa.");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        break;
                }

                Console.Write("Tekan Enter untuk melanjutkan...");
                Console.ReadLine();

            } while (pilihan != "3");
        }

        /// <summary>
        /// Metode untuk menghitung dan menampilkan luas segitiga.
        /// </summary>
        static void HitungLuasSegitiga()
        {
            Console.Clear();
            Console.WriteLine("===== Hitung Luas Segitiga =====");
            double alas, tinggi;
            Console.Write("Masukkan panjang alas: ");
            if (double.TryParse(Console.ReadLine(), out alas))
            {
                Console.Write("Masukkan tinggi: ");
                if (double.TryParse(Console.ReadLine(), out tinggi))
                {
                    double luas = 0.5 * alas * tinggi;
                    Console.WriteLine($"Luas segitiga: {luas}");
                }
                else
                {
                    Console.WriteLine("Input tinggi tidak valid.");
                }
            }
            else
            {
                Console.WriteLine("Input panjang alas tidak valid.");
            }
        }

        /// <summary>
        /// Metode untuk menghitung dan menampilkan luas persegi panjang.
        /// </summary>
        static void HitungLuasPersegiPanjang()
        {
            Console.Clear();
            Console.WriteLine("===== Hitung Luas Persegi Panjang =====");
            double panjang, lebar;
            Console.Write("Masukkan panjang: ");
            if (double.TryParse(Console.ReadLine(), out panjang))
            {
                Console.Write("Masukkan lebar: ");
                if (double.TryParse(Console.ReadLine(), out lebar))
                {
                    double luas = panjang * lebar;
                    Console.WriteLine($"Luas persegi panjang: {luas}");
                }
                else
                {
                    Console.WriteLine("Input lebar tidak valid.");
                }
            }
            else
            {
                Console.WriteLine("Input panjang tidak valid.");
            }
        }
    }
}
