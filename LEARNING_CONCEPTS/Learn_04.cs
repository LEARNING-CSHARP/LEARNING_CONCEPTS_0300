namespace LEARNING_CONCEPTS_Learn_04
{
	public class Person
	{
		public int Age;
		public string FullName;

		public void ShowInformation()
		{
			//string result =
			//	"I'm " + FullName + " and " + Age + " years old.";

			//string result =
			//	string.Format("I'm {0} and {1} years old.", FullName, Age);

			//string result =
			//	$"I'm {FullName} and {Age} years old.";

			//string result =
			//	$"I'm { FullName } and { Age } years old.";

			string result =
				$"Full Name: { FullName } - Age: { Age }";

			System.Console.WriteLine(result);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person();

			p1.Age = 20;
			p1.FullName = "Ali Reza Alavi";

			p1.ShowInformation();

			Person p2 = new Person();

			p2.Age = 30;
			p2.FullName = "Sara Ahmadi";

			p2.ShowInformation();

			Person p3 = new Person();

			p3.Age = 40;
			p3.FullName = "Mohammad Ghaderi";

			p3.ShowInformation();

			Person p4 = new Person();

			p4.Age = 50;
			p4.FullName = "Reza Ghorji";

			p4.ShowInformation();

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
