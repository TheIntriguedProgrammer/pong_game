using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{   /// Declare rigidbody variable to manipulate later in code
   private Rigidbody2D pongballrb;
   public float ballspeed;

   // linking gamemanger to this code
   public GameManager gm;


    // Start is called before the first frame update
    void Start()
    {   
        
        // get the rigidbody component from the ball object and assigning our rigidbody variable
        // we can make the variable public and drag the rigidbody into the variable.

        pongballrb = GetComponent<Rigidbody2D>();

    

        // find the instance of the game manager and assign it to our empty variable
        gm = GameManager.FindInstance();


        //alway rememeber to call your function
        Launch();

    }

    
    private void Launch() 
    {

        // create randomize x and y values for direction
        // For the x value the a random value is taken and if it is less than 0.5 then we assign x a -ive 1 and if false a +ive 1
        float x = Random.value < 0.5 ? -2.0f : 2.0f;


        float y = Random.value < 0.5 ? Random.Range(-1.0f,-0.5f) : Random.Range(0.5f, 1.0f);


        // creating a new 2d vector called direction for our ball
        // new is used becasue we are creating a "new" instance of the Vetcor2 class

        Vector2 direction = new Vector2(x, y);

        // Adding a force to the Ridgid body

        pongballrb.AddForce(direction * ballspeed);
    
    
    
    
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {

        if (collision.gameObject.tag.Equals("Myplayer")) 
        {

            pongballrb.AddForce(pongballrb.velocity *10);

            // check if the collision is working

            Debug.Log("hit ");
        
        
        
        }


        // Detect right border collision
        if (collision.gameObject.tag.Equals("rightboundary"))
        {


            Debug.Log("rightbhit");
            Destroy(gameObject);
            gm.P1score++;
        
            //player One scores
        }

        // Detect left border collision
        if (collision.gameObject.tag.Equals("leftboundary"))
        {
            Debug.Log("leftbhit");
            Destroy(gameObject);
            //player two scores
            gm.P2score++;
            // same as gm.score = gm.score +1
        }
    
    
    
    
    }

   
}
