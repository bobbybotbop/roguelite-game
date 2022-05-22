using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyData : MonoBehaviour
{
    public playerData player;
    public bool isAttacking = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        float timer = 0;
        timer += Time.deltaTime;

        while (timer < 3)
        {
            Debug.Log("test");
        }

    }
}
