using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERFOLLOWER : MonoBehaviour
{
    public float followSpeed = 20f;
    public Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPOS = new Vector3(Target.position.x, Target.position.y, transform.position.z);
        transform.position = Vector3.Slerp(transform.position, newPOS, followSpeed * Time.deltaTime);

    }
}
