//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.test
{

public sealed partial class DemoE1 :  test.DemoD3 
{
    public DemoE1(ByteBuf _buf)  : base(_buf) 
    {
        X4 = _buf.ReadInt();
        PostInit();
    }

    public static DemoE1 DeserializeDemoE1(ByteBuf _buf)
    {
        return new test.DemoE1(_buf);
    }

    public int X4 { get; protected set; }

    public const int __ID__ = -2138341717;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public void Reload(DemoE1 reloadData)
    {
        X1 = reloadData.X1;
        X3 = reloadData.X3;
        X4 = reloadData.X4;
    }

    public override string ToString()
    {
        return "{ "
        + "X1:" + X1 + ","
        + "X3:" + X3 + ","
        + "X4:" + X4 + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
