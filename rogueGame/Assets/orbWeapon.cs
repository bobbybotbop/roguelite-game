using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbWeapon : weaponClass
{
    // Start is called before the first frame update
    public Transform rotationCenter;

    float rotationRadius = 2.5f;
    float posX, posY, angle = 0f;
    float rotationSpeed;

    bool isActive = true;

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
        rotationSpeed = attackSpeed * level / 2;
        posX = rotationCenter.position.x + Mathf.Sin(angle) * rotationRadius;
        posY = rotationCenter.position.y + Mathf.Cos(angle) * rotationRadius;
        transform.position = new Vector2(posX, posY);
        angle = angle + Time.deltaTime * rotationSpeed;

        if (angle >= 360f)
        {
            angle = 0f;
            
        }
        coll.enabled = true;

    }

    IEnumerator wait()

    {
        yield return new WaitForSeconds(coolDown);
        Debug.Log("");
        //GameObject.enabled = false;
    }
}