using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerData : MonoBehaviour
{
    public HealthBar bar;
    public int health = 100;
    public float attackSpeed = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        bar.SetMaxHealth(health);
        InvokeRepeating("test", 0, attackSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int n)
    {
        health -= n;
        bar.SetHealth(health);
    }
    public void test()
    {
        Debug.Log("gay");
    }

}
