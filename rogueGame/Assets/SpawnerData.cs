using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerData : MonoBehaviour
{
    public float spawnRate;
    public int spawnAmount;
    public GameObject SpawnerType;
    int randomInt;

    public List<GameObject> allSpawns = new List<GameObject>(); // increasing difficulty

    public GameObject pos;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, spawnRate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {


        for (int i = 0; i < spawnAmount; i++)
        {

            //random enemy
            randomInt = (int)Random.Range(0, 100);
            Debug.Log(randomInt);
            /* 0-50 small boi
             51-85 medium
            86-100 big big chungus big chungus*/
            if ((randomInt >= 51 && randomInt <= 90) && pos.GetComponent<playerData>().multiply >= 1)
            {
                SpawnerType = allSpawns[1];
            }
            else if (randomInt > 90 && pos.GetComponent<playerData>().multiply >= 2)
            {
                SpawnerType = allSpawns[2];
            }
            else
            {
                SpawnerType = allSpawns[0];
            }

            float ranX = Random.Range(pos.transform.position.x - 5, pos.transform.position.x + 5);
            float ranY = Random.Range(pos.transform.position.y - 5, pos.transform.position.y + 5);

            while (ranX < 3 && ranX > -3)
            {
                ranX = Random.Range(pos.transform.position.x - 5, pos.transform.position.x + 5);
            }
            while (ranY < 3 && ranY > -3)
            {
                ranY = Random.Range(pos.transform.position.y - 5, pos.transform.position.y + 5);
            }

            GameObject newEnemy = Instantiate(SpawnerType, new Vector3(ranX, ranY,0), Quaternion.identity);
            newEnemy.GetComponent<enemyData>().load();
            newEnemy.GetComponent<moveScript>().load();
        }
    }
}
