using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerData : MonoBehaviour
{
    public swordWeapon sword;
    public HealthBar bar;
    public int health = 100;
    private List<weaponClass> weaponsList = new List<weaponClass>();


    // Start is called before the first frame update
    void Start()
    {
        bar.SetMaxHealth(health);
        InvokeRepeating("test", 0, sword.coolDown);
        weaponsList.Add(sword);
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
        sword.Attack();
    }

}
