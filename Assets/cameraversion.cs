using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraversion : MonoBehaviour
{

    // Start is called before the first frame update
    public float followSpeed = 5f;
    public Transform Target;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPOS = new Vector3(Target.position.x, Target.position.y, transform.position.z);
        transform.position = Vector3.Slerp(transform.position, newPOS, followSpeed * Time.deltaTime);

    }
}

