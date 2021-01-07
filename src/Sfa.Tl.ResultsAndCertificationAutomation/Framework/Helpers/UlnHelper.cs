using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using System;
using System.Linq;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class UlnHelper
    {
        public static long GenerateUln()
		{
            // Step 1: Get all Ulns
            var existingUlns = SqlQueries.UlnListFromDb();
            Random random = new Random();
            // Step 2: Random number Genera
            bool sameUln = true;
            long result = 0;
            while (sameUln)
            {
                result = 9900000000 + random.Next(10000000, 99999999);
                sameUln = existingUlns.Contains(result);
			}
            //Console.WriteLine("Random number is: " + result);
            return result;
        }
    }
}
