using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanConstruktor {
    class Program {
        static void Main(string[] args) {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.NIM = "5577";
            mhs1.Nama = "Doni";
            cetakHasil(mhs1);

            Console.WriteLine();

            Mahasiswa mhs2 = new Mahasiswa("1234", "Paijo");
            cetakHasil(mhs2);

            Console.ReadKey();
        }

        static void cetakHasil(Mahasiswa mhs) {
            Console.WriteLine("NIM: {0}", mhs.NIM);
            Console.WriteLine("Nama: {0}", mhs.Nama);
        }
    }
}
