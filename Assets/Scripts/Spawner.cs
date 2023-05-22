using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnerTime = 5f;

    public List<GameObject> Obstacles = new List<GameObject>();
    void Start()
    {
        
    }
    float TempCont;
    // Update is called once per frame
    void Update()
    {
        TempCont += Time.deltaTime;
        if (TempCont >= SpawnerTime)
        {
            Instantiate(Obstacles[Random.Range(0,Obstacles.Count)], transform.position, transform.rotation);

            TempCont = 0f;
        }
    }
}
