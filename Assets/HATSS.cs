using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HATSS : MonoBehaviour
{
    public GameObject[] hats;
    public int targetHatIndex = 0;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is a hat
        GameObject collidedHat = other.gameObject;
        if (IsHat(collidedHat))
        {
            int collidedHatIndex = GetHatIndex(collidedHat);

            // Check if the collided hat is the target hat
            if (collidedHatIndex == targetHatIndex)
            {
                ActivateHat(collidedHat);
                targetHatIndex = (targetHatIndex + 1) % hats.Length;
            }
        }
    }

    private bool IsHat(GameObject obj)
    {
        // Add appropriate check here based on your hat objects
        // For example, check if the object has a "Hat" tag
        return obj.CompareTag("Hat");
    }

    private int GetHatIndex(GameObject hat)
    {
        // Find the index of the hat in the hats array
        for (int i = 0; i < hats.Length; i++)
        {
            if (hats[i] == hat)
            {
                return i;
            }
        }

        // Hat not found in the array
        //
        return -1;
    }

    private void ActivateHat(GameObject hat)
    {
        // Add your hat activation logic here
        // For example, set the hat's active state to true
        hat.SetActive(true);
    }
}
