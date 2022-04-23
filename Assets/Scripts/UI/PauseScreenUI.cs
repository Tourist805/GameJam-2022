using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreenUI : MonoBehaviour
{
    public void ActivateWindow()
    {
        gameObject.SetActive(true);
    }

    public void CloseWindow()
    {
        gameObject.SetActive(false);
    }

    public void Continue()
    {
        CloseWindow();
    }

    public void BackToMenu()
    {
        Debug.Log("Back to menu");
    }
}
