using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using RefactoredECS;
using ECS = RefactoredECS.ECS;

namespace SubstitudeTeacher
{
    [TestFixture]
    class Sub_tester
    {
        private IHeater _heater;
        private ISensor _sensor;
        private IWindow _window;
        private RefactoredECS.ECS _uut;

        [SetUp]
        public void Setup()
        {
            _heater = Substitute.For<IHeater>();
            _sensor = Substitute.For<ISensor>();
            _window = Substitute.For<IWindow>();

            _uut = new RefactoredECS.ECS(_sensor,_heater,_window,30,50);
            
        }

        [Test]
        public void test_HeaterTurnedOn()
        {
            _sensor.GetTemp().Returns(_uut.LowerTemperatureThreshold - 20);
            _uut.Regulate();
            _heater.Received(1).TurnOn();
        }

        [Test]
        public void test_Window_closed()
        {
            _sensor.GetTemp().Returns(_uut.LowerTemperatureThreshold - 20);
            _uut.Regulate();
            _window.Received(1).Close();

        }
    }
}
