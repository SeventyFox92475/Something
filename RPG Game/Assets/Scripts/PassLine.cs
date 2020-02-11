using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassLine : MonoBehaviour
{
    public Collider2D collider;
    public Object line;
    public Transform obstacleTransform;
    public AudioSource scoreSound;
    public static int points = 0;
    // Start is called before the first frame update

    void Start()
    {
        collider.enabled = true;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player")
        {
            points++;
            Debug.Log(points);
            scoreSound.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * 5 * Time.deltaTime;
    }
}
