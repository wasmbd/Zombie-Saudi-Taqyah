using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource shoutingSound;
    public GameObject AA;
    // Start is called before the first frame update
    void Start()
    {
        shoutingSound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            shoutingSound.Play();
            Destroy(AA.gameObject, 0.4f);
        }
    }
}
