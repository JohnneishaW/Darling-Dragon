using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*controls player health*/
public class Health : MonoBehaviour
{
    public int lives = 1;
    public Player p;
    public Text health;
    //public Respawn r;

    // Start is called before the first frame update
    void Start()
    {
        lives = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showHealth()
    {
        health.text = "Health: " + health.ToString();
    }
    public void addHealth()
    {
        lives += 1;
    }

    public void removeHealth()
    {
        lives -= 1;
        checkLives();
    }

    //private?
    public void resetHealth()
    {
        lives = 1;
        Debug.Log("Lives: " + lives);
    }

    private void checkLives()
    {
        if (lives < 0)
        {
            resetHealth();
            p.respawnPlayer();
        }
       
    }
}
