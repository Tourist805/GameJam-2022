using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsCanvas : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text _scoreText;
    [SerializeField] private TMPro.TMP_Text _timerText;

    private void Update()
    {
        _scoreText.text = "Score: " + Coin.Count.ToString();
        _timerText.text = "Time Left: " + Timer.CountDown.ToString();
    }
}
