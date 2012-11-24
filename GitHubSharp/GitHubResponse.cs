using System;

namespace GitHubSharp
{
    public class GitHubResponse<T> where T : class
    {
        public int RateLimitLimit { get; set; }
        public int RateLimitRemaining { get; set; }
        public Pagination Next { get; set; }
        public Pagination Prev { get; set; }
        public T Data { get; set; }

        public class Pagination
        {
            public uint Page { get; set; }
            public uint PerPage { get; set; }

            public Pagination(uint page, uint perPage)
            {
                Page = page;
                PerPage = perPage;
            }
        }
    }
}
