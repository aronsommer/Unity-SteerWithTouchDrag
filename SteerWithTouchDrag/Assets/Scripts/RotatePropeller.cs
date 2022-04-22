using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    public Transform propeller;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            propeller.transform.RotateAround(propeller.transform.position, Vector3.forward, -100 * Time.deltaTime);
        }
    }
}
