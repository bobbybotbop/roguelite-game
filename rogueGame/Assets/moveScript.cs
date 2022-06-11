using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    public Transform player;
    public Transform bush;
    public float speed;
    public bool isAlive = true;


    void Start ()
    {
        
    }
    public void load()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    // Update is called once per frame
    void LateUpdate()
    {
        if (isAlive)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, Time.timeScale * speed);
        }

    }


}
