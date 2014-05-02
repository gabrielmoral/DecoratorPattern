using System;

namespace DecoratorPattern
{
	class IllnessInsurance : InsuranceDecorator
	{
		private const int ILLNESS_INSURANCE_COST = 20;

		private TravelInsurance travelInsurance;

		public string Description 
		{
			get 
			{
				return this.travelInsurance.Description + " + Illness";
			}
		}

		public IllnessInsurance(TravelInsurance travelInsurance)
		{
			this.travelInsurance = travelInsurance;
		}

		public int Cost ()
		{
			return ILLNESS_INSURANCE_COST + this.travelInsurance.Cost ();
		}
	}
}

