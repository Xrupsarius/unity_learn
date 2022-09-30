using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : MonoBehaviour
{
    public bool isRotateActive = true;
    void Update()
    {
        if (isRotateActive)
        {
            transform.eulerAngles += new Vector3(-5, 0, 0) * Time.deltaTime;
        }
    }
}
