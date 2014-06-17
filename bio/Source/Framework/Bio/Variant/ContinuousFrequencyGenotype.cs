﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bio.Variant
{
	public abstract class ContinuousFrequencyGenotype
	{

		public GenotypeCallResult ResultType;

		public abstract List<string> GetGenotypesPresent();

		public abstract List<double> GetGenotypeFrequencies();

		public ContinuousFrequencyGenotype(GenotypeCallResult res)
		{
			ResultType = res;
		}
	}
}

