using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkRenderer : MonoBehaviour
{
    public int width = 18;
    public int height = 10;

    public GameObject cam;
    public Vector3 mid;

    public List<GameObject> chunkList = new List<GameObject>();

    void Start()
    {
        mid = transform.position;
    }

    void LateUpdate()
    {

        if (cam.transform.position.x > mid.x + 9)
        {
            Debug.Log("right");
            mid = new Vector3(mid.x + 18, mid.y, mid.z);
            Debug.Log(mid);
        }

        if (cam.transform.position.x < mid.x - 9)
        {
            mid = new Vector3(mid.x - 18, mid.y, mid.z);
            Debug.Log("left");
            Debug.Log(mid);
        }
        if (cam.transform.position.y > mid.y + 5)
        {
            mid = new Vector3(mid.x, mid.y + 10, mid.z);
            Debug.Log("top");
            Debug.Log(mid);
        }
        if (cam.transform.position.y < mid.y - 5)
        {
            mid = new Vector3(mid.x, mid.y - 10, mid.z);
            Debug.Log("bottom");
            Debug.Log(mid);
        }
    }
}
