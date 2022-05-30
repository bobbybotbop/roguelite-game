using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyData : MonoBehaviour
{
    public playerData player;
    //public bool isAttacking = false;
    public int health;


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
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Collider2D otherFix = other;

        Debug.Log(other.transform.position);
        if (other.gameObject.tag == "Player")
        {
            player.takeDamage(5);
        }
        if (other.gameObject.tag == "Sword")
        {
            health -= player.sword.getDamage();
        }
        Vector3 difference = (transform.position - other.transform.position);
        transform.position = transform.position + difference;

    }


}
