using UnityEngine;
using UnityEngine.InputSystem;
public class Player_movement_control : MonoBehaviour
{
    //Variables//
    public Rigidbody2D rb;
    public float movespeed = 10.0f;
    private Vector2 movedirection;
    public InputActionReference move;

    public GameManager gm;
    private SpriteRenderer color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //add the rigidbody from the object when the game starts
        rb = GetComponent<Rigidbody2D>();

        //set the color to the sprite renderer
        color = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //add the direction of our movement from the reference of the new input system we made
        movedirection = move.action.ReadValue<Vector2>();
    }
    // fixed update is called once every physics frame
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x: movedirection.x * movespeed, y: movedirection.y * movespeed);
    }

    //on collision change the color of our sqaure
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //sends a message to the console
        Debug.Log("hit");
        //randomly changes color upon collision
        color.color = Random.ColorHSV();
    }

    //destroy the collectable on trigger enter//
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //destroy whatever I run into
        Destroy(collision.gameObject);

        //recreate the object that I destroyed
        gm.Respawn();

        //randomly changes color upon collision
        color.color = Random.ColorHSV();
    }


}
