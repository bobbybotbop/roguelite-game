using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerData : MonoBehaviour
{
    public float spawnRate;
    public int spawnAmount;
    public GameObject SpawnerType;


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
            GameObject newEnemy = Instantiate(SpawnerType, new Vector3(Random.Range(-5f, 5), Random.Range(-5f, 5),0), Quaternion.identity);
        }
    }
}
