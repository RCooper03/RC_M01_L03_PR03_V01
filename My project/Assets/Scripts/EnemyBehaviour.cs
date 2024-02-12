using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // 1
    private void OnTriggerEnter(Collider other)
    {
        // 2
        if(other.name == "Player")
        {
            Debug.Log("Player detected - attack!");
        }
    }

    // 3
    private void OnTriggerExit(Collider other)
    {
        // 4
        if(other.name == "Player")
        {
            Debug.Log("Player out of range, resume patrol");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
