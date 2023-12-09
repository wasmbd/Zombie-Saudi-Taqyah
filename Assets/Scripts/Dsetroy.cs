using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dsetroy : MonoBehaviour
{
    public AudioSource CoinAudioCollect;
   
    void Start()
    {
        CoinAudioCollect = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            CoinAudioCollect.Play();

           // Debug.Log(coins);
            Destroy(other.gameObject);
        }
    }

}
