using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPSystem : MonoBehaviour
{
    
    public float Hp;
    private float wait;
    public string SampleScene;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Hp < 0)
        {
             SceneManager.LoadScene(SampleScene);
           
        }
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obtacle"))
        {
            Hp-= 1;
            wait = 0f;
        }
        
    }
    public float GetCurrentHP()
    {
        return Hp;
    }
    
}
