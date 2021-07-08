using AzureDevops.Model;
using System.Collections.Generic;

namespace AzureDevops.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
