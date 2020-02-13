using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpPower;
    public Rigidbody2D rb;
    private bool isJumping = false;
    private bool isGrounded = false;
    public Transform GroundCheck1; // Put the prefab of the ground here
    public LayerMask groundLayer; // Insert the layer here.
    public Object Player;
    public AudioSource jumpSound;
    public AudioSource crashSound;
    public float rotationAngle = 35;
    Vector3 rotation;
    public float jumpSpeed = 5;
    public float rotationDecrement;
    PlayButtonController buttonScript;
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name != "LineToPass(Clone)")
        {
            Debug.Log("Crashed");
            crashSound.Play();
            Destroy(Player);

        }
    }
    void Start()
    {
        GameObject playButton = GameObject.Find("Play Button");
        buttonScript = playButton.GetComponent<PlayButtonController>();
    }
    void Update()
    {
        if (buttonScript.readyToPlay == true)
        {
            rb.isKinematic = false;
            GetComponent<PolygonCollider2D>().enabled = true;
            rotation = transform.localEulerAngles;
            // Jumping
            isGrounded = Physics2D.OverlapCircle(GroundCheck1.position, 1f, groundLayer); // checks if you are within 0.15 position in the Y of the ground
            if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && !isJumping) // both conditions can be in the same branch
            {
                jumpSound.Play();
                rb.velocity = Vector2.up * jumpSpeed;
                rotation.z = rotationAngle;
                rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse); // you need a reference to the RigidBody2D component
                isJumping = true;
            }
            if (rotation.z >= 270 || rotation.z <= 35)
            {
                rotation.z -= rotationDecrement;
            }
            transform.localEulerAngles = rotation;

            if (isGrounded)
            {
                isJumping = false;
            }
        }
        else
        {
            rb.isKinematic = true;
            GetComponent<PolygonCollider2D>().enabled = false;
        }
    }
}
