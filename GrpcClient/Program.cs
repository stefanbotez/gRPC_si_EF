using System;
using System.Net.Http;
using System.Threading.Tasks;
using GrpcService;
using Grpc.Net.Client;
using Grpc.Core.Interceptors;
using Google.Protobuf.WellKnownTypes;
using System.Threading;

namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClientHandler = new HttpClientHandler();
            // Return `true` to allow certificates that are untrusted/invalid
            httpClientHandler.ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var httpClient = new HttpClient(httpClientHandler);

            var channel = GrpcChannel.ForAddress("https://localhost:5001",
                new GrpcChannelOptions { HttpClient = httpClient });
            var PC = new PostSv.PostSvClient(channel);
            var result = await PC.AddPostAsync(
                new PostModel
                {
                    Id = 9,
                    Description = "DESCRIPTIONX",
                    Domain = "DOMAINX",
                    Date = Timestamp.FromDateTime(DateTime.UtcNow)
                });
            Console.WriteLine("Result: " + result.Message);
            var result2 = await PC.AddPostAsync(
            new PostModel
            {
                Id = 14,
                Description = "DESCRIPTIONXX",
                Domain = "DOMAINXX",
                Date = Timestamp.FromDateTime(DateTime.UtcNow)
            });
            Console.WriteLine("Result: " + result2.Message);

            using (var call = PC.GetAllPosts(new GetAllPostsRequest()))
            {
                while(await call.ResponseStream.MoveNext(CancellationToken.None))
                {
                    var currentPost = call.ResponseStream.Current;
                    Console.WriteLine($"{currentPost.Domain} {currentPost.Description}");
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}