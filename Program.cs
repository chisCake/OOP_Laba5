using System;
using System.Collections.Generic;

namespace OOP_Laba5 {
	class Program {
		static List<Product> products = new List<Product> {
			new PrintingDevice("Epson", "L132", "Чёрный", 392, 2.7, (482, 130, 222),10, PrintingTechnology.Inkjet, (5760, 1440), 27),
			new PrintingDevice("Canon", "Pixma TS304", "Чёрный", 140, 2.9, (430, 143, 282), 10, PrintingTechnology.Inkjet, (4800, 1200), 7.7),
			new Scanner("Epson", "Perfection V19", "Чёрный", 243, 1.54, (248, 364, 390), 2.5, (4800, 4800), 48),
			new Scanner("Canon", "CanoScan LiDE 400", "Чёрный", 248.15, 1.7, (250, 367, 420), 4.5, (4800, 4800), 48),
			new Computer("Jet", "Multimedia GE20D8SD24VGALW50", "Чёрный", 649, 0, (0,0,0), 500, "Windows", "AMD Athlon 200GE", "AMD Radeon Vega 3", 8, 240),
			new Computer("Z-Tech", "J190-4-10-miniPC-D-0001n", "Чёрный", 529, 0, (0,0,0), 500, "Windows", "Intel Celeron J1900", "Intel HD Graphics", 4, 1000),
			new Tablet("Lenovo", "Tab E7 TB-7104I", "Чёрный", 189, 0.272, (110, 193, 10), 0, "Android 8.0", "MediaTek MT8321A/D", "ARM Mali-400 MP", 1, 16, 7, (1024, 600), 2750),
			new Tablet("Lenovo", "M10 Plus TB-X606F", "Чёрный", 599, 0.460, (244, 153, 8), 0, "Android 9.0", "MediaTek Helio P22T", "IMG GE8320", 4, 64, 10.3, (1920, 1200), 5000)
		};

		static void Main() {
			for (int i = 0; i < products.Count; i++) {
				object link = products[i];
				Printer.IAmPrinting(ref link);
				Console.WriteLine("____________________________________________________________________________________________________\n");
			}

			Console.WriteLine("\nВызов одноимённого override метода");
			products[0].GetInfo();
			Console.WriteLine("\nВызов одноимённого интерфейса");
			((IGetInfo)products[0]).GetInfo();
		}
	}
}
