# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: usuarios.proto
"""Generated protocol buffer code."""
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\x0eusuarios.proto\"g\n\x07Usuario\x12\x0e\n\x06nombre\x18\x01 \x01(\t\x12\x10\n\x08\x61pellido\x18\x02 \x01(\t\x12\x0b\n\x03\x64ni\x18\x03 \x01(\x04\x12\r\n\x05\x65mail\x18\x04 \x01(\t\x12\x0c\n\x04user\x18\x05 \x01(\t\x12\x10\n\x08password\x18\x06 \x01(\t\".\n\x08Username\x12\x10\n\x08username\x18\x01 \x01(\t\x12\x10\n\x08password\x18\x02 \x01(\t\"\x1b\n\x08Response\x12\x0f\n\x07message\x18\x01 \x01(\t\"\x06\n\x04Nulo2j\n\x08Usuarios\x12\x15\n\x05Listo\x12\x05.Nulo\x1a\x05.Nulo\x12#\n\x0cTraerUsuario\x12\t.Username\x1a\x08.Usuario\x12\"\n\x0b\x41ltaUsuario\x12\x08.Usuario\x1a\t.Responseb\x06proto3')



_USUARIO = DESCRIPTOR.message_types_by_name['Usuario']
_USERNAME = DESCRIPTOR.message_types_by_name['Username']
_RESPONSE = DESCRIPTOR.message_types_by_name['Response']
_NULO = DESCRIPTOR.message_types_by_name['Nulo']
Usuario = _reflection.GeneratedProtocolMessageType('Usuario', (_message.Message,), {
  'DESCRIPTOR' : _USUARIO,
  '__module__' : 'usuarios_pb2'
  # @@protoc_insertion_point(class_scope:Usuario)
  })
_sym_db.RegisterMessage(Usuario)

Username = _reflection.GeneratedProtocolMessageType('Username', (_message.Message,), {
  'DESCRIPTOR' : _USERNAME,
  '__module__' : 'usuarios_pb2'
  # @@protoc_insertion_point(class_scope:Username)
  })
_sym_db.RegisterMessage(Username)

Response = _reflection.GeneratedProtocolMessageType('Response', (_message.Message,), {
  'DESCRIPTOR' : _RESPONSE,
  '__module__' : 'usuarios_pb2'
  # @@protoc_insertion_point(class_scope:Response)
  })
_sym_db.RegisterMessage(Response)

Nulo = _reflection.GeneratedProtocolMessageType('Nulo', (_message.Message,), {
  'DESCRIPTOR' : _NULO,
  '__module__' : 'usuarios_pb2'
  # @@protoc_insertion_point(class_scope:Nulo)
  })
_sym_db.RegisterMessage(Nulo)

_USUARIOS = DESCRIPTOR.services_by_name['Usuarios']
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _USUARIO._serialized_start=18
  _USUARIO._serialized_end=121
  _USERNAME._serialized_start=123
  _USERNAME._serialized_end=169
  _RESPONSE._serialized_start=171
  _RESPONSE._serialized_end=198
  _NULO._serialized_start=200
  _NULO._serialized_end=206
  _USUARIOS._serialized_start=208
  _USUARIOS._serialized_end=314
# @@protoc_insertion_point(module_scope)
