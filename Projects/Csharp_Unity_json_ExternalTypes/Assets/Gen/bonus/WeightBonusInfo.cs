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



namespace cfg.bonus
{

public sealed partial class WeightBonusInfo :  Bright.Config.BeanBase 
{
    public WeightBonusInfo(JSONNode _json) 
    {
        { if(!_json["bonus"].IsObject) { throw new SerializationException(); }  Bonus = bonus.Bonus.DeserializeBonus(_json["bonus"]);  }
        { if(!_json["weight"].IsNumber) { throw new SerializationException(); }  Weight = _json["weight"]; }
        PostInit();
    }

    public WeightBonusInfo(bonus.Bonus bonus, int weight ) 
    {
        this.Bonus = bonus;
        this.Weight = weight;
        PostInit();
    }

    public static WeightBonusInfo DeserializeWeightBonusInfo(JSONNode _json)
    {
        return new bonus.WeightBonusInfo(_json);
    }

    public bonus.Bonus Bonus { get; private set; }
    public int Weight { get; private set; }

    public const int __ID__ = -907244058;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Bonus?.Resolve(_tables);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Bonus?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Bonus:" + Bonus + ","
        + "Weight:" + Weight + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
