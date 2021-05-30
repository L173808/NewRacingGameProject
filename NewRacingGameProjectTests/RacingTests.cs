using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewRacingGameProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRacingGameProject.Tests
{
    [TestClass()]
    public class RacingTests
    {
        [TestMethod()]
        public void RacingTest()
        {
            Plyers obj = new Plyers();
            obj.miller = 100;
            if (obj.miller > 0)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
            
        }

        [TestMethod()]
        public void RacingTest2()
        {
            Plyers obj = new Plyers();
            obj.joe = 100;
            if (obj.joe > 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

        }


    }
}