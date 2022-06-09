using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbWeapon : weaponClass
{
    // Start is called before the first frame update
    public Transform rotationCenter;

    float rotationRadius = 2f;
    float posX, posY, angle = 0f;
    float rotationSpeed;
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }
    public new void Attack()
    {
        rotationSpeed = attackSpeed;
        posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius;
        posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius;
        transform.position = new Vector2(posX, posY);
        angle = angle + Time.deltaTime * rotationSpeed;

        if(angle >= 360f)
        {
            angle = 0f;
        }
        coll.enabled = true;

    }
}
