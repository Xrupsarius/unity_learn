using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CubeScript : MonoBehaviour
{
    [FormerlySerializedAs("isPosition")] public bool isMovePosition = true;
    void Update()
    {
        if (isMovePosition)
        {
            transform.position += new Vector3(0, 0, 2) * Time.deltaTime;
        }
    }
}
