// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProtoOriginator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OpenVASP.ProtocolMessages.Messages {

  /// <summary>Holder for reflection information generated from ProtoOriginator.proto</summary>
  public static partial class ProtoOriginatorReflection {

    #region Descriptor
    /// <summary>File descriptor for ProtoOriginator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoOriginatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b09yaWdpbmF0b3IucHJvdG8SEXByb3RvYnVmX29wZW52YXNwGhhQ",
            "cm90b1Bvc3RhbEFkZHJlc3MucHJvdG8aF1Byb3RvUGxhY2VPZkJpcnRoLnBy",
            "b3RvGhpQcm90b05hdHVyYWxQZXJzb25JZC5wcm90bxocUHJvdG9KdXJpZGlj",
            "YWxQZXJzb25JZC5wcm90byLBAgoPUHJvdG9PcmlnaW5hdG9yEgwKBG5hbWUY",
            "ASABKAkSDAoEdmFhbhgCIAEoCRI9Cg5wb3N0YWxfYWRkcmVzcxgEIAEoCzIl",
            "LnByb3RvYnVmX29wZW52YXNwLlByb3RvUG9zdGFsQWRkcmVzcxI6CgxwbGFj",
            "ZU9mQmlydGgYBSABKAsyJC5wcm90b2J1Zl9vcGVudmFzcC5Qcm90b1BsYWNl",
            "T2ZCaXJ0aBJCChFuYXR1cmFsX3BlcnNvbl9pZBgGIAMoCzInLnByb3RvYnVm",
            "X29wZW52YXNwLlByb3RvTmF0dXJhbFBlcnNvbklkEkYKE2p1cmlkaWNhbF9w",
            "ZXJzb25faWQYByADKAsyKS5wcm90b2J1Zl9vcGVudmFzcC5Qcm90b0p1cmlk",
            "aWNhbFBlcnNvbklkEgsKA2JpYxgIIAEoCUIlqgIiT3BlblZBU1AuUHJvdG9j",
            "b2xNZXNzYWdlcy5NZXNzYWdlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OpenVASP.ProtocolMessages.Messages.ProtoPostalAddressReflection.Descriptor, global::OpenVASP.ProtocolMessages.Messages.ProtoPlaceOfBirthReflection.Descriptor, global::OpenVASP.ProtocolMessages.Messages.ProtoNaturalPersonIdReflection.Descriptor, global::OpenVASP.ProtocolMessages.Messages.ProtoJuridicalPersonIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OpenVASP.ProtocolMessages.Messages.ProtoOriginator), global::OpenVASP.ProtocolMessages.Messages.ProtoOriginator.Parser, new[]{ "Name", "Vaan", "PostalAddress", "PlaceOfBirth", "NaturalPersonId", "JuridicalPersonId", "Bic" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProtoOriginator : pb::IMessage<ProtoOriginator> {
    private static readonly pb::MessageParser<ProtoOriginator> _parser = new pb::MessageParser<ProtoOriginator>(() => new ProtoOriginator());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProtoOriginator> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OpenVASP.ProtocolMessages.Messages.ProtoOriginatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoOriginator() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoOriginator(ProtoOriginator other) : this() {
      name_ = other.name_;
      vaan_ = other.vaan_;
      postalAddress_ = other.postalAddress_ != null ? other.postalAddress_.Clone() : null;
      placeOfBirth_ = other.placeOfBirth_ != null ? other.placeOfBirth_.Clone() : null;
      naturalPersonId_ = other.naturalPersonId_.Clone();
      juridicalPersonId_ = other.juridicalPersonId_.Clone();
      bic_ = other.bic_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoOriginator Clone() {
      return new ProtoOriginator(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "vaan" field.</summary>
    public const int VaanFieldNumber = 2;
    private string vaan_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Vaan {
      get { return vaan_; }
      set {
        vaan_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "postal_address" field.</summary>
    public const int PostalAddressFieldNumber = 4;
    private global::OpenVASP.ProtocolMessages.Messages.ProtoPostalAddress postalAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::OpenVASP.ProtocolMessages.Messages.ProtoPostalAddress PostalAddress {
      get { return postalAddress_; }
      set {
        postalAddress_ = value;
      }
    }

    /// <summary>Field number for the "placeOfBirth" field.</summary>
    public const int PlaceOfBirthFieldNumber = 5;
    private global::OpenVASP.ProtocolMessages.Messages.ProtoPlaceOfBirth placeOfBirth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::OpenVASP.ProtocolMessages.Messages.ProtoPlaceOfBirth PlaceOfBirth {
      get { return placeOfBirth_; }
      set {
        placeOfBirth_ = value;
      }
    }

    /// <summary>Field number for the "natural_person_id" field.</summary>
    public const int NaturalPersonIdFieldNumber = 6;
    private static readonly pb::FieldCodec<global::OpenVASP.ProtocolMessages.Messages.ProtoNaturalPersonId> _repeated_naturalPersonId_codec
        = pb::FieldCodec.ForMessage(50, global::OpenVASP.ProtocolMessages.Messages.ProtoNaturalPersonId.Parser);
    private readonly pbc::RepeatedField<global::OpenVASP.ProtocolMessages.Messages.ProtoNaturalPersonId> naturalPersonId_ = new pbc::RepeatedField<global::OpenVASP.ProtocolMessages.Messages.ProtoNaturalPersonId>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::OpenVASP.ProtocolMessages.Messages.ProtoNaturalPersonId> NaturalPersonId {
      get { return naturalPersonId_; }
    }

    /// <summary>Field number for the "juridical_person_id" field.</summary>
    public const int JuridicalPersonIdFieldNumber = 7;
    private static readonly pb::FieldCodec<global::OpenVASP.ProtocolMessages.Messages.ProtoJuridicalPersonId> _repeated_juridicalPersonId_codec
        = pb::FieldCodec.ForMessage(58, global::OpenVASP.ProtocolMessages.Messages.ProtoJuridicalPersonId.Parser);
    private readonly pbc::RepeatedField<global::OpenVASP.ProtocolMessages.Messages.ProtoJuridicalPersonId> juridicalPersonId_ = new pbc::RepeatedField<global::OpenVASP.ProtocolMessages.Messages.ProtoJuridicalPersonId>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::OpenVASP.ProtocolMessages.Messages.ProtoJuridicalPersonId> JuridicalPersonId {
      get { return juridicalPersonId_; }
    }

    /// <summary>Field number for the "bic" field.</summary>
    public const int BicFieldNumber = 8;
    private string bic_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Bic {
      get { return bic_; }
      set {
        bic_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProtoOriginator);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProtoOriginator other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Vaan != other.Vaan) return false;
      if (!object.Equals(PostalAddress, other.PostalAddress)) return false;
      if (!object.Equals(PlaceOfBirth, other.PlaceOfBirth)) return false;
      if(!naturalPersonId_.Equals(other.naturalPersonId_)) return false;
      if(!juridicalPersonId_.Equals(other.juridicalPersonId_)) return false;
      if (Bic != other.Bic) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Vaan.Length != 0) hash ^= Vaan.GetHashCode();
      if (postalAddress_ != null) hash ^= PostalAddress.GetHashCode();
      if (placeOfBirth_ != null) hash ^= PlaceOfBirth.GetHashCode();
      hash ^= naturalPersonId_.GetHashCode();
      hash ^= juridicalPersonId_.GetHashCode();
      if (Bic.Length != 0) hash ^= Bic.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Vaan.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Vaan);
      }
      if (postalAddress_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PostalAddress);
      }
      if (placeOfBirth_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(PlaceOfBirth);
      }
      naturalPersonId_.WriteTo(output, _repeated_naturalPersonId_codec);
      juridicalPersonId_.WriteTo(output, _repeated_juridicalPersonId_codec);
      if (Bic.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Bic);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Vaan.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Vaan);
      }
      if (postalAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PostalAddress);
      }
      if (placeOfBirth_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlaceOfBirth);
      }
      size += naturalPersonId_.CalculateSize(_repeated_naturalPersonId_codec);
      size += juridicalPersonId_.CalculateSize(_repeated_juridicalPersonId_codec);
      if (Bic.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Bic);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProtoOriginator other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Vaan.Length != 0) {
        Vaan = other.Vaan;
      }
      if (other.postalAddress_ != null) {
        if (postalAddress_ == null) {
          PostalAddress = new global::OpenVASP.ProtocolMessages.Messages.ProtoPostalAddress();
        }
        PostalAddress.MergeFrom(other.PostalAddress);
      }
      if (other.placeOfBirth_ != null) {
        if (placeOfBirth_ == null) {
          PlaceOfBirth = new global::OpenVASP.ProtocolMessages.Messages.ProtoPlaceOfBirth();
        }
        PlaceOfBirth.MergeFrom(other.PlaceOfBirth);
      }
      naturalPersonId_.Add(other.naturalPersonId_);
      juridicalPersonId_.Add(other.juridicalPersonId_);
      if (other.Bic.Length != 0) {
        Bic = other.Bic;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Vaan = input.ReadString();
            break;
          }
          case 34: {
            if (postalAddress_ == null) {
              PostalAddress = new global::OpenVASP.ProtocolMessages.Messages.ProtoPostalAddress();
            }
            input.ReadMessage(PostalAddress);
            break;
          }
          case 42: {
            if (placeOfBirth_ == null) {
              PlaceOfBirth = new global::OpenVASP.ProtocolMessages.Messages.ProtoPlaceOfBirth();
            }
            input.ReadMessage(PlaceOfBirth);
            break;
          }
          case 50: {
            naturalPersonId_.AddEntriesFrom(input, _repeated_naturalPersonId_codec);
            break;
          }
          case 58: {
            juridicalPersonId_.AddEntriesFrom(input, _repeated_juridicalPersonId_codec);
            break;
          }
          case 66: {
            Bic = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
