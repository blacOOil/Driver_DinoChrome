using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{

    public float GameSpeed;
    private bool GameStart;
    // Start is called before the first frame update
  
    void Start()
    {
        GameStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStart == true)
        {
            
            Time.timeScale = 0;
          //freeze the game
          
        }
        else
        {
            Time.timeScale = GameSpeed;
            //unfreeze
        }
        if (Input.GetKeyDown("space"))
        {
            GameStart = false;
        }
    }
}
