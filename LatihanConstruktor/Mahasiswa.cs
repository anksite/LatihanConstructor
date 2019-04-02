using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanConstruktor {
    class Mahasiswa {
        public string NIM { get; set; }
        public string Nama { get; set; }

        public Mahasiswa() { }

        public Mahasiswa(string nim, string nama) {
            NIM = nim;
            Nama = nama;
        }
    }
}
