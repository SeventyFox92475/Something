using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObstacles : MonoBehaviour
{
    public Object obstacle;
    private float currentTime;
    private float prevTime;
    public float timeGap;
    public float objectGap;
    public Object LineToPass;
    public Transform LineToPassTransform;
    private float randy;

    // Update is called once per frame
    void Start()
    {
        randy = Random.Range(5.0f, 10.0f);
        Instantiate(LineToPass, new Vector2(10, randy), Quaternion.identity);
        Instantiate(obstacle, new Vector2(10, randy), Quaternion.identity);
        Instantiate(obstacle, new Vector2(10, randy - objectGap), Quaternion.identity);
    }
    void Update()
    {
        currentTime = Time.time;
        if (currentTime - prevTime > timeGap)
        {
            randy = Random.Range(5.0f, 10.0f);
            Instantiate(LineToPass, new Vector2(10, randy), Quaternion.identity);
            Instantiate(obstacle, new Vector2(10, randy), Quaternion.identity);
            Instantiate(obstacle, new Vector2(10, randy - objectGap), Quaternion.identity);
            prevTime = currentTime;
        }

    }
}
