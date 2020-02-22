using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce = 50f;
  

    public float speedMultiplier;
    public float speedMilestone;
    private float speedMilestoneCount;



    // Update is called once per frame
    void Start()
    {
        speedMilestoneCount = speedMilestone;
    }


    void FixedUpdate ()
    {
        if(transform.position.z > speedMilestoneCount)
        {
            speedMilestoneCount += speedMilestone;
            speedMilestone = speedMilestone * speedMultiplier;
            forwardForce = forwardForce * speedMultiplier;
        }


        rb.AddForce(0, forwardForce * Time.deltaTime, 0);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -10f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
