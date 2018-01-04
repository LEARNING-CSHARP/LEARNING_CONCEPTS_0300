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
			Person p1 = new Person();

			p1.Age = 20;
			p1.FullName = "Ali Reza Alavi";

			System.Console.WriteLine($"Full Name: { p1.FullName } - Age: { p1.Age }");

			Person p2 = new Person();

			p2.Age = 30;
			p2.FullName = "Sara Ahmadi";

			System.Console.WriteLine($"Full Name: { p2.FullName } - Age: { p2.Age }");

			Person p3 = new Person();

			p3.Age = 40;
			p3.FullName = "Mohammad Ghaderi";

			System.Console.WriteLine($"Full Name: { p3.FullName } - Age: { p3.Age }");

			Person p4 = new Person();

			p4.Age = 50;
			p4.FullName = "Reza Ghorji";

			System.Console.WriteLine($"Full Name: { p4.FullName } - Age: { p4.Age }");

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
