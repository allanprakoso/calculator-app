using System;

class calculator
{
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