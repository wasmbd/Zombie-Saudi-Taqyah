using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem 
{
    //fields
    private int _CurrentHealth;
    private int _CurrentMaxHealth;
    
    
    //Props
    public int Health
    {
        get { 
            return _CurrentHealth;
            }
        set { 
            _CurrentHealth = value;
            }

    }
    public int MaxHealth
    {
        get { return _CurrentMaxHealth; }
        set { _CurrentMaxHealth = value; }
    }
    //Constructor
    public HealthSystem(int health, int maxHealth)
    {
        _CurrentHealth = health;
        _CurrentMaxHealth = maxHealth;

    }
    //methods
    public void DmgHealth(int dmgAmount)
    {
        if (_CurrentHealth > 0)
        {
            _CurrentHealth -= dmgAmount;
        }
        if (_CurrentHealth == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void HealHealth(int healAmount)
    {
        if(_CurrentHealth <_CurrentMaxHealth)
        {
            _CurrentHealth += healAmount;
        }
        if(_CurrentHealth > _CurrentMaxHealth)
        {
            _CurrentHealth = _CurrentMaxHealth;
        }
    }


}
