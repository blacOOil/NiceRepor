using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kmean : MonoBehaviour
{
    [SerializeField] private GameObject centerObject;
    
    [SerializeField] private float radius = 2f;
    [SerializeField] private float speed = 2f;
    public GameObject itself;
    public Transform Center;
    public Transform SndCenter;
   
    public float DistanForimpact;
    public float livespan;
    public float followSpeed;
    public float followRadius;

    private Vector3 _lastCenterPos;
    private float _angle = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Center = FindObjectOfType<MitosisSpawner>().transform;
        _lastCenterPos = Center.position;
        SndCenter = FindObjectOfType<playerCode>().transform;
        Destroy(itself, livespan);

    }

    // Update is called once per frame
    void Update()
    {
       
        Center = FindObjectOfType<MitosisSpawner>().transform;
        if (PlayerChecker()) 
        {
            Playerfollower();
        }
        else
     
        {
           SpinAround();
           follower();
         
        }


    }
    public void follower()
    {
        var targetPos = Center.position + (transform.position - Center.position).normalized * followRadius;
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * followSpeed);

        var direction = (Center.position - transform.position).normalized;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
    }
    public void SpinAround()
    {
        _angle += speed * Time.deltaTime;

        var offset = new Vector3(Mathf.Sin(_angle), Mathf.Cos(_angle), 0f) * radius;
        transform.position = Center.position + offset;

        var direction = (transform.position - _lastCenterPos).normalized;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);

        _lastCenterPos = Center.position;
    }
    public void Playerfollower()
    {
        Vector3 direction = SndCenter.position - transform.position;
        direction.Normalize();
        transform.position += direction * speed * Time.deltaTime;
    }
    bool PlayerChecker()
    {
        float distance = Vector2.Distance(transform.position, SndCenter.position);
        return distance <= DistanForimpact;
    }
}
