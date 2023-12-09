using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] HEALTH_BAR _healthbar;
    [SerializeField] AudioSource _HUrtSound;
    void Start()
    {
        
    }
    void Update()
    {
       /* if(Input.GetKeyDown(KeyCode.H))
        {
            PlayerTakeDmg(20);
        }*/
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Zombie")
        {
            PlayerTakeDmg(20);
            _HUrtSound.Play();
        }
        if (other.gameObject.tag == "Heal")
        {
            PlayerTakeHeal(20);
        }
    }
    
    private void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager._PlayerHealth.DmgHealth(dmg);
        _healthbar.SetHealth(GameManager.gameManager._PlayerHealth.Health);

    }
    private void PlayerTakeHeal(int heal)
    {
        GameManager.gameManager._PlayerHealth.HealHealth(heal);
        _healthbar.SetHealth(GameManager.gameManager._PlayerHealth.Health);

    }
}
