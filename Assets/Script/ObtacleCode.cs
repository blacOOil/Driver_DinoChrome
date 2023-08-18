using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtacleCode : MonoBehaviour
{
    public float ObtacleSpeed = 5f;
    public Transform ChangePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + Vector3.left * ObtacleSpeed * Time.deltaTime;
        transform.position = newPosition;
    }
}
