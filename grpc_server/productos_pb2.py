# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: productos.proto
"""Generated protocol buffer code."""
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import usuarios_pb2 as usuarios__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor.FileDescriptor(
  name='productos.proto',
  package='',
  syntax='proto3',
  serialized_options=None,
  create_key=_descriptor._internal_create_key,
  serialized_pb=b'\n\x0fproductos.proto\x1a\x0eusuarios.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xc9\x02\n\x08Producto\x12\x12\n\nidproducto\x18\x01 \x01(\x05\x12\x0e\n\x06nombre\x18\x02 \x01(\t\x12\x13\n\x0b\x64\x65scripcion\x18\x03 \x01(\t\x12\x17\n\x0fidtipocategoria\x18\x04 \x01(\x05\x12\x0e\n\x06precio\x18\x05 \x01(\x02\x12\x1b\n\x13\x63\x61ntidad_disponible\x18\x06 \x01(\x03\x12\x19\n\x11\x66\x65\x63ha_publicacion\x18\x07 \x01(\t\x12\x1c\n\x14publicador_idusuario\x18\x08 \x01(\x05\x12\x11\n\turl_fotos\x18\t \x03(\t\x12\x11\n\tesSubasta\x18\n \x01(\x08\x12\x30\n\x0c\x66\x65\x63ha_inicio\x18\x0b \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12-\n\tfecha_fin\x18\x0c \x01(\x0b\x32\x1a.google.protobuf.Timestamp\"-\n\rProductosList\x12\x1c\n\tproductos\x18\x01 \x03(\x0b\x32\t.Producto\"\xa8\x02\n\x0bProductoGet\x12\x0e\n\x06nombre\x18\x01 \x01(\t\x12\x13\n\x0b\x64\x65scripcion\x18\x02 \x01(\t\x12\x11\n\tcategoria\x18\x03 \x01(\t\x12\x0e\n\x06precio\x18\x04 \x01(\x02\x12\x1b\n\x13\x63\x61ntidad_disponible\x18\x05 \x01(\x03\x12\x19\n\x11\x66\x65\x63ha_publicacion\x18\x06 \x01(\t\x12\x12\n\npublicador\x18\x07 \x01(\t\x12\x11\n\turl_fotos\x18\x08 \x03(\t\x12\x11\n\tesSubasta\x18\t \x01(\x08\x12\x30\n\x0c\x66\x65\x63ha_inicio\x18\n \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12-\n\tfecha_fin\x18\x0b \x01(\x0b\x32\x1a.google.protobuf.Timestamp\"\xb9\x02\n\x0cProductoPost\x12\x0e\n\x06nombre\x18\x01 \x01(\t\x12\x13\n\x0b\x64\x65scripcion\x18\x02 \x01(\t\x12\x17\n\x0fidtipocategoria\x18\x03 \x01(\x03\x12\x0e\n\x06precio\x18\x04 \x01(\x02\x12\x1b\n\x13\x63\x61ntidad_disponible\x18\x05 \x01(\x03\x12\x19\n\x11\x66\x65\x63ha_publicacion\x18\x06 \x01(\t\x12\x1c\n\x14publicador_idusuario\x18\x07 \x01(\x03\x12\x11\n\turl_fotos\x18\x08 \x03(\t\x12\x11\n\tesSubasta\x18\t \x01(\x08\x12\x30\n\x0c\x66\x65\x63ha_inicio\x18\n \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12-\n\tfecha_fin\x18\x0b \x01(\x0b\x32\x1a.google.protobuf.Timestamp\"\x9f\x01\n\x0bProductoPut\x12\x12\n\nidproducto\x18\x01 \x01(\x05\x12\x0e\n\x06nombre\x18\x02 \x01(\t\x12\x13\n\x0b\x64\x65scripcion\x18\x03 \x01(\t\x12\x17\n\x0fidtipocategoria\x18\x04 \x01(\x03\x12\x0e\n\x06precio\x18\x05 \x01(\x02\x12\x1b\n\x13\x63\x61ntidad_disponible\x18\x06 \x01(\x03\x12\x11\n\turl_fotos\x18\x07 \x03(\t\" \n\x0eTipo_categoria\x12\x0e\n\x06nombre\x18\x01 \x01(\t\" \n\nIdProducto\x12\x12\n\nidproducto\x18\x01 \x01(\x05\"\x1e\n\tIdUsuario\x12\x11\n\tidusuario\x18\x01 \x01(\x05\"5\n\rProductoStock\x12\x12\n\nidProducto\x18\x01 \x01(\x05\x12\x10\n\x08\x63\x61ntidad\x18\x02 \x01(\x05\x32\xe4\x01\n\tProductos\x12.\n\x11TraerProductoById\x12\x0b.IdProducto\x1a\x0c.ProductoGet\x12$\n\x0eTraerProductos\x12\x05.Nulo\x1a\t.Producto0\x01\x12(\n\x0c\x41ltaProducto\x12\r.ProductoPost\x1a\t.Response\x12)\n\x0e\x45\x64itarProducto\x12\x0c.ProductoPut\x1a\t.Response\x12,\n\x0f\x41\x63tualizarStock\x12\x0e.ProductoStock\x1a\t.Responseb\x06proto3'
  ,
  dependencies=[usuarios__pb2.DESCRIPTOR,google_dot_protobuf_dot_timestamp__pb2.DESCRIPTOR,])




