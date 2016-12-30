/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Config.Table
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SpellCardConfigTable : TBase
  {
    private Dictionary<int, Config.SpellCardConfig> _spellCardConfigMap;

    public Dictionary<int, Config.SpellCardConfig> SpellCardConfigMap
    {
      get
      {
        return _spellCardConfigMap;
      }
      set
      {
        __isset.spellCardConfigMap = true;
        this._spellCardConfigMap = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool spellCardConfigMap;
    }

    public SpellCardConfigTable() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Map) {
              {
                SpellCardConfigMap = new Dictionary<int, Config.SpellCardConfig>();
                TMap _map240 = iprot.ReadMapBegin();
                for( int _i241 = 0; _i241 < _map240.Count; ++_i241)
                {
                  int _key242;
                  Config.SpellCardConfig _val243;
                  _key242 = iprot.ReadI32();
                  _val243 = new Config.SpellCardConfig();
                  _val243.Read(iprot);
                  SpellCardConfigMap[_key242] = _val243;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("SpellCardConfigTable");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (SpellCardConfigMap != null && __isset.spellCardConfigMap) {
        field.Name = "spellCardConfigMap";
        field.Type = TType.Map;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.I32, TType.Struct, SpellCardConfigMap.Count));
          foreach (int _iter244 in SpellCardConfigMap.Keys)
          {
            oprot.WriteI32(_iter244);
            SpellCardConfigMap[_iter244].Write(oprot);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SpellCardConfigTable(");
      sb.Append("SpellCardConfigMap: ");
      sb.Append(SpellCardConfigMap);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
