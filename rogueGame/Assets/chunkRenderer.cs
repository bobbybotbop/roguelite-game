using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkRenderer : MonoBehaviour
{
    public int width = 18;
    public int height = 10;

    public GameObject cam;
    public Vector3 mid;

    void Start()
    {
        mid = cam.transform.position;
    }

    void LateUpdate()
    {

        // if(cam.transform.position.x + 9 > width-9)
        // {
        //     Debug.Log("right");
        // }

        // if(cam.transform.position.x + 9 < width-9)
        // {
        //     Debug.Log("right");
        // }

        // if(cam.transform.position.y + 5 > height-5)
        // {
        //     Debug.Log("top");
        // }

        // if(cam.transform.position.y + 5 < height-5)
        // {
        //     Debug.Log("down");
        // }

    }
}
