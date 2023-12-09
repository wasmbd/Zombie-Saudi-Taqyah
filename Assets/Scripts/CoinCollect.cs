using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.Audio;
using UnityEngine.SceneManagement;
public class CoinCollect : MonoBehaviour
{
    private int coins = 0;
    public TextMeshProUGUI CoinText;
    public TextMeshProUGUI LevelLabel;
    private int Level=1;
    //public AudioSource CoinAudioCollect;

    private void Start()
    {
      //CoinAudioCollect = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coins++;
            CoinText.text = "Coins: " + coins.ToString();
         
            Destroy(other.gameObject);

            if (coins == 3)
            {
                Level = 2;
                LevelLabel.text = "Level: " + Level.ToString();
            }
            if (coins == 6)
            {
                Level = 3;
                LevelLabel.text = "Level: " + Level.ToString();
            }
            if (coins == 9)
            {
                Level = 4;
                LevelLabel.text = "Level: " + Level.ToString()+"what a hero!";
            }
            if (coins == 12)
            {
                Level = 5;
                LevelLabel.text = "Level: " + Level.ToString();
                StartCoroutine(ChangeText(LevelLabel));
                StartCoroutine(LoadToScene());
            }
        }

        

    }
    private IEnumerator LoadToScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(4);
    }
    private IEnumerator ChangeText(TextMeshProUGUI title)
    {
        yield return new WaitForSeconds(1);
        title.text = "FAntastic job";
    }



}
