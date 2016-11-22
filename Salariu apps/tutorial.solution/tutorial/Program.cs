using System;

namespace tutorial
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string R1 = null;
			string R2 = null;
			double R3 = 0;
			double S = 0;

			while (true) 
				
			{

				Console.WriteLine ("Ce doriti sa calculat, (b)rut sau (n)et ?");
				R1 = Console.ReadLine ();
				Console.WriteLine ("(s)cutit sau (n)escutit ?");
				R2 = Console.ReadLine ();
				Console.WriteLine ("Introduceti suma.");
				R3 = Convert.ToDouble (Console.ReadLine ());

				if (R1 == "b" && R2 == "s") 
					{
						S = R3 > 11193 ? (R3 + 1408) / 0.94 : R3 / 0.835;
					} 
				else if (R1 == "b" && R2 == "n") 
					{
						S = R3 > 9402 ? (R3 + 1183) / 0.7896 : R3 / 0.835 / 0.84;
					} 
				else if (R1 == "n" && R2 == "s") 
					{
						S = R3 > 13405 ? (R3 * 0.94) - 1408 : R3 * 0.835;
					} 
				else if (R1 == "n" && R2 == "n") 
					{
						S = (R3 > 13405) ? (R3 * 0.7896) - 1183 : R3 * 0.7014; 
					}
				
				Console.WriteLine ("Salariul este: " + S);
			}
		}
	}
}
