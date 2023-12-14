using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIController : MonoBehaviour {
    [Header("Timer")]
    public TMP_Text _timerText;
    public float _countdown = 60;
    [Header("Score")]
    public TMP_Text _scoreText;
    [Header("Camera")]
    public Camera _mainCamera;
    public Camera _secondaryCamera;
    [Header("GameOver")]
    public  GameObject _gameOver;
    public TMP_Text _scoreGameOver;

    private void Awake() {
        _mainCamera.gameObject.SetActive(true);
        _secondaryCamera.gameObject.SetActive(false);
    }

    private void Update() {
        TimerCountdown();
    }

    private void TimerCountdown() {
        _countdown -= Time.deltaTime;
        _timerText.text = _countdown.ToString();

        if (_countdown <= 0) {
            AudioManager.Instance.bgmSource.Stop();
            AudioManager.Instance.PlaySfx("GameOver");
            _timerText.text = "0";
            ChangeCamera();
            Invoke("GameOver", 2);
        }
    }

    private void GameOver() {
        _gameOver.SetActive(true);
        _scoreGameOver.text = _scoreText.text;
    }

    private void ChangeCamera() {
        _mainCamera.gameObject.SetActive(false);
        _secondaryCamera.gameObject.SetActive(true);
    }
}
