class calculator
{
       static void Main(string[] args)
	   {
		   
            Console.Title = "Aplikasi Calculator";
			
            int a = 10;
            int b = 6;
            Console.WriteLine("Hasil Penambahan" + a + " + " + b + " = " + penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
	   }
	   
	   static int penambahan(int a, int b)
        {
            return a + b;
        }
		static int pengurangan(int a, int b)
        {
            return a - b;
        }
}