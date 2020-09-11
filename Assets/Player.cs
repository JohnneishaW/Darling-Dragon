using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Health h;

    void Start()
    {
        //set health;
        h.resetHealth();
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void respawnPlayer()
    {   
        StartCoroutine("Wait");
        Debug.Log("Respawning Player");
        h.resetHealth();
        this.transform.position = new Vector2(-6, -3);
        Debug.Log("Player successfully respawned.");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(8);
    }
    /*
    public void killPlayer()
    {
        Destroy(this.gameObject);
        //respawnPlayer();
    }

    
    private void respawnPlayer()
    {
        h.resetHealth();
        //Renderer.Instantiate(this, new Vector2(0, 0), quaternion.identity);
    }
    */
}
