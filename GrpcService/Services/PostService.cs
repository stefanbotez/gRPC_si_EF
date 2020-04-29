using GrpcService;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostComment.APIStatic;
using Grpc.Core;
using PostComment;
using Google.Protobuf.WellKnownTypes;

namespace GrpcService
{
    public class PostService : PostSv.PostSvBase
    {
        private readonly ILogger<PostService> _logger;

        public PostService(ILogger<PostService> logger)
        {
            _logger = logger;
        }

        public override Task<PostModel> GetPost(PostIdModel request, ServerCallContext context)
        {
            Post post = API.GetPostById(request.Id);

            return Task.FromResult(new PostModel
            {
                Id = post.PostId,
                Description = post.Description,
                Domain = post.Domain,
                Date = Timestamp.FromDateTime(post.Date)
            });
        }

        public override Task<PostResult> AddPost(PostModel request, ServerCallContext context)
        {
            Post post = new Post();
            post.Description = request.Description;
            post.Domain = request.Domain;
            post.Date = request.Date.ToDateTime();
            var result = API.AddPost(post);
            if (result)
                return Task.FromResult(new PostResult { Message = "GOOD" });
            else
                return Task.FromResult(new PostResult { Message = "BAD" });
        }

        public override Task<PostResult> UpdatePost(PostModel request, ServerCallContext context)
        {
            Post post = new Post();
            post.Description = request.Description;
            post.Domain = request.Domain;
            post.Date = request.Date.ToDateTime();
            var result = API.UpdatePost(post);
            if (result != null)
                return Task.FromResult(new PostResult { Message = "GOOD" });
            else
                return Task.FromResult(new PostResult { Message = "BAD" });
        }

        public override Task<PostResult> DeletePost(PostIdModel request, ServerCallContext context)
        {
            var result = API.DeletePost(request.Id);
            if (result != 0)
                return Task.FromResult(new PostResult { Message = "GOOD" });
            else
                return Task.FromResult(new PostResult { Message = "BAD" });
        }

        public override async Task GetAllPosts(
            GetAllPostsRequest request, 
            IServerStreamWriter<PostModel> responseStream, 
            ServerCallContext context)
        {
            foreach(var post in API.GetAllPosts())
            {
                PostModel pm = new PostModel
                {
                    Id = post.PostId,
                    Description = post.Description,
                    Domain = post.Domain,
                    Date = Timestamp.FromDateTime(post.Date)
                };
                await responseStream.WriteAsync(pm);
            }
        }
    }
}
