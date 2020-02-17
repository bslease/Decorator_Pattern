using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    Vector3 nextPos = Vector3.zero;
    IRifle currentRifle;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            IRifle rifle = new BasicRifle(nextPos);
            currentRifle = rifle;
            Debug.Log("Basic accuracy: " + rifle.GetAccuracy());
            nextPos += new Vector3(1, 0, 0);
        }

        if (Input.GetKeyDown("s"))
        {
            IRifle rifle = new BasicRifle(nextPos);
            rifle = new WithScope(rifle);
            currentRifle = rifle;
            Debug.Log("WithScope accuracy: " + rifle.GetAccuracy());
            nextPos += new Vector3(1, 0, 0);
        }

        if (Input.GetKeyDown("t"))
        {
            IRifle rifle = new BasicRifle(nextPos);
            rifle = new WithScope(new WithStabilizer(rifle));
            currentRifle = rifle;
            Debug.Log("Stabilizer+Scope accuracy: " + rifle.GetAccuracy());
            nextPos += new Vector3(1, 0, 0);
        }

        // demonstrate order doesn't matter
        if (Input.GetKeyDown("y"))
        {
            IRifle rifle = new BasicRifle(nextPos);
            rifle = new WithStabilizer(new WithScope(rifle));
            currentRifle = rifle;
            Debug.Log("Scope+Stabilizer accuracy: " + rifle.GetAccuracy());
            nextPos += new Vector3(1, 0, 0);
        }

        if (Input.GetKeyDown("d"))
        {
            if (currentRifle != null)
            {
                GameObject.Destroy(currentRifle.GetGameObject());
                currentRifle = null;
            }
        }
    }
}
