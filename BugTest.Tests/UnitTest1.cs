using System;
using System.Threading.Tasks;
using BugTest.Contract;
using BugTest.ViewModels;
using BugTest.Views;
using Microsoft.Practices.Unity;
using Moq;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace BugTest.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public async Task TestMethod1()
        {
            string message = "This is the message";
            var test = new TestHelper();

            test.Google.Setup(f => f.CallGoogle()).ReturnsAsync(message);
            test.Network.Setup(f => f.IsConnectedToInternet()).Returns(true);

            var model = test.Container.Resolve<TestPageViewModel>();

            //await test.CallAsync(model);
            //await model.async();

            Assert.IsTrue(model.AsyncRan);
            Assert.AreEqual(message, model.Display);
        }
    }

    public class TestHelper
    {
        public IUnityContainer Container = new UnityContainer();
        public Mock<IGoogleCall> Google;
        public Mock<INetworkConnection> Network;

        public TestHelper()
        {
            Google = new Mock<IGoogleCall>();
            Network = new Mock<INetworkConnection>();
            Register();
        }

        //public async Task CallAsync(TestPageViewModel model)
        //{
        //   model.async();
        //}

        public void Register()
        {
            Container.RegisterInstance(Google.Object);
            Container.RegisterInstance(Network.Object);
        }

        public void Reset()
        {
            Google.Reset();
            Network.Reset();
        }

        //public static async Task<TestHelper> GetTestHelper()
        //{
        //    TestHelper result = new TestHelper();
        //    result.Register();
        //    return result;
        //}
    }
}