_PRODUCTO = _descriptor.Descriptor(
  name='Producto',
  full_name='Producto',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='idproducto', full_name='Producto.idproducto', index=0,
      number=1, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='nombre', full_name='Producto.nombre', index=1,
      number=2, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='descripcion', full_name='Producto.descripcion', index=2,
      number=3, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='idtipocategoria', full_name='Producto.idtipocategoria', index=3,
      number=4, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='precio', full_name='Producto.precio', index=4,
      number=5, type=2, cpp_type=6, label=1,
      has_default_value=False, default_value=float(0),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='cantidad_disponible', full_name='Producto.cantidad_disponible', index=5,
      number=6, type=3, cpp_type=2, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='fecha_publicacion', full_name='Producto.fecha_publicacion', index=6,
      number=7, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='publicador_idusuario', full_name='Producto.publicador_idusuario', index=7,
      number=8, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='url_fotos', full_name='Producto.url_fotos', index=8,
      number=9, type=9, cpp_type=9, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='esSubasta', full_name='Producto.esSubasta', index=9,
      number=10, type=8, cpp_type=7, label=1,
      has_default_value=False, default_value=False,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='fecha_inicio', full_name='Producto.fecha_inicio', index=10,
      number=11, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='fecha_fin', full_name='Producto.fecha_fin', index=11,
      number=12, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=69,
  serialized_end=398,
)


_PRODUCTOSLIST = _descriptor.Descriptor(
  name='ProductosList',
  full_name='ProductosList',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='productos', full_name='ProductosList.productos', index=0,
      number=1, type=11, cpp_type=10, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=400,
  serialized_end=445,
)


_PRODUCTOGET = _descriptor.Descriptor(
  name='ProductoGet',
  full_name='ProductoGet',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='nombre', full_name='ProductoGet.nombre', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='descripcion', full_name='ProductoGet.descripcion', index=1,
      number=2, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='categoria', full_name='ProductoGet.categoria', index=2,
      number=3, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='precio', full_name='ProductoGet.precio', index=3,
      number=4, type=2, cpp_type=6, label=1,
      has_default_value=False, default_value=float(0),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='cantidad_disponible', full_name='ProductoGet.cantidad_disponible', index=4,
      number=5, type=3, cpp_type=2, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='fecha_publicacion', full_name='ProductoGet.fecha_publicacion', index=5,
      number=6, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='publicador', full_name='ProductoGet.publicador', index=6,
      number=7, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='url_fotos', full_name='ProductoGet.url_fotos', index=7,
      number=8, type=9, cpp_type=9, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='esSubasta', full_name='ProductoGet.esSubasta', index=8,
      number=9, type=8, cpp_type=7, label=1,
      has_default_value=False, default_value=False,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='fecha_inicio', full_name='ProductoGet.fecha_inicio', index=9,
      number=10, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='fecha_fin', full_name='ProductoGet.fecha_fin', index=10,
      number=11, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=448,
  serialized_end=744,
)


_PRODUCTOPOST = _descriptor.Descriptor(
  name='ProductoPost',
  full_name='ProductoPost',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='nombre', full_name='ProductoPost.nombre', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='descripcion', full_name='ProductoPost.descripcion', index=1,
      number=2, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='idtipocategoria', full_name='ProductoPost.idtipocategoria', index=2,
      number=3, type=3, cpp_type=2, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='precio', full_name='ProductoPost.precio', index=3,
      number=4, type=2, cpp_type=6, label=1,
      has_default_value=False, default_value=float(0),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='cantidad_disponible', full_name='ProductoPost.cantidad_disponible', index=4,
      number=5, type=3, cpp_type=2, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='fecha_publicacion', full_name='ProductoPost.fecha_publicacion', index=5,
      number=6, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='publicador_idusuario', full_name='ProductoPost.publicador_idusuario', index=6,
      number=7, type=3, cpp_type=2, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='url_fotos', full_name='ProductoPost.url_fotos', index=7,
      number=8, type=9, cpp_type=9, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='esSubasta', full_name='ProductoPost.esSubasta', index=8,
      number=9, type=8, cpp_type=7, label=1,
      has_default_value=False, default_value=False,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='fecha_inicio', full_name='ProductoPost.fecha_inicio', index=9,
      number=10, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='fecha_fin', full_name='ProductoPost.fecha_fin', index=10,
      number=11, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=747,
  serialized_end=1060,
)


