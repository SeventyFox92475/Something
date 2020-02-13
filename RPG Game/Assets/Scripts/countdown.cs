using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countdown : MonoBehaviour
{
    PlayButtonController buttonScript;
    private float curTime;
    private float totTime;
    private float prevTime;
    public Sprite two;
    public Sprite one;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        GameObject playButton = GameObject.Find("Play Button");
        buttonScript = playButton.GetComponent<PlayButtonController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonScript.readyToPlay == true)
        {
            curTime = Time.time;
            if (curTime - prevTime > 1.0f)
            {
                spriteRenderer.sprite = two;
                if (curTime - prevTime > 2.0f)
                {
                    spriteRenderer.sprite = one;
                }
            }
        }
    }
}
