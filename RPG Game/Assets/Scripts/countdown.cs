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
    public AudioSource countDown;
    public AudioSource countDownFinal;
    private float time = 0f;
    private int num = 0;
    public bool readyToPlay = false;
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
            if (curTime - prevTime == 0.0f && num == 0)
            {
                countDown.Play();
                num++;
            }
            curTime = Time.time - time;

            if (curTime - prevTime >= 1.0f && num == 1)
            {
                spriteRenderer.sprite = two;
                countDown.Play();
                num++;
            }
            if (curTime - prevTime >= 2.0f && num == 2)
            {
                spriteRenderer.sprite = one;
                countDown.Play();
                num++;
            }
            if (curTime - prevTime >= 3.0f && num == 3)
            {
                spriteRenderer.sprite = null;
                countDownFinal.Play();
                readyToPlay = true;
                num++;
            }
            
        }
        else
        {
            time = Time.time;
        }
    }
}
