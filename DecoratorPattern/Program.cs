using System;

namespace DecoratorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			TravelInsurance travelInsurance = new SilverTravelInsurance ();

			travelInsurance = new StealingInsurance (travelInsurance);
			travelInsurance = new IllnessInsurance (travelInsurance);

			Console.WriteLine (travelInsurance.Description);
			Console.WriteLine (travelInsurance.Cost ());
		}
	}
}

