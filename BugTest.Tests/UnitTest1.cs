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
