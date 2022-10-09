using System.Collections;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class FirstPersonScript : MonoBehaviour
{
    private Coroutine _cor;
    private Transform cube;

    private void Start()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube).transform;
        cube.position = corners[0];
    }

    void Update()
    {
        if (_cor == null)
        {
            _cor = StartCoroutine(SelfCoroutine());
        }
    }

    private IEnumerator SelfCoroutine()
    {
        var cubePosition = cube.position;
        var vector3 = new Vector3(0, 0, 1);

        if (cubePosition.Equals(corners[1]))
        {
            Debug.Log("Position equal first corner");
            cubePosition = corners[1];
            vector3 = new Vector3(1, 0, 0);
        }

        // if (cube.position.Equals(corners[2]))
        // {
        //     Debug.Log("Position equal second corner");
        //     vector3 = new Vector3(-1, 0, 0);
        // }
        //
        // if (cube.position.Equals(corners[3]))
        // {
        //     Debug.Log("Position equal third corner");
        //     vector3 = new Vector3(1, 0, 0);
        // }

        cubePosition += vector3 * 0.5f;
        
        yield return null;

        _cor = null;
    }

    private static Vector3[] corners =
    {
        new Vector3(15, -30, -10),
        new Vector3(15, -30, 5),
        new Vector3(0, -30, -5),
        new Vector3(0, -30, -10)
    };

}
