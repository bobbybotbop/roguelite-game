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


    }
    public void Attack()
    {
        animator.SetTrigger("Attacking");
        StartCoroutine(wait(attackSpeed));

    }

}
