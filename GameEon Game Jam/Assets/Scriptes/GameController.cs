using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject HowToPlayPanel;
    [SerializeField] GameObject GameCompletePanel;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
        HowToPlayPanel.SetActive(true);
    }

    public void TaptoStartButton()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        HowToPlayPanel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameCompletePanel.SetActive(true);
        }
    }
}
