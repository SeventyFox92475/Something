using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonController : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public bool readyToPlay = false;
    public Transform cameraTransform;
    public Sprite nextSprite;
    public Sprite prevSprite;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "Play Button" && Input.GetMouseButton(0))
            {
                spriteRenderer.sprite = nextSprite;
            } else
            {
                spriteRenderer.sprite = prevSprite;
            }

            if (Input.GetMouseButtonUp(0))
            {
                cameraTransform.position = new Vector3(0, 0, -10);
                readyToPlay = true;
            }
        }
        else
        {
            spriteRenderer.sprite = prevSprite;
        }
    }
}
