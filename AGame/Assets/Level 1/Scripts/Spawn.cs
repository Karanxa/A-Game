using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public Transform[] SpawnPoints;
    public float spawnTime = 0.1f;

    public GameObject obstacles;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Obstacles", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Obstacles()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        Instantiate(obstacles, SpawnPoints[spawnIndex].position,SpawnPoints[spawnIndex].rotation); 
      }


}
