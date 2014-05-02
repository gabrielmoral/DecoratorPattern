using System;

namespace DecoratorPattern
{
	class StealingInsurance : InsuranceDecorator
	{
		private const int STEALING_INSURANCE_COST = 35;

		private TravelInsurance travelInsurance;

		public string Description 
		{
			get 
			{
				return this.travelInsurance.Description + " + Stealing";
			}
		}

		public StealingInsurance(TravelInsurance travelInsurance)
		{
			this.travelInsurance = travelInsurance;
		}

		public int Cost ()
		{
			return STEALING_INSURANCE_COST + this.travelInsurance.Cost ();
		}
	}
}

