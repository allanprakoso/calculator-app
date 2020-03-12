using System;

class calculator
{
    private const int V = 1;

    static void Main(string[] args)
	   {
		   
        Console.Title = "Aplikasi Calculator";
			
        Console.WriteLine("Menu Aplikasi\n");
        Console.WriteLine("1. Penjumlahan \n2. Pengurangan \n3. Perkalian \n4. Pembagian");
        Console.Write("Pilihan Menu: ");
        int pilihan = int.Parse(Console.ReadLine());

        Console.Write("Nilai a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nilai b: ");
        int b = int.Parse(Console.ReadLine());

        switch(pilihan)
        {
            case 1 :
            Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, penambahan(a,b));
            break;
            case 2 :
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a,b));
            break;
            case 3 :
            Console.WriteLine("Hasil Pengurangan {0} x {1} = {2}", a, b, perkalian(a,b));
            break;
            case 4 :
            Console.WriteLine("Hasil Pengurangan {0} : {1} = {2}", a, b, pembagian(a,b));
            break;
            default:
            Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            break;
        }

        Console.WriteLine("Tekan Sembarang Tombol Untuk Keluar");
        Console.ReadKey();
	   }
	   
	   static int penambahan(int a, int b)
        {
            return a + b;
        }
		static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a * b;
        }
}