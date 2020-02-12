using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite nextSprite;
    public Sprite prevSprite;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
        }
    }
}
