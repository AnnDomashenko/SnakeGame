using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ScaleWidthCamera : MonoBehaviour
{

    private int width;
    private int height;

    void Start()
    {
        width = Screen.width;
        height = Screen.height;

        Scale();
    }

    void Update()
    {
        if(width != Screen.width || height != Screen.height)
        {
            Scale();
            width = Screen.width;
            height = Screen.height;
        }
    }

    private void Scale()
    {
        var aspect = Camera.main.aspect;
        var orthographicBase = 10;


        MoveCamera();

        if (aspect > 1.43)
        {
            Camera.main.orthographicSize = 7;

        }
        else
        {
            Camera.main.orthographicSize = orthographicBase / aspect;
        }
    }

    private void MoveCamera()
    {
        var aspect = Camera.main.aspect;
        var prevVector = Camera.main.transform.position;
        Vector3 position;
        if (aspect < 1)
        {
            position = new Vector3(prevVector.x, -2 / aspect, prevVector.z);
        }
        else
        {
            position = new Vector3(prevVector.x, 0, prevVector.z);
        }
        Camera.main.transform.position = position;
    }
}
