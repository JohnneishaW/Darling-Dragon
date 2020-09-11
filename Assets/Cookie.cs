using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    public Health h;
    
       

    //player gains a life on collision with cookie; cookie disappears
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        bool hitPlayer = collision.collider.GetComponent<Player>() != null;
        if(hitPlayer)//if ("Player".Equals(collision.gameObject.tag))
        {
            Destroy(this.gameObject);
        }
        if (hitPlayer)
        {
            Debug.Log("Cookie collected. Adding a life..");
            h.addHealth();
            Debug.Log(h.lives);
        }
        
        
    }
}
