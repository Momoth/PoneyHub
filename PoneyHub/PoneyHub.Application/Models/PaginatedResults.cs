namespace PoneyHub.Application.Models
{
    public class PaginatedResults<T>
    {
        public List<T>? Results { get; set; }
        public int TotalResultsCount { get; set; }
        public int TotalPageCount { get; set; }

        public PaginatedResults(List<T>? results, int take, int totalResultsCount)
        {
            Results = results;
            TotalResultsCount = totalResultsCount;

            if (totalResultsCount == 0 || take == 0)
            {
                TotalPageCount = 0;
                return;
            }

            TotalPageCount = (int)Math.Ceiling((decimal)totalResultsCount / take);
        }
    }
}