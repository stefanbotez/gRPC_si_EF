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

    /// <summary>Base class for server-side implementations of PostSv</summary>
    [grpc::BindServiceMethod(typeof(PostSv), "BindService")]
    public abstract partial class PostSvBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostResult> AddPost(global::GrpcService.PostModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostModel> GetPost(global::GrpcService.PostIdModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostResult> UpdatePost(global::GrpcService.PostModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostResult> DeletePost(global::GrpcService.PostIdModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetAllPosts(global::GrpcService.GetAllPostsRequest request, grpc::IServerStreamWriter<global::GrpcService.PostModel> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PostSvBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddPost, serviceImpl.AddPost)
          .AddMethod(__Method_GetPost, serviceImpl.GetPost)
          .AddMethod(__Method_UpdatePost, serviceImpl.UpdatePost)
          .AddMethod(__Method_DeletePost, serviceImpl.DeletePost)
          .AddMethod(__Method_GetAllPosts, serviceImpl.GetAllPosts).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PostSvBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddPost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.PostModel, global::GrpcService.PostResult>(serviceImpl.AddPost));
      serviceBinder.AddMethod(__Method_GetPost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.PostIdModel, global::GrpcService.PostModel>(serviceImpl.GetPost));
      serviceBinder.AddMethod(__Method_UpdatePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.PostModel, global::GrpcService.PostResult>(serviceImpl.UpdatePost));
      serviceBinder.AddMethod(__Method_DeletePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.PostIdModel, global::GrpcService.PostResult>(serviceImpl.DeletePost));
      serviceBinder.AddMethod(__Method_GetAllPosts, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcService.GetAllPostsRequest, global::GrpcService.PostModel>(serviceImpl.GetAllPosts));
    }

  }
}
#endregion
