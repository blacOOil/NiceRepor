using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bullet has collided with an enemy.
        if (other.CompareTag("BULLET"))
        {
            // If the bullet has hit an enemy, destroy the enemy game object.
            Destroy(gameObject);
        }
    }
}
