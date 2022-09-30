using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SphereScript : MonoBehaviour
{
    [FormerlySerializedAs("isActiveMove")] public bool isScaleActive = true;
    void Update()
    {
        if (isScaleActive)
        {
            transform.localScale += new Vector3(2, 2, 2) * Time.deltaTime;
        }
    }
}
