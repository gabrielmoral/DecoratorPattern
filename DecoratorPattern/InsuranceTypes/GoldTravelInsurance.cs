using System;

namespace DecoratorPattern
{
	class GoldTravelInsurance : TravelInsurance
	{
		private const int INSURANCE_COST = 500;

		private string description = "Gold travel insurance";

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

