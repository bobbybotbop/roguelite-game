using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class playerData : MonoBehaviour
{
    public int kills = 0;
    public int health = 100;
    public int multiply = 0;
    public bool neverDone;

    public swordWeapon sword;
    public HealthBar bar;
    public TextMeshProUGUI ScoreBoard;



    private List<weaponClass> weaponsList = new List<weaponClass>();


    // Start is called before the first frame update
    void Start()
    {
        bar.SetMaxHealth(health);
        InvokeRepeating("test", 0, sword.coolDown);
        weaponsList.Add(sword);
        neverDone = true;
        ScoreBoard.text = kills.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void takeDamage(int n)
    {
        health -= n;
        bar.SetHealth(health);
        
        if(health <= 0)
        {
            //SceneManager.LoadScene("GameOver");
        }
       
        
    }
    public void test()
    {
        sword.Attack();
    }

    public void addKill()
    {
        if (kills % 25 != 0)
        {
            neverDone = true;
        }

        kills++;
        ScoreBoard.text = kills.ToString();
        multiply = kills / 25; // every 25 it multiplies
        if (neverDone)
        {
            if (kills % 50 == 0 && gameObject.GetComponent<SpawnerData>().spawnRate >= .4f)
            {
                gameObject.GetComponent<SpawnerData>().spawnRate -= .1f;
                neverDone = false;

            }
            else if (kills % 25 == 0 && gameObject.GetComponent<SpawnerData>().spawnAmount <= 4)
            {
                gameObject.GetComponent<SpawnerData>().spawnAmount += 1;
                neverDone = false;
                
            }
        }

    }

    public void addWeapon()
    {

        Debug.Log(weaponsList.Capacity);
        Debug.Log(weaponsList);
        /*
        if (weaponsList.Capacity <=2)
        {
            weapons++;
        }
        */
    }
}
