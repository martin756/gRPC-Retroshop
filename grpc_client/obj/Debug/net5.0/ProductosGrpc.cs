// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: productos.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class Productos
{
  static readonly string __ServiceName = "Productos";

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
  {
    #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
    if (message is global::Google.Protobuf.IBufferMessage)
    {
      context.SetPayloadLength(message.CalculateSize());
      global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
      context.Complete();
      return;
    }
    #endif
    context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
  }

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static class __Helper_MessageCache<T>
  {
    public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
  }

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
  {
    #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
    if (__Helper_MessageCache<T>.IsBufferMessage)
    {
      return parser.ParseFrom(context.PayloadAsReadOnlySequence());
    }
    #endif
    return parser.ParseFrom(context.PayloadAsNewBuffer());
  }

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::IdProducto> __Marshaller_IdProducto = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::IdProducto.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::ProductoGet> __Marshaller_ProductoGet = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductoGet.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::Nulo> __Marshaller_Nulo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Nulo.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::Producto> __Marshaller_Producto = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Producto.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::ProductoPost> __Marshaller_ProductoPost = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductoPost.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::Response> __Marshaller_Response = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Response.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::ProductoPut> __Marshaller_ProductoPut = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductoPut.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::ProductoStock> __Marshaller_ProductoStock = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductoStock.Parser));

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::IdProducto, global::ProductoGet> __Method_TraerProductoById = new grpc::Method<global::IdProducto, global::ProductoGet>(
      grpc::MethodType.Unary,
      __ServiceName,
      "TraerProductoById",
      __Marshaller_IdProducto,
      __Marshaller_ProductoGet);

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::Nulo, global::Producto> __Method_TraerProductos = new grpc::Method<global::Nulo, global::Producto>(
      grpc::MethodType.ServerStreaming,
      __ServiceName,
      "TraerProductos",
      __Marshaller_Nulo,
      __Marshaller_Producto);

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::ProductoPost, global::Response> __Method_AltaProducto = new grpc::Method<global::ProductoPost, global::Response>(
      grpc::MethodType.Unary,
      __ServiceName,
      "AltaProducto",
      __Marshaller_ProductoPost,
      __Marshaller_Response);

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::ProductoPut, global::Response> __Method_EditarProducto = new grpc::Method<global::ProductoPut, global::Response>(
      grpc::MethodType.Unary,
      __ServiceName,
      "EditarProducto",
      __Marshaller_ProductoPut,
      __Marshaller_Response);

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::ProductoStock, global::Response> __Method_ActualizarStock = new grpc::Method<global::ProductoStock, global::Response>(
      grpc::MethodType.Unary,
      __ServiceName,
      "ActualizarStock",
      __Marshaller_ProductoStock,
      __Marshaller_Response);

  /// <summary>Service descriptor</summary>
  public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
  {
    get { return global::ProductosReflection.Descriptor.Services[0]; }
  }

  /// <summary>Base class for server-side implementations of Productos</summary>
  [grpc::BindServiceMethod(typeof(Productos), "BindService")]
  public abstract partial class ProductosBase
  {
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::ProductoGet> TraerProductoById(global::IdProducto request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task TraerProductos(global::Nulo request, grpc::IServerStreamWriter<global::Producto> responseStream, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::Response> AltaProducto(global::ProductoPost request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::Response> EditarProducto(global::ProductoPut request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::Response> ActualizarStock(global::ProductoStock request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

  }

  /// <summary>Client for Productos</summary>
  public partial class ProductosClient : grpc::ClientBase<ProductosClient>
  {
    /// <summary>Creates a new client for Productos</summary>
    /// <param name="channel">The channel to use to make remote calls.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public ProductosClient(grpc::ChannelBase channel) : base(channel)
    {
    }
    /// <summary>Creates a new client for Productos that uses a custom <c>CallInvoker</c>.</summary>
    /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public ProductosClient(grpc::CallInvoker callInvoker) : base(callInvoker)
    {
    }
    /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    protected ProductosClient() : base()
    {
    }
    /// <summary>Protected constructor to allow creation of configured clients.</summary>
    /// <param name="configuration">The client configuration.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    protected ProductosClient(ClientBaseConfiguration configuration) : base(configuration)
    {
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::ProductoGet TraerProductoById(global::IdProducto request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return TraerProductoById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::ProductoGet TraerProductoById(global::IdProducto request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_TraerProductoById, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::ProductoGet> TraerProductoByIdAsync(global::IdProducto request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return TraerProductoByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::ProductoGet> TraerProductoByIdAsync(global::IdProducto request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_TraerProductoById, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncServerStreamingCall<global::Producto> TraerProductos(global::Nulo request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return TraerProductos(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncServerStreamingCall<global::Producto> TraerProductos(global::Nulo request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncServerStreamingCall(__Method_TraerProductos, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::Response AltaProducto(global::ProductoPost request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return AltaProducto(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::Response AltaProducto(global::ProductoPost request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_AltaProducto, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::Response> AltaProductoAsync(global::ProductoPost request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return AltaProductoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::Response> AltaProductoAsync(global::ProductoPost request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_AltaProducto, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::Response EditarProducto(global::ProductoPut request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return EditarProducto(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::Response EditarProducto(global::ProductoPut request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_EditarProducto, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::Response> EditarProductoAsync(global::ProductoPut request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return EditarProductoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::Response> EditarProductoAsync(global::ProductoPut request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_EditarProducto, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::Response ActualizarStock(global::ProductoStock request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return ActualizarStock(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::Response ActualizarStock(global::ProductoStock request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_ActualizarStock, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::Response> ActualizarStockAsync(global::ProductoStock request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return ActualizarStockAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::Response> ActualizarStockAsync(global::ProductoStock request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_ActualizarStock, null, options, request);
    }
    /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    protected override ProductosClient NewInstance(ClientBaseConfiguration configuration)
    {
      return new ProductosClient(configuration);
    }
  }

  /// <summary>Creates service definition that can be registered with a server</summary>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  public static grpc::ServerServiceDefinition BindService(ProductosBase serviceImpl)
  {
    return grpc::ServerServiceDefinition.CreateBuilder()
        .AddMethod(__Method_TraerProductoById, serviceImpl.TraerProductoById)
        .AddMethod(__Method_TraerProductos, serviceImpl.TraerProductos)
        .AddMethod(__Method_AltaProducto, serviceImpl.AltaProducto)
        .AddMethod(__Method_EditarProducto, serviceImpl.EditarProducto)
        .AddMethod(__Method_ActualizarStock, serviceImpl.ActualizarStock).Build();
  }

  /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
  /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
  /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductosBase serviceImpl)
  {
    serviceBinder.AddMethod(__Method_TraerProductoById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::IdProducto, global::ProductoGet>(serviceImpl.TraerProductoById));
    serviceBinder.AddMethod(__Method_TraerProductos, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Nulo, global::Producto>(serviceImpl.TraerProductos));
    serviceBinder.AddMethod(__Method_AltaProducto, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductoPost, global::Response>(serviceImpl.AltaProducto));
    serviceBinder.AddMethod(__Method_EditarProducto, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductoPut, global::Response>(serviceImpl.EditarProducto));
    serviceBinder.AddMethod(__Method_ActualizarStock, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductoStock, global::Response>(serviceImpl.ActualizarStock));
  }

}
#endregion
