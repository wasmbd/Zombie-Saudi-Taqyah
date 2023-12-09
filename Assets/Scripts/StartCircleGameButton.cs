using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartCircleGameButton : MonoBehaviour
{
    // Add references to your Yes and No buttons in the Inspector
    public Button PlayButton;
    public AudioSource CircleGameMUsic;


    // Add the scene name you want to load in the Inspector
   // public string sceneToLoad;

    private void Start()
    {   // Add button click listeners
        PlayButton.onClick.AddListener(OnYesButtonClicked);
    }
    public void OnYesButtonClicked()
    {
        CircleGameMUsic.Play();
    }
}
