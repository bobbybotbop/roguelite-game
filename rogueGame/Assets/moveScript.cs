using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    public Transform player;
    public Transform bush;
    public float speed;

    


    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = Vector3.MoveTowards(transform.position, player.position, speed);
    }


}
