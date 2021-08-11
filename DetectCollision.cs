// when collide destroy 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    

    // Update is called once per frame
    private void OnTriggerEnter(collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
