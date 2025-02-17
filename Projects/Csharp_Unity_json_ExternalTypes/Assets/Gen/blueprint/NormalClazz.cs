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



namespace cfg.blueprint
{

public sealed partial class NormalClazz :  blueprint.Clazz 
{
    public NormalClazz(JSONNode _json)  : base(_json) 
    {
        { if(!_json["is_abstract"].IsBoolean) { throw new SerializationException(); }  IsAbstract = _json["is_abstract"]; }
        { var __json0 = _json["fields"]; if(!__json0.IsArray) { throw new SerializationException(); } Fields = new System.Collections.Generic.List<blueprint.Field>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { blueprint.Field __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = blueprint.Field.DeserializeField(__e0);  }  Fields.Add(__v0); }   }
        PostInit();
    }

    public NormalClazz(string name, string desc, System.Collections.Generic.List<blueprint.Clazz> parents, System.Collections.Generic.List<blueprint.Method> methods, bool is_abstract, System.Collections.Generic.List<blueprint.Field> fields )  : base(name,desc,parents,methods) 
    {
        this.IsAbstract = is_abstract;
        this.Fields = fields;
        PostInit();
    }

    public static NormalClazz DeserializeNormalClazz(JSONNode _json)
    {
        return new blueprint.NormalClazz(_json);
    }

    public bool IsAbstract { get; private set; }
    public System.Collections.Generic.List<blueprint.Field> Fields { get; private set; }

    public const int __ID__ = -2073576778;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Fields) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in Fields) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Parents:" + Bright.Common.StringUtil.CollectionToString(Parents) + ","
        + "Methods:" + Bright.Common.StringUtil.CollectionToString(Methods) + ","
        + "IsAbstract:" + IsAbstract + ","
        + "Fields:" + Bright.Common.StringUtil.CollectionToString(Fields) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
