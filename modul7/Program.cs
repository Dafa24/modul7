using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302223014 mahasiswa = new DataMahasiswa1302223014();
            mahasiswa.ReadJSON();

            Console.WriteLine();
            DataMember1302223014 member = new DataMember1302223014();
            member.ReadJSON();

            Console.WriteLine();
            DataGlossary glossary = new DataGlossary();
            glossary.ReadJSON();
        }
    }
}
