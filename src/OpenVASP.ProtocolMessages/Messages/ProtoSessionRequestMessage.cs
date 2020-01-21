// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProtoSessionRequestMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OpenVASP.ProtocolMessages.Messages {

  /// <summary>Holder for reflection information generated from ProtoSessionRequestMessage.proto</summary>
  public static partial class ProtoSessionRequestMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for ProtoSessionRequestMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoSessionRequestMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQcm90b1Nlc3Npb25SZXF1ZXN0TWVzc2FnZS5wcm90bxIRcHJvdG9idWZf",
            "b3BlbnZhc3AaE1Byb3RvVmFzcEluZm8ucHJvdG8aElByb3RvTWVzc2FnZS5w",
            "cm90byK7AQoaUHJvdG9TZXNzaW9uUmVxdWVzdE1lc3NhZ2USMAoHbWVzc2Fn",
            "ZRgBIAEoCzIfLnByb3RvYnVmX29wZW52YXNwLlByb3RvTWVzc2FnZRIPCgd0",
            "b3BpY19hGAIgASgJEhUKDWVjZHNoX3B1Yl9rZXkYAyABKAkSDwoHY29tbWVu",
            "dBgEIAEoCRIyCghWYXNwSW5mbxgFIAEoCzIgLnByb3RvYnVmX29wZW52YXNw",
            "LlByb3RvVmFzcEluZm9CJaoCIk9wZW5WQVNQLlByb3RvY29sTWVzc2FnZXMu",
            "TWVzc2FnZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OpenVASP.ProtocolMessages.Messages.ProtoVaspInfoReflection.Descriptor, global::OpenVASP.ProtocolMessages.Messages.ProtoMessageReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OpenVASP.ProtocolMessages.Messages.ProtoSessionRequestMessage), global::OpenVASP.ProtocolMessages.Messages.ProtoSessionRequestMessage.Parser, new[]{ "Message", "TopicA", "EcdshPubKey", "Comment", "VaspInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProtoSessionRequestMessage : pb::IMessage<ProtoSessionRequestMessage> {
    private static readonly pb::MessageParser<ProtoSessionRequestMessage> _parser = new pb::MessageParser<ProtoSessionRequestMessage>(() => new ProtoSessionRequestMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProtoSessionRequestMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OpenVASP.ProtocolMessages.Messages.ProtoSessionRequestMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoSessionRequestMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoSessionRequestMessage(ProtoSessionRequestMessage other) : this() {
      message_ = other.message_ != null ? other.message_.Clone() : null;
      topicA_ = other.topicA_;
      ecdshPubKey_ = other.ecdshPubKey_;
      comment_ = other.comment_;
      vaspInfo_ = other.vaspInfo_ != null ? other.vaspInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoSessionRequestMessage Clone() {
      return new ProtoSessionRequestMessage(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private global::OpenVASP.ProtocolMessages.Messages.ProtoMessage message_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::OpenVASP.ProtocolMessages.Messages.ProtoMessage Message {
      get { return message_; }
      set {
        message_ = value;
      }
    }

    /// <summary>Field number for the "topic_a" field.</summary>
    public const int TopicAFieldNumber = 2;
    private string topicA_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TopicA {
      get { return topicA_; }
      set {
        topicA_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ecdsh_pub_key" field.</summary>
    public const int EcdshPubKeyFieldNumber = 3;
    private string ecdshPubKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EcdshPubKey {
      get { return ecdshPubKey_; }
      set {
        ecdshPubKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "comment" field.</summary>
    public const int CommentFieldNumber = 4;
    private string comment_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Comment {
      get { return comment_; }
      set {
        comment_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "VaspInfo" field.</summary>
    public const int VaspInfoFieldNumber = 5;
    private global::OpenVASP.ProtocolMessages.Messages.ProtoVaspInfo vaspInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::OpenVASP.ProtocolMessages.Messages.ProtoVaspInfo VaspInfo {
      get { return vaspInfo_; }
      set {
        vaspInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProtoSessionRequestMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProtoSessionRequestMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Message, other.Message)) return false;
      if (TopicA != other.TopicA) return false;
      if (EcdshPubKey != other.EcdshPubKey) return false;
      if (Comment != other.Comment) return false;
      if (!object.Equals(VaspInfo, other.VaspInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (message_ != null) hash ^= Message.GetHashCode();
      if (TopicA.Length != 0) hash ^= TopicA.GetHashCode();
      if (EcdshPubKey.Length != 0) hash ^= EcdshPubKey.GetHashCode();
      if (Comment.Length != 0) hash ^= Comment.GetHashCode();
      if (vaspInfo_ != null) hash ^= VaspInfo.GetHashCode();
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
      if (message_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Message);
      }
      if (TopicA.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TopicA);
      }
      if (EcdshPubKey.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(EcdshPubKey);
      }
      if (Comment.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Comment);
      }
      if (vaspInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(VaspInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (message_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Message);
      }
      if (TopicA.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TopicA);
      }
      if (EcdshPubKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EcdshPubKey);
      }
      if (Comment.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Comment);
      }
      if (vaspInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VaspInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProtoSessionRequestMessage other) {
      if (other == null) {
        return;
      }
      if (other.message_ != null) {
        if (message_ == null) {
          Message = new global::OpenVASP.ProtocolMessages.Messages.ProtoMessage();
        }
        Message.MergeFrom(other.Message);
      }
      if (other.TopicA.Length != 0) {
        TopicA = other.TopicA;
      }
      if (other.EcdshPubKey.Length != 0) {
        EcdshPubKey = other.EcdshPubKey;
      }
      if (other.Comment.Length != 0) {
        Comment = other.Comment;
      }
      if (other.vaspInfo_ != null) {
        if (vaspInfo_ == null) {
          VaspInfo = new global::OpenVASP.ProtocolMessages.Messages.ProtoVaspInfo();
        }
        VaspInfo.MergeFrom(other.VaspInfo);
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
            if (message_ == null) {
              Message = new global::OpenVASP.ProtocolMessages.Messages.ProtoMessage();
            }
            input.ReadMessage(Message);
            break;
          }
          case 18: {
            TopicA = input.ReadString();
            break;
          }
          case 26: {
            EcdshPubKey = input.ReadString();
            break;
          }
          case 34: {
            Comment = input.ReadString();
            break;
          }
          case 42: {
            if (vaspInfo_ == null) {
              VaspInfo = new global::OpenVASP.ProtocolMessages.Messages.ProtoVaspInfo();
            }
            input.ReadMessage(VaspInfo);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code