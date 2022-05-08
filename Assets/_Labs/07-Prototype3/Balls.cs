using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerCollection playerCollection = other.GetComponent<PlayerCollection>();

        if (playerCollection != null)
        {
            playerCollection.BallCollected();
            gameObject.SetActive(false);
        }
    }
}
