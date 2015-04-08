using System;

namespace TrustpilotDemo.Repositories
{
    public interface IBlogRepo
    {
        Models.BlogPost GetBlogPost();
    }
}