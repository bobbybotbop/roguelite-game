using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerData : MonoBehaviour
{
    public float spawnRate;
    public int spawnAmount;
    public GameObject SpawnerType;

    private Vector3 pos;


    // Start is called before the first frame update
    void Start()
    {
        pos = transform.localPosition;
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
            GameObject newEnemy = Instantiate(SpawnerType, new Vector3(Random.Range(pos.x-5, pos.x+5), Random.Range(pos.y-5, pos.y+5),0), Quaternion.identity);
            newEnemy.GetComponent<enemyData>().load();
            newEnemy.GetComponent<moveScript>().load();
        }
    }
}
