using System;
using System.Collections.Generic;

namespace SmallTalkin.Core
{
    public class RecommendationService
    {
        private readonly Random randomizer;

        private List<RecommendationItem> recommendationItems = new List<RecommendationItem>()
        {
            new RecommendationItem() {Id = 1, Value = "Are you reading any good books right now? I’d love some recommendations. How about shows?"},
            new RecommendationItem() {Id = 2, Value = "What’s a book you hated that everyone else loved?"},
            new RecommendationItem() {Id = 2, Value = "Who is your favorite person to follow on Instagram?"},
            new RecommendationItem() {Id = 2, Value = "If you could only eat one thing for the rest of your life, what would it be?"},
            new RecommendationItem() {Id = 2, Value = "What are the best cheap eats around here?"},
            new RecommendationItem() {Id = 2, Value = "What's the best way to indent code - tabs or spaces?"},
        };

        public RecommendationService()
        {
            this.randomizer = new Random();
        }

        public string GetRecommendation()
        {
            return this.recommendationItems[this.randomizer.Next(this.recommendationItems.Count)]?.Value;
        }
    }
}