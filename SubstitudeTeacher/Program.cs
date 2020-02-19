using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using RefactoredECS;

namespace SubstitudeTeacher
{
    [TestFixture]
    class Sub_tester
    {
        private IHeater heater;
        private ISensor sensor;

        [SetUp]
        public void Setup()
        {
            heater = Substitute.For<IHeater>();
            sensor = Substitute.For<ISensor>();

        }

        [Test]
        public void test_Heater()
        {

        }
    }
}
