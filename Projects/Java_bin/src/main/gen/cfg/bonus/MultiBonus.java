
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.bonus;

import bright.serialization.*;



public final class MultiBonus extends cfg.bonus.Bonus {
    public MultiBonus(ByteBuf _buf) { 
        super(_buf);
        {int n = Math.min(_buf.readSize(), _buf.size());bonuses = new cfg.bonus.Bonus[n];for(int i = 0 ; i < n ; i++) { cfg.bonus.Bonus _e;_e = cfg.bonus.Bonus.deserializeBonus(_buf); bonuses[i] = _e;}}
    }

    public MultiBonus(cfg.bonus.Bonus[] bonuses ) {
        super();
        this.bonuses = bonuses;
    }


    public final cfg.bonus.Bonus[] bonuses;

    public static final int __ID__ = 1421907893;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        for(cfg.bonus.Bonus _e : bonuses) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "bonuses:" + bonuses + ","
        + "}";
    }
}
