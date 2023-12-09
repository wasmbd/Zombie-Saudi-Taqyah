using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScenes : MonoBehaviour
{
    public Button button;
    public int SceneNumber;
    public Animator animator;
    private void Start()
    {
        // Add button click listeners
        button.onClick.AddListener(OnButtonClicked);
    }
    public void OnButtonClicked()
    {

        // Load the specified scene when the Yes button is clicked
        //  SceneManager.LoadScene(SceneNumber);
        StartCoroutine(TimeToLoadScene());
      //TimeToLoadScene();
    }
    private IEnumerator TimeToLoadScene()
    {
        animator.SetTrigger("End2");
        animator.SetBool("ENDD", true);
        yield return new WaitForSeconds(0.99f);
        SceneManager.LoadScene(SceneNumber);

    }
}
