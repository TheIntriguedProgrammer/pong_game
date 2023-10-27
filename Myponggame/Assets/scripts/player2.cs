using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{


    public float player2speed;
    public float player2range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newposition = transform.position;

        if(Input.GetKey(KeyCode.UpArrow) && transform.position.y < player2range) 
        {
            newposition.y += player2speed;

        
        }
        

        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -player2range) 
        { 
            // shorter version of code that move the player down using the down arrow
            newposition.y -= player2speed; 
        
        
        
        }

        
       

        // updates the transfrom position of the player in the game.
        transform.position = newposition;
    }
}
