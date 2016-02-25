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

namespace Common.Config
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ExchangeConfig : TBase
  {
    private int _level;
    private int _tradersId;
    private List<double> _exchangeRate;

    public int Level
    {
      get
      {
        return _level;
      }
      set
      {
        __isset.level = true;
        this._level = value;
      }
    }

    public int TradersId
    {
      get
      {
        return _tradersId;
      }
      set
      {
        __isset.tradersId = true;
        this._tradersId = value;
      }
    }

    public List<double> ExchangeRate
    {
      get
      {
        return _exchangeRate;
      }
      set
      {
        __isset.exchangeRate = true;
        this._exchangeRate = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool level;
      public bool tradersId;
      public bool exchangeRate;
    }

    public ExchangeConfig() {
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
            if (field.Type == TType.I32) {
              Level = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              TradersId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.List) {
              {
                ExchangeRate = new List<double>();
                TList _list180 = iprot.ReadListBegin();
                for( int _i181 = 0; _i181 < _list180.Count; ++_i181)
                {
                  double _elem182 = (double)0;
                  _elem182 = iprot.ReadDouble();
                  ExchangeRate.Add(_elem182);
                }
                iprot.ReadListEnd();
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
      TStruct struc = new TStruct("ExchangeConfig");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.level) {
        field.Name = "level";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Level);
        oprot.WriteFieldEnd();
      }
      if (__isset.tradersId) {
        field.Name = "tradersId";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TradersId);
        oprot.WriteFieldEnd();
      }
      if (ExchangeRate != null && __isset.exchangeRate) {
        field.Name = "exchangeRate";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Double, ExchangeRate.Count));
          foreach (double _iter183 in ExchangeRate)
          {
            oprot.WriteDouble(_iter183);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ExchangeConfig(");
      sb.Append("Level: ");
      sb.Append(Level);
      sb.Append(",TradersId: ");
      sb.Append(TradersId);
      sb.Append(",ExchangeRate: ");
      sb.Append(ExchangeRate);
      sb.Append(")");
      return sb.ToString();
    }

  }

}