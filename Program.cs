// See https://aka.ms/new-console-template for more information
using modul4_103022300121;

Console.WriteLine("=======KodeProduk=======");
Console.WriteLine(KodeProduk.getKodeProduk(KodeProduk.ProdukElektronik.Laptop));
Console.WriteLine(KodeProduk.getKodeProduk(KodeProduk.ProdukElektronik.Smartphone));
Console.WriteLine(KodeProduk.getKodeProduk(KodeProduk.ProdukElektronik.Tablet));
Console.WriteLine(KodeProduk.getKodeProduk(KodeProduk.ProdukElektronik.Headset));
Console.WriteLine(KodeProduk.getKodeProduk(KodeProduk.ProdukElektronik.Keyboard));
Console.WriteLine(KodeProduk.getKodeProduk(KodeProduk.ProdukElektronik.Mouse));
Console.WriteLine(KodeProduk.getKodeProduk(KodeProduk.ProdukElektronik.Printer));
Console.WriteLine(KodeProduk.getKodeProduk(KodeProduk.ProdukElektronik.Monitor));
Console.WriteLine(KodeProduk.getKodeProduk(KodeProduk.ProdukElektronik.Smartwatch));
Console.WriteLine(KodeProduk.getKodeProduk(KodeProduk.ProdukElektronik.Kamera));

Console.WriteLine("=========FanLAptop========");
FanLaptop fanLaptop = new FanLaptop();

fanLaptop.ActivateTrigger(FanLaptop.Trigger.MODE_UP);
fanLaptop.ActivateTrigger(FanLaptop.Trigger.MODE_UP);
fanLaptop.ActivateTrigger(FanLaptop.Trigger.MODE_DOWN);
fanLaptop.ActivateTrigger(FanLaptop.Trigger.MODE_DOWN);
fanLaptop.ActivateTrigger(FanLaptop.Trigger.TURBO_SHORTCUT);
fanLaptop.ActivateTrigger(FanLaptop.Trigger.MODE_DOWN);
fanLaptop.ActivateTrigger(FanLaptop.Trigger.MODE_UP);
fanLaptop.ActivateTrigger(FanLaptop.Trigger.TURBO_SHORTCUT);
