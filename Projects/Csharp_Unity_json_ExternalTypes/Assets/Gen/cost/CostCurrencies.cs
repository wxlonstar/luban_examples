//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.cost
{

public sealed partial class CostCurrencies :  cost.Cost 
{
    public CostCurrencies(JSONNode _json)  : base(_json) 
    {
        { var __json0 = _json["currencies"]; if(!__json0.IsArray) { throw new SerializationException(); } Currencies = new System.Collections.Generic.List<cost.CostCurrency>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { cost.CostCurrency __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = cost.CostCurrency.DeserializeCostCurrency(__e0);  }  Currencies.Add(__v0); }   }
        PostInit();
    }

    public CostCurrencies(System.Collections.Generic.List<cost.CostCurrency> currencies )  : base() 
    {
        this.Currencies = currencies;
        PostInit();
    }

    public static CostCurrencies DeserializeCostCurrencies(JSONNode _json)
    {
        return new cost.CostCurrencies(_json);
    }

    public System.Collections.Generic.List<cost.CostCurrency> Currencies { get; private set; }

    public const int __ID__ = 103084157;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Currencies) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in Currencies) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Currencies:" + Bright.Common.StringUtil.CollectionToString(Currencies) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
