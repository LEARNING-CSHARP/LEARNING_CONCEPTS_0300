namespace LEARNING_CONCEPTS_Learn_03
{
	public class Person
	{
		public int Age;
		public string FullName;
	}

	internal static class Program
	{
		private static void Main()
		{
			Person p1 = new Person();

			p1.Age = 20;
			p1.FullName = "Ali Reza Alavi";

			//System.Console.WriteLine($"Full Name: { p1.FullName } - Age: { p1.Age }");
			System.Console.WriteLine($"I'm { p1.FullName } and { p1.Age } years old.");

			Person p2 = new Person();

			p2.Age = 30;
			p2.FullName = "Sara Ahmadi";

			//System.Console.WriteLine($"Full Name: { p2.FullName } - Age: { p2.Age }");
			System.Console.WriteLine($"I'm { p2.FullName } and { p2.Age } years old.");

			Person p3 = new Person();

			p3.Age = 40;
			p3.FullName = "Mohammad Ghaderi";

			//System.Console.WriteLine($"Full Name: { p3.FullName } - Age: { p3.Age }");
			System.Console.WriteLine($"I'm { p3.FullName } and { p3.Age } years old.");

			Person p4 = new Person();

			p4.Age = 50;
			p4.FullName = "Reza Ghorji";

			//System.Console.WriteLine($"Full Name: { p4.FullName } - Age: { p4.Age }");
			System.Console.WriteLine($"I'm { p4.FullName } and { p4.Age } years old.");

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
