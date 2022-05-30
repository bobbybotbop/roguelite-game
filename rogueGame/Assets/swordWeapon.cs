using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordWeapon : weaponClass
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Flip();
    }

    private void Flip()
    {
        Vector3 scale = transform.localScale;
        Vector3 pos = transform.localPosition;
        bool isFlipped;
        if (Input.GetKeyDown(KeyCode.A))
        {
            scale.x *= -1;
            pos.x *= -1;
            transform.localScale = scale;
            transform.localPosition = pos;
            isFlipped = true;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            scale.x *= -1;
            pos.x *= -1;
            transform.localScale = scale;
            transform.localPosition = pos;
            isFlipped = false;

        }
    }
    public int getDamage()
    {
        return this.damage;
    }

}
