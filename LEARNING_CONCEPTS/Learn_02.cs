namespace LEARNING_CONCEPTS_Learn_02
{
	public class Person
	{
		public int Age;
		public string FullName;
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person P1 = new Person();

			P1.Age = 20;
			P1.FullName = "Ali Reza Alavi";

			System.Console.WriteLine("Full Name: {0} - Age: {1}", P1.FullName, P1.Age);

			Person P2 = new Person();

			P2.Age = 30;
			P2.FullName = "Sara Ahmadi";

			System.Console.WriteLine("Full Name: {0} - Age: {1}", P2.FullName, P2.Age);

			Person P3 = new Person();

			P3.Age = 40;
			P3.FullName = "Mohammad Ghaderi";

			System.Console.WriteLine("Full Name: {0} - Age: {1}", P3.FullName, P3.Age);

			Person P4 = new Person();

			P4.Age = 50;
			P4.FullName = "Reza Ghorji";

			System.Console.WriteLine("Full Name: {0} - Age: {1}", P4.FullName, P4.Age);

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
