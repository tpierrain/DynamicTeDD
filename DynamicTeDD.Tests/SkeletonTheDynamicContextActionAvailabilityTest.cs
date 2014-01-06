// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SkeletonTheDynamicContextActionAvailabilityTest.cs" company="">
// //   Copyright 2014 Thomas PIERRAIN
// //   Licensed under the Apache License, Version 2.0 (the "License");
// //   you may not use this file except in compliance with the License.
// //   You may obtain a copy of the License at
// //       http://www.apache.org/licenses/LICENSE-2.0
// //   Unless required by applicable law or agreed to in writing, software
// //   distributed under the License is distributed on an "AS IS" BASIS,
// //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// //   See the License for the specific language governing permissions and
// //   limitations under the License.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace DynamicTeDD.Tests
{
    using JetBrains.ReSharper.Feature.Services.CSharp.Bulbs;
    using JetBrains.ReSharper.Intentions.CSharp.Test;
    using JetBrains.ReSharper.Intentions.Extensibility;

    using NUnit.Framework;

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
