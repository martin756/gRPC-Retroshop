# Generated by the gRPC Python protocol compiler plugin. DO NOT EDIT!
"""Client and server classes corresponding to protobuf-defined services."""
import grpc

import productos_pb2 as productos__pb2
import usuarios_pb2 as usuarios__pb2


class ProductosStub(object):
    """Missing associated documentation comment in .proto file."""

    def __init__(self, channel):
        """Constructor.

        Args:
            channel: A grpc.Channel.
        """
        self.TraerProductoById = channel.unary_unary(
                '/Productos/TraerProductoById',
                request_serializer=productos__pb2.IdProducto.SerializeToString,
                response_deserializer=productos__pb2.ProductoGet.FromString,
                )
        self.TraerProductoByUsuario = channel.unary_unary(
                '/Productos/TraerProductoByUsuario',
                request_serializer=productos__pb2.IdUsuario.SerializeToString,
                response_deserializer=productos__pb2.ProductoGet.FromString,
                )
        self.AltaProducto = channel.unary_unary(
                '/Productos/AltaProducto',
                request_serializer=productos__pb2.ProductoPost.SerializeToString,
                response_deserializer=usuarios__pb2.Response.FromString,
                )
        self.EditarProducto = channel.unary_unary(
                '/Productos/EditarProducto',
                request_serializer=productos__pb2.ProductoPut.SerializeToString,
                response_deserializer=usuarios__pb2.Response.FromString,
                )


class ProductosServicer(object):
    """Missing associated documentation comment in .proto file."""

    def TraerProductoById(self, request, context):
        """Missing associated documentation comment in .proto file."""
        context.set_code(grpc.StatusCode.UNIMPLEMENTED)
        context.set_details('Method not implemented!')
        raise NotImplementedError('Method not implemented!')

    def TraerProductoByUsuario(self, request, context):
        """Missing associated documentation comment in .proto file."""
        context.set_code(grpc.StatusCode.UNIMPLEMENTED)
        context.set_details('Method not implemented!')
        raise NotImplementedError('Method not implemented!')

    def AltaProducto(self, request, context):
        """Missing associated documentation comment in .proto file."""
        context.set_code(grpc.StatusCode.UNIMPLEMENTED)
        context.set_details('Method not implemented!')
        raise NotImplementedError('Method not implemented!')

    def EditarProducto(self, request, context):
        """Missing associated documentation comment in .proto file."""
        context.set_code(grpc.StatusCode.UNIMPLEMENTED)
        context.set_details('Method not implemented!')
        raise NotImplementedError('Method not implemented!')


def add_ProductosServicer_to_server(servicer, server):
    rpc_method_handlers = {
            'TraerProductoById': grpc.unary_unary_rpc_method_handler(
                    servicer.TraerProductoById,
                    request_deserializer=productos__pb2.IdProducto.FromString,
                    response_serializer=productos__pb2.ProductoGet.SerializeToString,
            ),
            'TraerProductoByUsuario': grpc.unary_unary_rpc_method_handler(
                    servicer.TraerProductoByUsuario,
                    request_deserializer=productos__pb2.IdUsuario.FromString,
                    response_serializer=productos__pb2.ProductoGet.SerializeToString,
            ),
            'AltaProducto': grpc.unary_unary_rpc_method_handler(
                    servicer.AltaProducto,
                    request_deserializer=productos__pb2.ProductoPost.FromString,
                    response_serializer=usuarios__pb2.Response.SerializeToString,
            ),
            'EditarProducto': grpc.unary_unary_rpc_method_handler(
                    servicer.EditarProducto,
                    request_deserializer=productos__pb2.ProductoPut.FromString,
                    response_serializer=usuarios__pb2.Response.SerializeToString,
            ),
    }
    generic_handler = grpc.method_handlers_generic_handler(
            'Productos', rpc_method_handlers)
    server.add_generic_rpc_handlers((generic_handler,))


 # This class is part of an EXPERIMENTAL API.
class Productos(object):
    """Missing associated documentation comment in .proto file."""

    @staticmethod
    def TraerProductoById(request,
            target,
            options=(),
            channel_credentials=None,
            call_credentials=None,
            insecure=False,
            compression=None,
            wait_for_ready=None,
            timeout=None,
            metadata=None):
        return grpc.experimental.unary_unary(request, target, '/Productos/TraerProductoById',
            productos__pb2.IdProducto.SerializeToString,
            productos__pb2.ProductoGet.FromString,
            options, channel_credentials,
            insecure, call_credentials, compression, wait_for_ready, timeout, metadata)

    @staticmethod
    def TraerProductoByUsuario(request,
            target,
            options=(),
            channel_credentials=None,
            call_credentials=None,
            insecure=False,
            compression=None,
            wait_for_ready=None,
            timeout=None,
            metadata=None):
        return grpc.experimental.unary_unary(request, target, '/Productos/TraerProductoByUsuario',
            productos__pb2.IdUsuario.SerializeToString,
            productos__pb2.ProductoGet.FromString,
            options, channel_credentials,
            insecure, call_credentials, compression, wait_for_ready, timeout, metadata)

    @staticmethod
    def AltaProducto(request,
            target,
            options=(),
            channel_credentials=None,
            call_credentials=None,
            insecure=False,
            compression=None,
            wait_for_ready=None,
            timeout=None,
            metadata=None):
        return grpc.experimental.unary_unary(request, target, '/Productos/AltaProducto',
            productos__pb2.ProductoPost.SerializeToString,
            usuarios__pb2.Response.FromString,
            options, channel_credentials,
            insecure, call_credentials, compression, wait_for_ready, timeout, metadata)

    @staticmethod
    def EditarProducto(request,
            target,
            options=(),
            channel_credentials=None,
            call_credentials=None,
            insecure=False,
            compression=None,
            wait_for_ready=None,
            timeout=None,
            metadata=None):
        return grpc.experimental.unary_unary(request, target, '/Productos/EditarProducto',
            productos__pb2.ProductoPut.SerializeToString,
            usuarios__pb2.Response.FromString,
            options, channel_credentials,
            insecure, call_credentials, compression, wait_for_ready, timeout, metadata)