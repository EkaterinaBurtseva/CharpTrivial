
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Properties
{
    public  static class Check
    {

        public static void Equals(string expectedResult, string actualResult,  bool fail, string message)
        {

            try
            {
                Assert.AreEqual(expectedResult, actualResult);
            }
            catch (Exception ex)
            {
                // LOG Fail
                // log screenshot

                if (fail)
                {
                    Assert.Fail(message);
                }
            }

        }
    }
}
