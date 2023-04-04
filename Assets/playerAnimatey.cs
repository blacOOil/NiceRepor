using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimatey : MonoBehaviour
    
{
    public Animator animator;
    public float Moment;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.W))
        {
            Moment = 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Moment = 1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Moment = 1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Moment = 1;
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            Moment = 0;
        }

        animator.SetFloat("Speed", Mathf.Abs(Moment));
    }
}
