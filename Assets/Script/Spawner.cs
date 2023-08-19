using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] Castus;

    [SerializeField] float secondSpawn = 1f;

    [SerializeField] float minTras;

    [SerializeField] float maxTras;

    void Start()
    {
        StartCoroutine(castusspawn());
    }

    IEnumerator castusspawn()
    {
        
            while(true)
            {
                var wanted = Random.Range(minTras,maxTras);
                var position = new Vector3(wanted, transform.position.y);
                GameObject gameObject = Instantiate(Castus[Random.Range(0, Castus.Length)],position,Quaternion.identity);
                yield return new WaitForSeconds(secondSpawn);
            }
        
    }
}