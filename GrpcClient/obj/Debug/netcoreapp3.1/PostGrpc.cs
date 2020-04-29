// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/post.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  public static partial class PostSv
  {
    static readonly string __ServiceName = "greet.PostSv";

    static readonly grpc::Marshaller<global::GrpcService.PostModel> __Marshaller_greet_PostModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.PostModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.PostResult> __Marshaller_greet_PostResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.PostResult.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.PostIdModel> __Marshaller_greet_PostIdModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.PostIdModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.GetAllPostsRequest> __Marshaller_greet_GetAllPostsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.GetAllPostsRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.PostModel, global::GrpcService.PostResult> __Method_AddPost = new grpc::Method<global::GrpcService.PostModel, global::GrpcService.PostResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPost",
        __Marshaller_greet_PostModel,
        __Marshaller_greet_PostResult);

    static readonly grpc::Method<global::GrpcService.PostIdModel, global::GrpcService.PostModel> __Method_GetPost = new grpc::Method<global::GrpcService.PostIdModel, global::GrpcService.PostModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPost",
        __Marshaller_greet_PostIdModel,
        __Marshaller_greet_PostModel);

    static readonly grpc::Method<global::GrpcService.PostModel, global::GrpcService.PostResult> __Method_UpdatePost = new grpc::Method<global::GrpcService.PostModel, global::GrpcService.PostResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePost",
        __Marshaller_greet_PostModel,
        __Marshaller_greet_PostResult);

    static readonly grpc::Method<global::GrpcService.PostIdModel, global::GrpcService.PostResult> __Method_DeletePost = new grpc::Method<global::GrpcService.PostIdModel, global::GrpcService.PostResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePost",
        __Marshaller_greet_PostIdModel,
        __Marshaller_greet_PostResult);

    static readonly grpc::Method<global::GrpcService.GetAllPostsRequest, global::GrpcService.PostModel> __Method_GetAllPosts = new grpc::Method<global::GrpcService.GetAllPostsRequest, global::GrpcService.PostModel>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllPosts",
        __Marshaller_greet_GetAllPostsRequest,
        __Marshaller_greet_PostModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.PostReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for PostSv</summary>
    public partial class PostSvClient : grpc::ClientBase<PostSvClient>
    {
      /// <summary>Creates a new client for PostSv</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PostSvClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PostSv that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PostSvClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PostSvClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PostSvClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcService.PostResult AddPost(global::GrpcService.PostModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddPost(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.PostResult AddPost(global::GrpcService.PostModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddPost, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.PostResult> AddPostAsync(global::GrpcService.PostModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddPostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.PostResult> AddPostAsync(global::GrpcService.PostModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddPost, null, options, request);
      }
      public virtual global::GrpcService.PostModel GetPost(global::GrpcService.PostIdModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPost(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.PostModel GetPost(global::GrpcService.PostIdModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPost, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.PostModel> GetPostAsync(global::GrpcService.PostIdModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.PostModel> GetPostAsync(global::GrpcService.PostIdModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPost, null, options, request);
      }
      public virtual global::GrpcService.PostResult UpdatePost(global::GrpcService.PostModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePost(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.PostResult UpdatePost(global::GrpcService.PostModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdatePost, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.PostResult> UpdatePostAsync(global::GrpcService.PostModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.PostResult> UpdatePostAsync(global::GrpcService.PostModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdatePost, null, options, request);
      }
      public virtual global::GrpcService.PostResult DeletePost(global::GrpcService.PostIdModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePost(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.PostResult DeletePost(global::GrpcService.PostIdModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeletePost, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.PostResult> DeletePostAsync(global::GrpcService.PostIdModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.PostResult> DeletePostAsync(global::GrpcService.PostIdModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeletePost, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::GrpcService.PostModel> GetAllPosts(global::GrpcService.GetAllPostsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllPosts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::GrpcService.PostModel> GetAllPosts(global::GrpcService.GetAllPostsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetAllPosts, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PostSvClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PostSvClient(configuration);
      }
    }

  }
}
#endregion
