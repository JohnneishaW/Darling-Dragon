using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //destroys flag on player collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ("Player".Equals(collision.gameObject.tag))
        {
            Destroy(this.gameObject);
            Debug.Log("You Won! Level Complete.");
        }
        

    }
}