_PRODUCTOPUT = _descriptor.Descriptor(
  name='ProductoPut',
  full_name='ProductoPut',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='idproducto', full_name='ProductoPut.idproducto', index=0,
      number=1, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='nombre', full_name='ProductoPut.nombre', index=1,
      number=2, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='descripcion', full_name='ProductoPut.descripcion', index=2,
      number=3, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='idtipocategoria', full_name='ProductoPut.idtipocategoria', index=3,
      number=4, type=3, cpp_type=2, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='precio', full_name='ProductoPut.precio', index=4,
      number=5, type=2, cpp_type=6, label=1,
      has_default_value=False, default_value=float(0),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='cantidad_disponible', full_name='ProductoPut.cantidad_disponible', index=5,
      number=6, type=3, cpp_type=2, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='url_fotos', full_name='ProductoPut.url_fotos', index=6,
      number=7, type=9, cpp_type=9, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=1063,
  serialized_end=1222,
)


_TIPO_CATEGORIA = _descriptor.Descriptor(
  name='Tipo_categoria',
  full_name='Tipo_categoria',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='nombre', full_name='Tipo_categoria.nombre', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=1224,
  serialized_end=1256,
)


_IDPRODUCTO = _descriptor.Descriptor(
  name='IdProducto',
  full_name='IdProducto',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='idproducto', full_name='IdProducto.idproducto', index=0,
      number=1, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=1258,
  serialized_end=1290,
)


_IDUSUARIO = _descriptor.Descriptor(
  name='IdUsuario',
  full_name='IdUsuario',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='idusuario', full_name='IdUsuario.idusuario', index=0,
      number=1, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=1292,
  serialized_end=1322,
)


_PRODUCTOSTOCK = _descriptor.Descriptor(
  name='ProductoStock',
  full_name='ProductoStock',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='idProducto', full_name='ProductoStock.idProducto', index=0,
      number=1, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='cantidad', full_name='ProductoStock.cantidad', index=1,
      number=2, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=1324,
  serialized_end=1377,
)

_PRODUCTO.fields_by_name['fecha_inicio'].message_type = google_dot_protobuf_dot_timestamp__pb2._TIMESTAMP
_PRODUCTO.fields_by_name['fecha_fin'].message_type = google_dot_protobuf_dot_timestamp__pb2._TIMESTAMP
_PRODUCTOSLIST.fields_by_name['productos'].message_type = _PRODUCTO
_PRODUCTOGET.fields_by_name['fecha_inicio'].message_type = google_dot_protobuf_dot_timestamp__pb2._TIMESTAMP
_PRODUCTOGET.fields_by_name['fecha_fin'].message_type = google_dot_protobuf_dot_timestamp__pb2._TIMESTAMP
_PRODUCTOPOST.fields_by_name['fecha_inicio'].message_type = google_dot_protobuf_dot_timestamp__pb2._TIMESTAMP
_PRODUCTOPOST.fields_by_name['fecha_fin'].message_type = google_dot_protobuf_dot_timestamp__pb2._TIMESTAMP
DESCRIPTOR.message_types_by_name['Producto'] = _PRODUCTO
DESCRIPTOR.message_types_by_name['ProductosList'] = _PRODUCTOSLIST
DESCRIPTOR.message_types_by_name['ProductoGet'] = _PRODUCTOGET
DESCRIPTOR.message_types_by_name['ProductoPost'] = _PRODUCTOPOST
DESCRIPTOR.message_types_by_name['ProductoPut'] = _PRODUCTOPUT
DESCRIPTOR.message_types_by_name['Tipo_categoria'] = _TIPO_CATEGORIA
DESCRIPTOR.message_types_by_name['IdProducto'] = _IDPRODUCTO
DESCRIPTOR.message_types_by_name['IdUsuario'] = _IDUSUARIO
DESCRIPTOR.message_types_by_name['ProductoStock'] = _PRODUCTOSTOCK
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

Producto = _reflection.GeneratedProtocolMessageType('Producto', (_message.Message,), {
  'DESCRIPTOR' : _PRODUCTO,
  '__module__' : 'productos_pb2'
  # @@protoc_insertion_point(class_scope:Producto)
  })
_sym_db.RegisterMessage(Producto)

ProductosList = _reflection.GeneratedProtocolMessageType('ProductosList', (_message.Message,), {
  'DESCRIPTOR' : _PRODUCTOSLIST,
  '__module__' : 'productos_pb2'
  # @@protoc_insertion_point(class_scope:ProductosList)
  })
