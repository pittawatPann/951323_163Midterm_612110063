using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject[] Prefabs;
    public GameObject[] Spawnpoint;
    
    [SerializeField]
    private float TimeBetweenwave =1f;
    [SerializeField]
    private float TimeTospawn = 2f;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= TimeTospawn)
        {
                SpawnBlock();
             TimeTospawn = Time.time + TimeBetweenwave;
        }
        
        
    }
    void SpawnBlock()
    {
        int randomIndex = Random.Range(0, Spawnpoint.Length);
        int randomball = Random.Range(0, Prefabs.Length);
        for(int i = 0; i< Spawnpoint.Length; i++)
        {
            if(randomIndex != i)
            {
                Instantiate(Prefabs[randomball], Spawnpoint[i].transform.position, Quaternion.identity);
            }
        }
        
    }
}
