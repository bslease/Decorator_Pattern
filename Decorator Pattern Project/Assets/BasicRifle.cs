using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicRifle : IRifle
{
    float m_BasicAccuracy = 5.0f;

    public float GetAccuracy()
    {
        return m_BasicAccuracy;
    }
}
