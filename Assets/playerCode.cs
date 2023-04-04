using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCode : MonoBehaviour
{
    public GameObject Bullet;
    public Transform Barel;
    public float fireForce;
    public Rigidbody2D PlayerRigid;
    public float force;
    AudioSource audioClip;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRigid = GetComponent<Rigidbody2D>();
        audioClip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerRigid.velocity = Vector2.up * force * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerRigid.velocity = Vector2.down * force * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerRigid.velocity = Vector2.left * force * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerRigid.velocity = Vector2.right * force * Time.deltaTime;
        }
        if ((Input.GetKeyDown(KeyCode.A)) && (Input.GetKeyDown(KeyCode.W) == true))
        {
            PlayerRigid.velocity = Vector2.up * force * Time.deltaTime;
            PlayerRigid.velocity = Vector2.left * force * Time.deltaTime;
        }
        if ((Input.GetKeyDown(KeyCode.D)) && (Input.GetKeyDown(KeyCode.W) == true))
        {
            PlayerRigid.velocity = Vector2.up * force * Time.deltaTime;
            PlayerRigid.velocity = Vector2.right * force * Time.deltaTime;
        }
        if ((Input.GetKeyDown(KeyCode.D)) && (Input.GetKeyDown(KeyCode.S) == true))
        {
            PlayerRigid.velocity = Vector2.down * force * Time.deltaTime;
            PlayerRigid.velocity = Vector2.right * force * Time.deltaTime;
        }
        if ((Input.GetKeyDown(KeyCode.A)) && (Input.GetKeyDown(KeyCode.S) == true))
        {
            PlayerRigid.velocity = Vector2.down * force * Time.deltaTime;
            PlayerRigid.velocity = Vector2.left * force * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            audioClip.Play();
            fire();
        }

    }
    public void fire()
    {
        
        GameObject Bullets = Instantiate(Bullet, Barel.position, Barel.rotation);
        Bullets.GetComponent<Rigidbody2D>().AddForce(Barel.up * fireForce, ForceMode2D.Impulse);
    }
}

