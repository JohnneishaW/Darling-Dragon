using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Health h;

    //player loses a life on collision with enemy; enemy disappears
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if ("Player".Equals(collision.gameObject.tag) && h.lives<=0)
        bool hitPlayer = collision.collider.GetComponent<Player>() != null;
        if (hitPlayer && h.lives <= 0) 
        {
            Debug.Log("Enemy detected. Losing a life.");
            Destroy(this.gameObject);
            Debug.Log("Lives: " + h.lives);
        }
        if (hitPlayer)
        {
            Debug.Log("Enemy detected. Losing a life.");
            h.removeHealth();
            Debug.Log("Lives: " + h.lives);
        }
       
        
    }
}
