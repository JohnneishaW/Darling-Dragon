using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* NOT FULLY IMPLEMENTED INTO GAME. 
     * When the player reaches the flag, the level is completed. 
     * The UI will show "You Won!"
 */
public class ShowUI : MonoBehaviour
{
    

    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        ui.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ("Player".Equals(collision.gameObject.tag))
        {   ui.SetActive(true);
            StartCoroutine("Wait");
        }
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        Destroy(ui);
        Destroy(gameObject);
    }
}
