using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip pickUpSound;
    [SerializeField] int coinPickUpAmount;
  
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(pickUpSound, Camera.main.transform.position);
        FindObjectOfType<GameSession>().AddToScore(coinPickUpAmount);
        Destroy(gameObject);
    }
}
