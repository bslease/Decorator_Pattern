using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            IRifle rifle = new BasicRifle();
            Debug.Log("Basic accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("s"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(rifle);
            Debug.Log("WithScope accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("t"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithStabilizer(rifle));
            Debug.Log("Stabilizer+Scope accuracy: " + rifle.GetAccuracy());
        }

    }
}
