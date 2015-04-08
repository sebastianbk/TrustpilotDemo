using System;

namespace TrustpilotDemo.Repositories
{
    public class BlogRepo : IBlogRepo
    {
        public Models.BlogPost GetBlogPost()
        {
            var post = new Models.BlogPost
            {
                Id = 123,
                Title = "TRUSTPILOT & CNUG ROCKS!",
                Content = "ASP.NET 5 is the most awesome thing ever!"
            };

            return post;
        }
    }
}