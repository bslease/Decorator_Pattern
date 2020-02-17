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

    public virtual GameObject GetGameObject()
    {
        return m_DecoratedRifle.GetGameObject();
    }
}

public class WithScope : RifleDecorator
{
    float m_ScopeAccuracy = 20.0f;
    string prefabPath = "Scope";
    GameObject model; // instantiated prefab

    public WithScope(IRifle rifle) : base(rifle)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_ScopeAccuracy;
    }
}

public class WithStabilizer : RifleDecorator
{
    float m_StabilizerAccuracy = 10.0f;
    string prefabPath = "Stabilizer";
    GameObject model; // instantiated prefab

    public WithStabilizer(IRifle rifle) : base(rifle)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_StabilizerAccuracy;
    }
}
