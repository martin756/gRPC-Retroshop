// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: usuarios.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from usuarios.proto</summary>
public static partial class UsuariosReflection {

  #region Descriptor
  /// <summary>File descriptor for usuarios.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static UsuariosReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg51c3Vhcmlvcy5wcm90byKJAQoHVXN1YXJpbxIRCglpZHVzdWFyaW8YASAB",
          "KAUSDgoGbm9tYnJlGAIgASgJEhAKCGFwZWxsaWRvGAMgASgJEgsKA2RuaRgE",
          "IAEoAxINCgVlbWFpbBgFIAEoCRIMCgR1c2VyGAYgASgJEhAKCHBhc3N3b3Jk",
          "GAcgASgJEg0KBXNhbGRvGAggASgCIikKBVNhbGRvEhEKCWlkdXN1YXJpbxgB",
          "IAEoBRINCgVzYWxkbxgCIAEoAiIuCghVc2VybmFtZRIQCgh1c2VybmFtZRgB",
          "IAEoCRIQCghwYXNzd29yZBgCIAEoCSIuCghSZXNwb25zZRIPCgdtZXNzYWdl",
          "GAEgASgJEhEKCWlkdXN1YXJpbxgCIAEoBSIGCgROdWxvMowBCghVc3Vhcmlv",
          "cxIVCgVMaXN0bxIFLk51bG8aBS5OdWxvEiMKDFRyYWVyVXN1YXJpbxIJLlVz",
          "ZXJuYW1lGgguVXN1YXJpbxIiCgtBbHRhVXN1YXJpbxIILlVzdWFyaW8aCS5S",
          "ZXNwb25zZRIgCgtDYXJnYXJTYWxkbxIGLlNhbGRvGgkuUmVzcG9uc2ViBnBy",
          "b3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Usuario), global::Usuario.Parser, new[]{ "Idusuario", "Nombre", "Apellido", "Dni", "Email", "User", "Password", "Saldo" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Saldo), global::Saldo.Parser, new[]{ "Idusuario", "Saldo_" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Username), global::Username.Parser, new[]{ "Username_", "Password" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Response), global::Response.Parser, new[]{ "Message", "Idusuario" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Nulo), global::Nulo.Parser, null, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Usuario : pb::IMessage<Usuario>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Usuario> _parser = new pb::MessageParser<Usuario>(() => new Usuario());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Usuario> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::UsuariosReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Usuario() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Usuario(Usuario other) : this() {
    idusuario_ = other.idusuario_;
    nombre_ = other.nombre_;
    apellido_ = other.apellido_;
    dni_ = other.dni_;
    email_ = other.email_;
    user_ = other.user_;
    password_ = other.password_;
    saldo_ = other.saldo_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Usuario Clone() {
    return new Usuario(this);
  }

  /// <summary>Field number for the "idusuario" field.</summary>
  public const int IdusuarioFieldNumber = 1;
  private int idusuario_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Idusuario {
    get { return idusuario_; }
    set {
      idusuario_ = value;
    }
  }

