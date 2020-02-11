using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    //public Object Obstacle;
    //public Object obstacleClone;
    //public float timeBetweenObjects = 5.0f;
    //public float originalTimeBetweenObjects = 5.0f;
    //private float currentTime;
    //private float prevTime;
    //public float timeGap = 5.0f;
    public float obstacleVel;
    // Update is called once per frame
    void Start()
    {
        //prevTime = currentTime;
    }
    void Update()
    {
        // Scrapped due to errors
        /*
        currentTime = Time.time;
        Debug.Log(currentTime);
        if (currentTime - prevTime > timeGap)
        {
            Instantiate(Obstacle, new Vector2(0, 0), Quaternion.identity);
            prevTime = currentTime;
            timeGap += 5.0f;
        }
        */
        transform.position += Vector3.left * obstacleVel * Time.deltaTime;
    }
}
