﻿namespace MB15
{
    public class SearchResult {
        public int? PositionFound { get; set; }
        public long Ticks { get; set; }
    }

    public class SearchResults {
        public int ArrayCount { get; set; }
        public SearchResult MinValue { get; set; } = new SearchResult();
        public SearchResult MaxValue { get; set; } = new SearchResult();
        public SearchResult AvgValue { get; set; } = new SearchResult();
        public SearchResult RandomValue { get; set; } = new SearchResult();
        public SearchResult NotFoundValue { get; set; } = new SearchResult();
    }
}
