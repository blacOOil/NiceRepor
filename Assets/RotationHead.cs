using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationHead : MonoBehaviour
{
    Vector3 mousePOS;

    Camera cam;
    Rigidbody2D rid;
    // Start is called before the first frame update
    void Start()
    {
        rid = this.GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        rotate();
    }
    void rotate()
    {
        mousePOS = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z - cam.transform.position.z));
        rid.transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mousePOS.y - transform.position.y), (mousePOS.x - transform.position.x)) * Mathf.Rad2Deg);
    }
}

