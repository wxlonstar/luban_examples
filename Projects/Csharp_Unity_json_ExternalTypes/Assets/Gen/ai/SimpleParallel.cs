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



namespace cfg.ai
{

public sealed partial class SimpleParallel :  ai.ComposeNode 
{
    public SimpleParallel(JSONNode _json)  : base(_json) 
    {
        { if(!_json["finish_mode"].IsNumber) { throw new SerializationException(); }  FinishMode = (ai.EFinishMode)_json["finish_mode"].AsInt; }
        { if(!_json["main_task"].IsObject) { throw new SerializationException(); }  MainTask = ai.Task.DeserializeTask(_json["main_task"]);  }
        { if(!_json["background_node"].IsObject) { throw new SerializationException(); }  BackgroundNode = ai.FlowNode.DeserializeFlowNode(_json["background_node"]);  }
        PostInit();
    }

    public SimpleParallel(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, ai.EFinishMode finish_mode, ai.Task main_task, ai.FlowNode background_node )  : base(id,node_name,decorators,services) 
    {
        this.FinishMode = finish_mode;
        this.MainTask = main_task;
        this.BackgroundNode = background_node;
        PostInit();
    }

    public static SimpleParallel DeserializeSimpleParallel(JSONNode _json)
    {
        return new ai.SimpleParallel(_json);
    }

    public ai.EFinishMode FinishMode { get; private set; }
    public ai.Task MainTask { get; private set; }
    public ai.FlowNode BackgroundNode { get; private set; }

    public const int __ID__ = -1952582529;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        MainTask?.Resolve(_tables);
        BackgroundNode?.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        MainTask?.TranslateText(translator);
        BackgroundNode?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "FinishMode:" + FinishMode + ","
        + "MainTask:" + MainTask + ","
        + "BackgroundNode:" + BackgroundNode + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
