namespace DynamicTeDD.Tests.test.data.SkeletonTheDynamicContextAction
{
    using System;
    using Microsoft.CSharp;
    using NUnit.Framework;

    [TestFixture]
    public class SampleTests
    {
        [Test]
        public void FirstTestWithDynamic()
        {
            dynamic myModelingClayInstance = new object();

            Assert.IsTrue(myModelingClayInstance.Portnaouaq());

            string temp = "satchm{caret}o";
        }

    }
}
