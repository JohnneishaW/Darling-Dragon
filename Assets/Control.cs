using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Control : MonoBehaviour
{   public Rigidbody2D rb;
    [SerializeField] private PolygonCollider2D pc;
    public Vector3 respawnPt;
    public float accelerationTime = 5f;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float time;
    private float speed = 7f;
    private float jumpVelo = 15f;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pc = GetComponent<PolygonCollider2D>();
        respawnPt = transform.position;
    }
    public void Update()
    {
        if (gameObject.tag == "Player")
        {
            float horzIn = Input.GetAxis("Horizontal");
            transform.position = transform.position + new Vector3(horzIn * speed * Time.deltaTime, 0, 0);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector2.up * jumpVelo;
            }

        }
        
        /*
        if (gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.A))
            {
                rb.velocity = new Vector2(-2, 0);
                Debug.Log("Moving left");
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector2(2, 0);
                Debug.Log("Moving right");
            }
            if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = new Vector2(0, 2);
                Debug.Log("Moving up");
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = new Vector2(0, -2);
                Debug.Log("Moving down");
            }
        }
        */
        
        
        if (gameObject.tag == "Enemy")
        {
            time -= Time.deltaTime;
            //get a new random direction every couple of seconds
            if (time <= 0)
            {
                movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
                time += accelerationTime;
            }
        }
        
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
    }

}