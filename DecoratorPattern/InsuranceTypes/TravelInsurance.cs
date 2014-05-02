using System;

namespace DecoratorPattern
{
	interface TravelInsurance
	{
		String Description { get; }

		int Cost ();
	}
}

