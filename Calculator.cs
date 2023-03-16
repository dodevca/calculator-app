class Calculator
{
	static void Main(string[] args)
	{
		int a = 10, b = 6;
		
		Console.writeLine(""Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b), Pengurangan(a, b));
		Console.writeLine(""Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b), Pengurangan(a, b));
	
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.ReadKey();
	}
	
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
}