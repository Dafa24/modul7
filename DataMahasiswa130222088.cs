using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmod07_kelompok_04
{
    // deklarasi class DataMahasiswa1302223014
    public class DataMahasiswa1302223014
    {

        // deklarasi class Mahasiswa1302223014
        public class Mahasiswa1302223057
        {
            //mengambil data berupa nama dari class Name
            public Name nama { get; set; }

            // mengambil data berupa nim
            public int nim { get; set; }

            // mengambil data berupa nama fakultas
            public string fakultas { get; set; }

        }

        // deklarasi class Name
        public class Name
        {
            // mengambil data spesifik nama depan
            public string depan { get; set; }

            //mengambil data spesifik nama belakang
            public string belakang { get; set; }
        }

        // method readJSON
        public void ReadJSON()
        {
            // menentukan path file modul7_1_1302223014.json
            string filePath = "D:\\modul7\\modul7\\jurnal7_1_1302223014";
            string jsonString = File.ReadAllText(filePath);

            // Menampilkan data mahasiswa berupa nama, NIM , dan fakultas
            Mahasiswa1302223057 mahasiswa = JsonSerializer.Deserialize<Mahasiswa1302223057>(jsonString);
            Console.WriteLine($"Nama : {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
            Console.WriteLine($"NIM : {mahasiswa.nim}");
            Console.WriteLine($"Fakultas : {mahasiswa.fakultas}");
            Console.WriteLine();
        }
    }
}


