using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D player;
    Vector2 movement;

    public int maxHealth = 7;
    public int currentHealth;

    public HealthBar Umbrella;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 0;
        Umbrella.SetMaxHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddHealth(1);
        }
    }

    void AddHealth(int raindrop)
    {
        currentHealth += raindrop;

        Umbrella.SetHealth(currentHealth);
    }

    private void FixedUpdate()
    {
        player.MovePosition(player.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}