  /// <summary>Field number for the "nombre" field.</summary>
  public const int NombreFieldNumber = 2;
  private string nombre_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Nombre {
    get { return nombre_; }
    set {
      nombre_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "apellido" field.</summary>
  public const int ApellidoFieldNumber = 3;
  private string apellido_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Apellido {
    get { return apellido_; }
    set {
      apellido_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "dni" field.</summary>
  public const int DniFieldNumber = 4;
  private long dni_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long Dni {
    get { return dni_; }
    set {
      dni_ = value;
    }
  }

  /// <summary>Field number for the "email" field.</summary>
  public const int EmailFieldNumber = 5;
  private string email_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Email {
    get { return email_; }
    set {
      email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "user" field.</summary>
  public const int UserFieldNumber = 6;
  private string user_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string User {
    get { return user_; }
    set {
      user_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "password" field.</summary>
  public const int PasswordFieldNumber = 7;
  private string password_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Password {
    get { return password_; }
    set {
      password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "saldo" field.</summary>
  public const int SaldoFieldNumber = 8;
  private float saldo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Saldo {
    get { return saldo_; }
    set {
      saldo_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Usuario);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Usuario other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Idusuario != other.Idusuario) return false;
    if (Nombre != other.Nombre) return false;
    if (Apellido != other.Apellido) return false;
    if (Dni != other.Dni) return false;
    if (Email != other.Email) return false;
    if (User != other.User) return false;
    if (Password != other.Password) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Saldo, other.Saldo)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Idusuario != 0) hash ^= Idusuario.GetHashCode();
    if (Nombre.Length != 0) hash ^= Nombre.GetHashCode();
    if (Apellido.Length != 0) hash ^= Apellido.GetHashCode();
    if (Dni != 0L) hash ^= Dni.GetHashCode();
    if (Email.Length != 0) hash ^= Email.GetHashCode();
    if (User.Length != 0) hash ^= User.GetHashCode();
    if (Password.Length != 0) hash ^= Password.GetHashCode();
    if (Saldo != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Saldo);
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Idusuario != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Idusuario);
    }
    if (Nombre.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Nombre);
    }
    if (Apellido.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Apellido);
    }
    if (Dni != 0L) {
      output.WriteRawTag(32);
      output.WriteInt64(Dni);
    }
    if (Email.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(Email);
    }
    if (User.Length != 0) {
      output.WriteRawTag(50);
      output.WriteString(User);
    }
    if (Password.Length != 0) {
      output.WriteRawTag(58);
      output.WriteString(Password);
    }
    if (Saldo != 0F) {
      output.WriteRawTag(69);
      output.WriteFloat(Saldo);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Idusuario != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Idusuario);
    }
    if (Nombre.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Nombre);
    }
    if (Apellido.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Apellido);
    }
    if (Dni != 0L) {
      output.WriteRawTag(32);
      output.WriteInt64(Dni);
    }
    if (Email.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(Email);
    }
    if (User.Length != 0) {
      output.WriteRawTag(50);
      output.WriteString(User);
    }
    if (Password.Length != 0) {
      output.WriteRawTag(58);
      output.WriteString(Password);
    }
    if (Saldo != 0F) {
      output.WriteRawTag(69);
      output.WriteFloat(Saldo);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Idusuario != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Idusuario);
    }
    if (Nombre.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Nombre);
    }
    if (Apellido.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Apellido);
    }
    if (Dni != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Dni);
    }
    if (Email.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
    }
    if (User.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(User);
    }
    if (Password.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
    }
    if (Saldo != 0F) {
      size += 1 + 4;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Usuario other) {
    if (other == null) {
      return;
    }
    if (other.Idusuario != 0) {
      Idusuario = other.Idusuario;
    }
    if (other.Nombre.Length != 0) {
      Nombre = other.Nombre;
    }
    if (other.Apellido.Length != 0) {
      Apellido = other.Apellido;
    }
    if (other.Dni != 0L) {
      Dni = other.Dni;
    }
    if (other.Email.Length != 0) {
      Email = other.Email;
    }
    if (other.User.Length != 0) {
      User = other.User;
    }
    if (other.Password.Length != 0) {
      Password = other.Password;
    }
    if (other.Saldo != 0F) {
      Saldo = other.Saldo;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Idusuario = input.ReadInt32();
          break;
        }
        case 18: {
          Nombre = input.ReadString();
          break;
        }
        case 26: {
          Apellido = input.ReadString();
          break;
        }
        case 32: {
          Dni = input.ReadInt64();
          break;
        }
        case 42: {
          Email = input.ReadString();
          break;
        }
        case 50: {
          User = input.ReadString();
          break;
        }
        case 58: {
          Password = input.ReadString();
          break;
        }
        case 69: {
          Saldo = input.ReadFloat();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          Idusuario = input.ReadInt32();
          break;
        }
        case 18: {
          Nombre = input.ReadString();
          break;
        }
        case 26: {
          Apellido = input.ReadString();
          break;
        }
        case 32: {
          Dni = input.ReadInt64();
          break;
        }
        case 42: {
          Email = input.ReadString();
          break;
        }
        case 50: {
          User = input.ReadString();
          break;
        }
        case 58: {
          Password = input.ReadString();
          break;
        }
        case 69: {
          Saldo = input.ReadFloat();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class Saldo : pb::IMessage<Saldo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Saldo> _parser = new pb::MessageParser<Saldo>(() => new Saldo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Saldo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::UsuariosReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Saldo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Saldo(Saldo other) : this() {
    idusuario_ = other.idusuario_;
    saldo_ = other.saldo_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Saldo Clone() {
    return new Saldo(this);
  }

  /// <summary>Field number for the "idusuario" field.</summary>
  public const int IdusuarioFieldNumber = 1;
  private int idusuario_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Idusuario {
    get { return idusuario_; }
    set {
      idusuario_ = value;
    }
  }

  /// <summary>Field number for the "saldo" field.</summary>
  public const int Saldo_FieldNumber = 2;
  private float saldo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Saldo_ {
    get { return saldo_; }
    set {
      saldo_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Saldo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Saldo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Idusuario != other.Idusuario) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Saldo_, other.Saldo_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Idusuario != 0) hash ^= Idusuario.GetHashCode();
    if (Saldo_ != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Saldo_);
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Idusuario != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Idusuario);
    }
    if (Saldo_ != 0F) {
      output.WriteRawTag(21);
      output.WriteFloat(Saldo_);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Idusuario != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Idusuario);
    }
    if (Saldo_ != 0F) {
      output.WriteRawTag(21);
      output.WriteFloat(Saldo_);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Idusuario != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Idusuario);
    }
    if (Saldo_ != 0F) {
      size += 1 + 4;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Saldo other) {
    if (other == null) {
      return;
    }
    if (other.Idusuario != 0) {
      Idusuario = other.Idusuario;
    }
    if (other.Saldo_ != 0F) {
      Saldo_ = other.Saldo_;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Idusuario = input.ReadInt32();
          break;
        }
        case 21: {
          Saldo_ = input.ReadFloat();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          Idusuario = input.ReadInt32();
          break;
        }
        case 21: {
          Saldo_ = input.ReadFloat();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class Username : pb::IMessage<Username>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Username> _parser = new pb::MessageParser<Username>(() => new Username());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Username> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::UsuariosReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Username() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Username(Username other) : this() {
    username_ = other.username_;
    password_ = other.password_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Username Clone() {
    return new Username(this);
  }

  /// <summary>Field number for the "username" field.</summary>
  public const int Username_FieldNumber = 1;
  private string username_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Username_ {
    get { return username_; }
    set {
      username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "password" field.</summary>
  public const int PasswordFieldNumber = 2;
  private string password_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Password {
    get { return password_; }
    set {
      password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Username);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Username other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Username_ != other.Username_) return false;
    if (Password != other.Password) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Username_.Length != 0) hash ^= Username_.GetHashCode();
    if (Password.Length != 0) hash ^= Password.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Username_.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Username_);
    }
    if (Password.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Password);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Username_.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Username_);
    }
    if (Password.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Password);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Username_.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Username_);
    }
    if (Password.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Username other) {
    if (other == null) {
      return;
    }
    if (other.Username_.Length != 0) {
      Username_ = other.Username_;
    }
    if (other.Password.Length != 0) {
      Password = other.Password;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Username_ = input.ReadString();
          break;
        }
        case 18: {
          Password = input.ReadString();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Username_ = input.ReadString();
          break;
        }
        case 18: {
          Password = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class Response : pb::IMessage<Response>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Response> _parser = new pb::MessageParser<Response>(() => new Response());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Response> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::UsuariosReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Response() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Response(Response other) : this() {
    message_ = other.message_;
    idusuario_ = other.idusuario_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Response Clone() {
    return new Response(this);
  }

  /// <summary>Field number for the "message" field.</summary>
  public const int MessageFieldNumber = 1;
  private string message_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "idusuario" field.</summary>
  public const int IdusuarioFieldNumber = 2;
  private int idusuario_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Idusuario {
    get { return idusuario_; }
    set {
      idusuario_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Response);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Response other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Message != other.Message) return false;
    if (Idusuario != other.Idusuario) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Message.Length != 0) hash ^= Message.GetHashCode();
    if (Idusuario != 0) hash ^= Idusuario.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Message.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Message);
    }
    if (Idusuario != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Idusuario);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Message.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Message);
    }
    if (Idusuario != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Idusuario);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
    }
    if (Idusuario != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Idusuario);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Response other) {
    if (other == null) {
      return;
    }
    if (other.Message.Length != 0) {
      Message = other.Message;
    }
    if (other.Idusuario != 0) {
      Idusuario = other.Idusuario;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Message = input.ReadString();
          break;
        }
        case 16: {
          Idusuario = input.ReadInt32();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Message = input.ReadString();
          break;
        }
        case 16: {
          Idusuario = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class Nulo : pb::IMessage<Nulo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Nulo> _parser = new pb::MessageParser<Nulo>(() => new Nulo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Nulo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::UsuariosReflection.Descriptor.MessageTypes[4]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Nulo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Nulo(Nulo other) : this() {
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Nulo Clone() {
    return new Nulo(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Nulo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Nulo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Nulo other) {
    if (other == null) {
      return;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
