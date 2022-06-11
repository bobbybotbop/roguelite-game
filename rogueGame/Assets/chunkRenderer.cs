using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkRenderer : MonoBehaviour
{
    public int width = 18;
    public int height = 10;

    public GameObject cam;
    public Vector3 mid;

    public GameObject[] chunks;


    public GameObject[,] mapArray;

    void Start()
    {
        mid = transform.position;
        mapArray = new GameObject[,]{
            {chunks[0],chunks[1],chunks[2]},
            {chunks[3],chunks[4],chunks[5]},
            {chunks[6],chunks[7],chunks[8]}
            };
    }

    void LateUpdate()
    {

        if (cam.transform.position.x > mid.x + 9) // right
        {
            mid = new Vector3(mid.x + 18, mid.y, mid.z);
            //Debug.Log("right");
            //Debug.Log(mid);   

            for (int i = 0; i < 3; i++)
            {
                mapArray[i,0].transform.position += new Vector3 (54, 0, 0);
            }

            GameObject[,] previousArray = new GameObject[,]{
                {mapArray[0,0],mapArray[0,1],mapArray[0,2]},
                {mapArray[1,0],mapArray[1,1],mapArray[1,2]},
                {mapArray[2,0],mapArray[2,1],mapArray[2,2]}
            };
            
            for (int j = 0; j < 3; j++)
            {
                mapArray[j, 0] = previousArray[j, 1];
                mapArray[j, 1] = previousArray[j, 2];
                mapArray[j, 2] = previousArray[j, 0];
            }

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Debug.Log(mapArray[a, b]);
                }
            }

        }

        if (cam.transform.position.x < mid.x - 9) // left
        {
            mid = new Vector3(mid.x - 18, mid.y, mid.z);
            // Debug.Log("left");
            // Debug.Log(mid);
            
            for (int i = 0; i < 3; i++)
            {
                mapArray[i,2].transform.position += new Vector3 (-54, 0, 0);
            }

            GameObject[,] previousArray = new GameObject[,]{
                {mapArray[0,0],mapArray[0,1],mapArray[0,2]},
                {mapArray[1,0],mapArray[1,1],mapArray[1,2]},
                {mapArray[2,0],mapArray[2,1],mapArray[2,2]}
            };
            
            for (int j = 0; j < 3; j++)
            {
                mapArray[j, 0] = previousArray[j, 2];
                mapArray[j, 1] = previousArray[j, 0];
                mapArray[j, 2] = previousArray[j, 1];
            }
            

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Debug.Log(mapArray[a, b]);
                }
            }
            
        }
        if (cam.transform.position.y > mid.y + 5) // top
        {
            mid = new Vector3(mid.x, mid.y + 10, mid.z);
            // Debug.Log("top");
            // Debug.Log(mid);

            for (int i = 0; i < 3; i++)
            {
                mapArray[2,i].transform.position += new Vector3 (0, 30, 0);
            }
            
            GameObject[,] previousArray = new GameObject[,]{
                {mapArray[0,0],mapArray[0,1],mapArray[0,2]},
                {mapArray[1,0],mapArray[1,1],mapArray[1,2]},
                {mapArray[2,0],mapArray[2,1],mapArray[2,2]}
            };
            
            for (int j = 0; j < 3; j++)
            {
                mapArray[0, j] = previousArray[2, j];
                mapArray[1, j] = previousArray[0, j];
                mapArray[2, j] = previousArray[1, j];
            }
            

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Debug.Log(mapArray[a, b]);
                }
            }
        }
        if (cam.transform.position.y < mid.y - 5) // bot
        {
            mid = new Vector3(mid.x, mid.y - 10, mid.z);
            // Debug.Log("bottom");
            // Debug.Log(mid);

            for (int i = 0; i < 3; i++)
            {
                mapArray[0,i].transform.position += new Vector3 (0, -30, 0);
            }

                        GameObject[,] previousArray = new GameObject[,]{
                {mapArray[0,0],mapArray[0,1],mapArray[0,2]},
                {mapArray[1,0],mapArray[1,1],mapArray[1,2]},
                {mapArray[2,0],mapArray[2,1],mapArray[2,2]}
            };
            
            for (int j = 0; j < 3; j++)
            {
                mapArray[0, j] = previousArray[1, j];
                mapArray[1, j] = previousArray[2, j];
                mapArray[2, j] = previousArray[0, j];
            }
            

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Debug.Log(mapArray[a, b]);
                }
            }
        }
    }
}
