using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyData : MonoBehaviour
{
    public playerData player;
    public bool isAttacking = false;


    private void Awake() {
        Application.targetFrameRate = 60;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        player.takeDamage(5);

        Vector3 difference = (transform.position - other.transform.position);
        transform.position = transform.position + difference;

    }


}
