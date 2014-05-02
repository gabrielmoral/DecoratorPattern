using System;

namespace DecoratorPattern
{
	class SilverTravelInsurance : TravelInsurance
	{
		private const int INSURANCE_COST = 200;

		private string description = "Silver travel insurance";

		public string Description 
		{
			get 
			{
				return this.description;
			}
		}

		public int Cost ()
		{
			return INSURANCE_COST;
		}
	}
}

