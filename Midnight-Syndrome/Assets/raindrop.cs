using UnityEngine;

public class raindrop : MonoBehaviour
{
    HealthBar playerHealth;

    public float healthBonus = 1f;

    void Awake()
    {
        playerHealth = FindObjectOfType<HealthBar>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (playerHealth.currentHealth < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.currentHealth = playerHealth.currentHealth + healthBonus;
        }
    }
}
