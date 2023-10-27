using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// tell unity what we are using
using TMPro;

public class GameManager : MonoBehaviour
{
    public int P1score;
    public int P2score;

    // our text boxes will become varibales
    public TMP_Text scoreOnetext;
    public TMP_Text scoretwotext;
    public TMP_Text winnertext;

    // create a GameObject for the ballSpawnwer because we will have to turn it off when a player wins.
    public GameObject ballSpawner;
    #region SingletonDeclaration 
    private static GameManager instance;
    public static GameManager FindInstance()
    {
        return instance; //that's just a singleton as the region says
    }

    void Awake() //this happens before the game even starts and it's a part of the singleton
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else if (instance == null)
        {
            //DontDestroyOnLoad(this);
            instance = this;
        }
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // assign the score text variable with the actual scores and convert what is recieved to a string to be displayed as text
        scoreOnetext.text = P1score.ToString();
        scoretwotext.text = P2score.ToString();

        // determines the winner - first player to get to 11 points wins
        // the ' ||' symbol means OR.
        if (P1score == 11 || P2score == 11 )
        {
            // When the player wins, the ball spawner needs to be turned off, using SetActive function
            
            ballSpawner.SetActive(false);

            if (P1score == 11)
            {
                Debug.Log("player one wins");
                winnertext.text = "Player 1 wins!";




            }
            if (P2score == 11)
            {
                Debug.Log("Player two wins!");
                winnertext.text = "Player 2 wins!";
            }





        }












    }
}
