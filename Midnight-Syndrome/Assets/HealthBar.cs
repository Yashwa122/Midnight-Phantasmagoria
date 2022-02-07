using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float maxHealth = 7;
    float minHealth = 0;
    public float currentHealth;

    [SerializeField]
    Slider umbrella;

    void Start()
    {
        umbrella.value = minHealth;
        currentHealth = umbrella.value;
    }


}
