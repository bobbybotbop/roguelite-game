using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponClass : MonoBehaviour
{
    public int damage;
    public float coolDown;
    public int level;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Attack()
    {
        animator.SetTrigger("Attacking"); 
    }

}
