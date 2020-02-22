using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    public Transform BoomEffect;
    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Destroy(gameObject);
            movement.enabled = false;
            Instantiate(BoomEffect, transform.position, BoomEffect.rotation);
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}