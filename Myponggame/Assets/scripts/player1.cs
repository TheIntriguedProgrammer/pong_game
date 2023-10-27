using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{


    public float player1speed;
    public float player1range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // create variable that collects curent position 
      Vector3 newPosition = transform.position;



      if (Input.GetKey("w") && transform.position.y < player1range)
      {
            //newposition.y+newPosition+1f;
            //shorter version
        newPosition.y += player1speed;
       }

      if (Input.GetKey("s") && transform.position.y > -player1range) {
           
            
            //shorter version
        newPosition.y -= player1speed;
        }

      transform.position = newPosition;




    }
}
