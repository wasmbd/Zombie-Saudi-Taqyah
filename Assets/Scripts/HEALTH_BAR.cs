using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HEALTH_BAR : MonoBehaviour
{
    Slider _HealthSlider;
    private void Start()
    {
        _HealthSlider= GetComponent<Slider>();
    }
   
    public void SetMaxHealth(int maxhealth)
    {
        _HealthSlider.maxValue = maxhealth;
        _HealthSlider.value = maxhealth;
    }
    public void SetHealth(int health)
    {
       
        _HealthSlider.value = health;
    }
}
