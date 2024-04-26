using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb;
    public float impulseForce = 3;

    private bool ignoreNextcollision;

    private Vector3 starPosition;

    private void Start()
    {
        starPosition= transform.position;
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        if(ignoreNextcollision)
        {
            return;
        }
        
        DeatPart deathPart = collision.transform.GetComponent<DeatPart>();
        if(deathPart) 


        {
           GameManager.singleton.RestartLevel();
        }

        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up*impulseForce,ForceMode.Impulse);

        ignoreNextcollision= true;
        Invoke("AllowNextCollision", 0.2f);
    }

    private void AllowNextCollision()
    {
        ignoreNextcollision = false;
    }

    public void ResetBall()
    {
        transform.position = starPosition;
    }
}
