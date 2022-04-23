using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text _scoreText;

    public void ActivateWindow()
    {
        gameObject.SetActive(true);
    }

    private void Update()
    {
        _scoreText.text = "Your score: " + Coin.Count.ToString();
    }

    public void ResetLevel()
    {
        Debug.Log("Restarting the level");
    }

    public void BackToMenu()
    {
        Debug.Log("Back to menu");
    }
}
