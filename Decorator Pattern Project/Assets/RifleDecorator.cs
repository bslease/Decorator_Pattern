using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class RifleDecorator : IRifle
{
    protected IRifle m_DecoratedRifle;

    public RifleDecorator(IRifle rifle)
    {
        m_DecoratedRifle = rifle;
    }

    public virtual float GetAccuracy()
    {
        return m_DecoratedRifle.GetAccuracy();
    }
}

public class WithScope : RifleDecorator
{
    float m_ScopeAccuracy = 20.0f;
    public WithScope(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_ScopeAccuracy;
    }
}

public class WithStabilizer : RifleDecorator
{
    float m_StabilizerAccuracy = 10.0f;
    public WithStabilizer(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_StabilizerAccuracy;
    }
}