_sym_db.RegisterMessage(ProductosList)

ProductoGet = _reflection.GeneratedProtocolMessageType('ProductoGet', (_message.Message,), {
  'DESCRIPTOR' : _PRODUCTOGET,
  '__module__' : 'productos_pb2'
  # @@protoc_insertion_point(class_scope:ProductoGet)
  })
_sym_db.RegisterMessage(ProductoGet)

ProductoPost = _reflection.GeneratedProtocolMessageType('ProductoPost', (_message.Message,), {
  'DESCRIPTOR' : _PRODUCTOPOST,
  '__module__' : 'productos_pb2'
  # @@protoc_insertion_point(class_scope:ProductoPost)
  })
_sym_db.RegisterMessage(ProductoPost)

ProductoPut = _reflection.GeneratedProtocolMessageType('ProductoPut', (_message.Message,), {
  'DESCRIPTOR' : _PRODUCTOPUT,
  '__module__' : 'productos_pb2'
  # @@protoc_insertion_point(class_scope:ProductoPut)
  })
_sym_db.RegisterMessage(ProductoPut)

Tipo_categoria = _reflection.GeneratedProtocolMessageType('Tipo_categoria', (_message.Message,), {
  'DESCRIPTOR' : _TIPO_CATEGORIA,
  '__module__' : 'productos_pb2'
  # @@protoc_insertion_point(class_scope:Tipo_categoria)
  })
_sym_db.RegisterMessage(Tipo_categoria)

IdProducto = _reflection.GeneratedProtocolMessageType('IdProducto', (_message.Message,), {
  'DESCRIPTOR' : _IDPRODUCTO,
  '__module__' : 'productos_pb2'
  # @@protoc_insertion_point(class_scope:IdProducto)
  })
_sym_db.RegisterMessage(IdProducto)

IdUsuario = _reflection.GeneratedProtocolMessageType('IdUsuario', (_message.Message,), {
  'DESCRIPTOR' : _IDUSUARIO,
  '__module__' : 'productos_pb2'
  # @@protoc_insertion_point(class_scope:IdUsuario)
  })
_sym_db.RegisterMessage(IdUsuario)

ProductoStock = _reflection.GeneratedProtocolMessageType('ProductoStock', (_message.Message,), {
  'DESCRIPTOR' : _PRODUCTOSTOCK,
  '__module__' : 'productos_pb2'
  # @@protoc_insertion_point(class_scope:ProductoStock)
  })
_sym_db.RegisterMessage(ProductoStock)



_PRODUCTOS = _descriptor.ServiceDescriptor(
  name='Productos',
  full_name='Productos',
  file=DESCRIPTOR,
  index=0,
  serialized_options=None,
  create_key=_descriptor._internal_create_key,
  serialized_start=1380,
  serialized_end=1608,
  methods=[
  _descriptor.MethodDescriptor(
    name='TraerProductoById',
    full_name='Productos.TraerProductoById',
    index=0,
    containing_service=None,
    input_type=_IDPRODUCTO,
    output_type=_PRODUCTOGET,
    serialized_options=None,
    create_key=_descriptor._internal_create_key,
  ),
  _descriptor.MethodDescriptor(
    name='TraerProductos',
    full_name='Productos.TraerProductos',
    index=1,
    containing_service=None,
    input_type=usuarios__pb2._NULO,
    output_type=_PRODUCTO,
    serialized_options=None,
    create_key=_descriptor._internal_create_key,
  ),
  _descriptor.MethodDescriptor(
    name='AltaProducto',
    full_name='Productos.AltaProducto',
    index=2,
    containing_service=None,
    input_type=_PRODUCTOPOST,
    output_type=usuarios__pb2._RESPONSE,
    serialized_options=None,
    create_key=_descriptor._internal_create_key,
  ),
  _descriptor.MethodDescriptor(
    name='EditarProducto',
    full_name='Productos.EditarProducto',
    index=3,
    containing_service=None,
    input_type=_PRODUCTOPUT,
    output_type=usuarios__pb2._RESPONSE,
    serialized_options=None,
    create_key=_descriptor._internal_create_key,
  ),
  _descriptor.MethodDescriptor(
    name='ActualizarStock',
    full_name='Productos.ActualizarStock',
    index=4,
    containing_service=None,
    input_type=_PRODUCTOSTOCK,
    output_type=usuarios__pb2._RESPONSE,
    serialized_options=None,
    create_key=_descriptor._internal_create_key,
  ),
])
_sym_db.RegisterServiceDescriptor(_PRODUCTOS)

DESCRIPTOR.services_by_name['Productos'] = _PRODUCTOS

# @@protoc_insertion_point(module_scope)
