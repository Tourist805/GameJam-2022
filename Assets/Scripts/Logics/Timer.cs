using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _maxTime = 60f;
    public float MaxTime { get { return _maxTime; }set { _maxTime = value; } }

    [SerializeField] private static float _countDown = 0f;
    public static int CountDown { get { return (int)_countDown; } set { _countDown = (float)value; } }

    [SerializeField] private GameOverScreen _gameOverScreen;
    private bool _timerIsRunning = false;

    private void Start()
    {
        _countDown = _maxTime;
        _timerIsRunning = true;
    }

    private void Update()
    {
        if (_timerIsRunning)
        {
            if (_countDown > 0)
            {
                _countDown -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                _countDown = 0;
                _timerIsRunning = false;
                _gameOverScreen.ActivateWindow();
            }
        }
    }
}
