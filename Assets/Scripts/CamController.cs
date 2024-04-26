using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public BallController Ball;

    private float offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.y-Ball.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 actualPos = transform.position;
        actualPos.y = Ball.transform.position.y + offset;
        transform.position = actualPos;
    }
}
