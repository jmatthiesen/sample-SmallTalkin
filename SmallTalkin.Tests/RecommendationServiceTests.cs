using System;
using Xunit;
using SmallTalkin.Core;

namespace SmallTalkin.Tests
{
    public class RecommendationServiceTests
    {
        [Fact]
        public void GetRecommendation()
        {
            var recommendationService = new RecommendationService();
            var recommendation = recommendationService.GetRecommendation();

            Assert.False(String.IsNullOrEmpty(recommendation));
        }
    }
}
