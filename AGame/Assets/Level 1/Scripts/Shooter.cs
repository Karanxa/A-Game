using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shooter : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce = 50f;

    private GameObject[] theStack;

    private int stackIndex;
    private bool isMoveOnX = true;
    private int score = 0;
    private Vector3 desiredPos;

  
    private const float Stack_Moving_Speed = 5.0f;


    // Update is called once per frame
    void Start()
    {
       
        theStack = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            theStack[i] = transform.GetChild(i).gameObject;

            stackIndex = transform.childCount - 1;


        }
    }

    void FixedUpdate()
    {   

        
        rb.AddForce(0, 0, (-forwardForce) * Time.deltaTime);
    }

    // Update is called once per frame
    private void Update()
    {
      
    
        // Vector3 movement = new Vector3(0,0,0);
        //rb.AddForce(movement*speed);
        Spawn();
        score++;
        // }
        // Put a condition if ball lands on the cube

    }

    //  transform.position = Vector3.Lerp(transform.position, 0, desiredPos);


private void Spawn()
{
    stackIndex--;
    if (stackIndex < 0)
    {
        stackIndex = transform.childCount - 1;
    }

    desiredPos = (Vector3.down) * score;
    theStack[stackIndex].transform.localPosition = new Vector3(0, 0, score);

}


}
