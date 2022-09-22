# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: facturas.proto
"""Generated protocol buffer code."""
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import carritos_pb2 as carritos__pb2
import usuarios_pb2 as usuarios__pb2
import productos_pb2 as productos__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\x0e\x66\x61\x63turas.proto\x1a\x0e\x63\x61rritos.proto\x1a\x0eusuarios.proto\x1a\x0fproductos.proto\"\xb7\x01\n\x07\x46\x61\x63tura\x12\x11\n\tidfactura\x18\x01 \x01(\x05\x12\x1a\n\x12idproducto_carrito\x18\x02 \x01(\x05\x12\x13\n\x0b\x66\x65\x63hacompra\x18\x03 \x01(\t\x12\x10\n\x08\x63\x61ntidad\x18\x04 \x01(\x02\x12\x0e\n\x06precio\x18\x05 \x01(\x02\x12\r\n\x05total\x18\x06 \x01(\x02\x12\x1a\n\x12vendedor_idusuario\x18\x07 \x01(\x05\x12\x1b\n\x13\x63omprador_idusuario\x18\x08 \x01(\x05\"/\n\x11IdProductoCarrito\x12\x1a\n\x12idproducto_carrito\x18\x01 \x01(\x05\"\x1e\n\tIdFactura\x12\x11\n\tidfactura\x18\x01 \x01(\x05\"&\n\x17ResponseImprimirFactura\x12\x0b\n\x03pdf\x18\x01 \x01(\t2\xa6\x01\n\x08\x46\x61\x63turas\x12.\n\x0c\x43rearFactura\x12\x12.IdProductoCarrito\x1a\n.IdFactura\x12\x31\n\x17TraerFacturaByIdUsuario\x12\n.IdUsuario\x1a\x08.Factura0\x01\x12\x37\n\x0fImprimirFactura\x12\n.IdFactura\x1a\x18.ResponseImprimirFacturab\x06proto3')



_FACTURA = DESCRIPTOR.message_types_by_name['Factura']
_IDPRODUCTOCARRITO = DESCRIPTOR.message_types_by_name['IdProductoCarrito']
_IDFACTURA = DESCRIPTOR.message_types_by_name['IdFactura']
_RESPONSEIMPRIMIRFACTURA = DESCRIPTOR.message_types_by_name['ResponseImprimirFactura']
Factura = _reflection.GeneratedProtocolMessageType('Factura', (_message.Message,), {
  'DESCRIPTOR' : _FACTURA,
  '__module__' : 'facturas_pb2'
  # @@protoc_insertion_point(class_scope:Factura)
  })
_sym_db.RegisterMessage(Factura)

IdProductoCarrito = _reflection.GeneratedProtocolMessageType('IdProductoCarrito', (_message.Message,), {
  'DESCRIPTOR' : _IDPRODUCTOCARRITO,
  '__module__' : 'facturas_pb2'
  # @@protoc_insertion_point(class_scope:IdProductoCarrito)
  })
_sym_db.RegisterMessage(IdProductoCarrito)

IdFactura = _reflection.GeneratedProtocolMessageType('IdFactura', (_message.Message,), {
  'DESCRIPTOR' : _IDFACTURA,
  '__module__' : 'facturas_pb2'
  # @@protoc_insertion_point(class_scope:IdFactura)
  })
_sym_db.RegisterMessage(IdFactura)

ResponseImprimirFactura = _reflection.GeneratedProtocolMessageType('ResponseImprimirFactura', (_message.Message,), {
  'DESCRIPTOR' : _RESPONSEIMPRIMIRFACTURA,
  '__module__' : 'facturas_pb2'
  # @@protoc_insertion_point(class_scope:ResponseImprimirFactura)
  })
_sym_db.RegisterMessage(ResponseImprimirFactura)

_FACTURAS = DESCRIPTOR.services_by_name['Facturas']
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _FACTURA._serialized_start=68
  _FACTURA._serialized_end=251
  _IDPRODUCTOCARRITO._serialized_start=253
  _IDPRODUCTOCARRITO._serialized_end=300
  _IDFACTURA._serialized_start=302
  _IDFACTURA._serialized_end=332
  _RESPONSEIMPRIMIRFACTURA._serialized_start=334
  _RESPONSEIMPRIMIRFACTURA._serialized_end=372
  _FACTURAS._serialized_start=375
  _FACTURAS._serialized_end=541
# @@protoc_insertion_point(module_scope)