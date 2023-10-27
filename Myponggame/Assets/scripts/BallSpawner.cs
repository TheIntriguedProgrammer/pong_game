using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{


    public GameObject ball;
    // Update is called once per frame
    void Update()
    {
        // if ball is not in the scene, create a new ball
        if (GameObject.Find("Ball(Clone)") == null )
        {

            // creates an instance of the ball in the scene
            Instantiate(ball);
        }
        
    }
}
