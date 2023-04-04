using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSystem : MonoBehaviour
{
    public float timeToLiveBullets;

    void Start()
    {
        Destroy(gameObject, timeToLiveBullets); ;
    }
    void Update()
    {

    }
    
}
