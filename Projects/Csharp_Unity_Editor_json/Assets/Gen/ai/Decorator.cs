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



namespace editor.cfg.ai
{

public abstract partial class Decorator :  ai.Node 
{
    public Decorator()
    {
            FlowAbortMode = ai.EFlowAbortMode.NONE;
    }


    public static Decorator LoadJsonDecorator(SimpleJSON.JSONNode _json)
    {
        string type = _json["$type"];
        Decorator obj;
        switch (type)
        {
            case "ai.UeLoop":   
            case "UeLoop":obj = new ai.UeLoop(); break;
            case "ai.UeCooldown":   
            case "UeCooldown":obj = new ai.UeCooldown(); break;
            case "ai.UeTimeLimit":   
            case "UeTimeLimit":obj = new ai.UeTimeLimit(); break;
            case "ai.UeBlackboard":   
            case "UeBlackboard":obj = new ai.UeBlackboard(); break;
            case "ai.UeForceSuccess":   
            case "UeForceSuccess":obj = new ai.UeForceSuccess(); break;
            case "ai.IsAtLocation":   
            case "IsAtLocation":obj = new ai.IsAtLocation(); break;
            case "ai.DistanceLessThan":   
            case "DistanceLessThan":obj = new ai.DistanceLessThan(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonDecorator(Decorator _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.GetType().Name;
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public ai.EFlowAbortMode FlowAbortMode { get; set; }

}
}
