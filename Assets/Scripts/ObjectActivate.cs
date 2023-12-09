using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivate : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvas;
    public GameObject gameObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.gameObject.SetActive(true);
        }
    }
}
