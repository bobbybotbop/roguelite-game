using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerData : MonoBehaviour
{
    public float spawnRate;
    public int spawnAmount;
    public GameObject SpawnerType;

    public GameObject pos;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",0, spawnRate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {


        for (int i = 0; i < spawnAmount; i++)
        {
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
            Debug.Log(newEnemy.transform.position);
            newEnemy.GetComponent<enemyData>().load();
            newEnemy.GetComponent<moveScript>().load();
        }
    }
}
