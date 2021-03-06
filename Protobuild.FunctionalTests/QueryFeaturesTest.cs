﻿namespace Protobuild.Tests
{
    using Xunit;

    public class QueryFeaturesTest : ProtobuildTest
    {
        [Fact]
        public void GenerationIsCorrect()
        {
            this.SetupTest("QueryFeatures");

            var featureList = this.OtherMode("query-features", capture: true).Item1.Split(new[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
            var expectedFeatureList = new[] {
                "query-features",
                "no-resolve",
                "list-packages",
            };

            Assert.Equal(expectedFeatureList, featureList);
        }
    }
}