using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERFOLLOWER : MonoBehaviour
{
    public float followSpeed;
    public Transform Target;
    public float NoticeDis;
    // Start is called before the first frame update
    void Start()
    {
        Target = FindObjectOfType<playerCode>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerInRange())
        {
            follow();
        }

    }
    bool IsPlayerInRange()
    {
        float distance = Vector2.Distance(transform.position, Target.position);
        return distance <= NoticeDis;
    }
    void follow()
    {
        Vector3 direction = Target.position - transform.position;
        direction.Normalize();
        transform.position += direction * followSpeed * Time.deltaTime;
    }

}
