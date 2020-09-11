using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*NOT FULLY IMPLEMENTED INTO GAME YET. 
 * Time restriction for the game. User has to reach flag in under a minute
 */
public class Timer : MonoBehaviour
{
    public float start = 60;
    public Text timeText;

    // Use this for initialization
    void Start()
    {
        timeText.text = start.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        start -= Time.deltaTime;
        timeText.text = "Time Left: " + Mathf.Round(start).ToString();
       // Debug.Log(timeText.text);
    } 

}
