using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager {  get; private set; }

    public HealthSystem _PlayerHealth = new HealthSystem(150,150);
    void Awake()
    {
        if (gameManager!=null&& gameManager!= this)
        { 
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
    }
}
