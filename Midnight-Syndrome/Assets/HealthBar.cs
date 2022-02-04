using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider umbrella;

    public void SetMaxHealth(int health)
    {
        umbrella.maxValue = health;
        umbrella.value = health;
    }

    public void SetHealth(int health)
    {
        umbrella.value = health;
    }

}
