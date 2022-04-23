using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsCanvas : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text _scoreText;

    private void Update()
    {
        _scoreText.text = "Score: " + Coin.Count.ToString();
    }
}
