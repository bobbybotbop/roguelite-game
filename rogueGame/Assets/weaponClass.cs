using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponClass : MonoBehaviour
{
    public int damage;
    public float coolDown;
    public int level;
    public float attackSpeed;

    public Animator animator;
    public CircleCollider2D coll;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator wait(float f)
    {
        yield return new WaitForSeconds(f);
        animator.SetTrigger("Done");
        coll.enabled = false;


    }
    public void Attack()
    {
        animator.SetTrigger("Attacking");
        coll.enabled = true;
        StartCoroutine(wait(attackSpeed));


    }
    public int getDamage()
    {
        return this.damage;
    }

}
