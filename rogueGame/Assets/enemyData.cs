using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyData : MonoBehaviour
{
    public int health;
    public int damage;

    public playerData player;
    public Animator anim;
    public BoxCollider2D coll;
    public moveScript mScript;



    private void Awake() {
        Application.targetFrameRate = 60;
    }

    public void load()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<playerData>();
        anim = this.gameObject.GetComponent<Animator>();
        coll = this.gameObject.GetComponent<BoxCollider2D>();
        mScript = this.gameObject.GetComponent<moveScript>();
        anim.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Collider2D otherFix = other;


        if (other.gameObject.tag == "Player")
        {
            player.takeDamage(damage);
        }
        if (other.gameObject.tag == "Weapon")
        {
            health -= other.GetComponentInParent<weaponClass>().getDamage();
        }
        if (health <= 0)
        {
            player.addKill();
            StartCoroutine(Danim(.6f));
        }
        if (mScript.isAlive)
        {

            Vector3 difference = transform.position - other.transform.position;
            transform.position = transform.position + difference;
        }



    }
    IEnumerator Danim(float f)
    {
        mScript.isAlive = false;
        anim.enabled = true;
        coll.enabled = false;
        yield return new WaitForSeconds(f);
        Destroy(this.gameObject);
    }



}
