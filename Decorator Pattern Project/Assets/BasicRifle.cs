using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicRifle : IRifle
{
    float m_BasicAccuracy = 5.0f;
    string prefabPath = "Barrel";
    public GameObject model; // instantiated prefab

    public float GetAccuracy()
    {
        return m_BasicAccuracy;
    }

    public GameObject GetGameObject()
    {
        return model;
    }

    public BasicRifle()
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(model);
    }

    public BasicRifle(Vector3 worldPos)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab, worldPos, prefab.transform.rotation);
    }
}
