using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenMenu : MonoBehaviour
{
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject Canvas;
    void Start()
    {
        Canvas.SetActive(false);
    }

    public void StartFirstLevel()
    {
        SceneManager.LoadScene(0);
    }
}
