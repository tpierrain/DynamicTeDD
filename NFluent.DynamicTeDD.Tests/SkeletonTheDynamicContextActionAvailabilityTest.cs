using JetBrains.ReSharper.Feature.Services.Bulbs;
using JetBrains.ReSharper.Feature.Services.CSharp.Bulbs;
using JetBrains.ReSharper.Intentions.CSharp.Test;
using JetBrains.ReSharper.Intentions.Extensibility;
using NUnit.Framework;

namespace NFluent.DynamicTeDD.Tests
{
    [TestFixture]
    public class SkeletonTheDynamicContextActionAvailabilityTest : CSharpContextActionAvailabilityTestBase
    {
        protected override string ExtraPath
        {
            get { return "SkeletonTheDynamicContextAction"; }
        }

        protected override IContextAction CreateContextAction(ICSharpContextActionDataProvider dataProvider)
        {
            // todo: return a new instance of your context action, e.g.:
            // return new ClassNameContextAction(dataProvider);
            return null;
        }

        [TestCase("availability01")]
        [Test]
        public void TestCases(string testSrc)
        {
            DoOneTest(testSrc);
        }
    }
}
