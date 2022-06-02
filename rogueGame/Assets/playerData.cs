using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class playerData : MonoBehaviour
{
    public int kills = 0;
    public swordWeapon sword;
    public HealthBar bar;
    public int health = 100;
    public TextMeshProUGUI ScoreBoard;

    private List<weaponClass> weaponsList = new List<weaponClass>();


    // Start is called before the first frame update
    void Start()
    {
        bar.SetMaxHealth(health);
        InvokeRepeating("test", 0, sword.coolDown);
        weaponsList.Add(sword);

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
            SceneManager.LoadScene("GameOver");
        }
    }
    public void test()
    {
        sword.Attack();
    }

    public void addKill()
    {
        kills++;
        ScoreBoard.text = kills.ToString();
    }

}
