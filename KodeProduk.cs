using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300121
{
    class KodeProduk
    {
        public enum ProdukElektronik
        {
            Laptop,
            Smartphone,
            Tablet,
            Headset,
            Keyboard,
            Mouse,
            Printer,
            Monitor,
            Smartwatch,
            Maleer,
            Kamera
        }

        public static string getKodeProduk(ProdukElektronik produkElektronik)
        {
            string[] kodeProduk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109"};
            return kodeProduk[(int)produkElektronik];
        }
    }

}

