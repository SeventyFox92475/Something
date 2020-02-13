using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    PlayButtonController buttonScript;
    public float obstacleVel;
    void Start()
    {
        GameObject playButton = GameObject.Find("Play Button");
        buttonScript = playButton.GetComponent<PlayButtonController>();
    }
    void Update()
    {
        if (buttonScript.readyToPlay == true)
        {
            transform.position += Vector3.left * obstacleVel * Time.deltaTime;
        }
    }
}
