using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject startButton;


    private void Start()
    {
        player.SetActive(false);
    }

    public void ReadyToStart()
    {
        player.SetActive(true);
        startButton.SetActive(false);
    }
}
