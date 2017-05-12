namespace LEARNING_CONCEPTS_Learn_04
{
	public class Person
	{
		public int Age;
		public string FullName;

		public void ShowInfo()
		{
			//System.Console.WriteLine("Full Name: {0} - Age: {1}", FullName, Age);
			System.Console.WriteLine("I'm {0} and {1} years old.", FullName, Age);

			//System.Console.WriteLine("Full Name: {0} - Age: {1}", this.FullName, this.Age);
			//System.Console.WriteLine("I'm {0} and {1} years old.", this.FullName, this.Age);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person P1 = new Person();

			P1.Age = 20;
			P1.FullName = "Ali Reza Alavi";

			P1.ShowInfo();

			Person P2 = new Person();

			P2.Age = 30;
			P2.FullName = "Sara Ahmadi";

			P2.ShowInfo();

			Person P3 = new Person();

			P3.Age = 40;
			P3.FullName = "Mohammad Ghaderi";

			P3.ShowInfo();

			Person P4 = new Person();

			P4.Age = 50;
			P4.FullName = "Reza Ghorji";

			P4.ShowInfo();

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
