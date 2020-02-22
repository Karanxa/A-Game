using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    public Transform checkpoint;
    public GameObject player;

    void start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            player.transform.position = checkpoint.position;
            player.transform.rotation = checkpoint.rotation;
        }
    }

}
