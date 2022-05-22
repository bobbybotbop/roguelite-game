using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerData : MonoBehaviour
{

    public HealthBar bar;

    public int health = 100;


    // Start is called before the first frame update
    void Start()
    {
        bar.SetMaxHealth(health);
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

}
