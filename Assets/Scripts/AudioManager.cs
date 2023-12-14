using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {
    public static AudioManager Instance;

    [Header("Source")]
    public AudioSource bgmSource;
    public AudioSource sfxSource;
    [Header("BGM")]
    public AudioClip _mainMenu;
    public AudioClip _gameplay;
    [Header("SFX")]
    public AudioClip _destroyAnimal;
    public AudioClip _eat;
    public AudioClip _gameOver;
    public AudioClip _throwFood;
    public AudioClip _UIClickBtn;

    private void Awake() {
        Instance = this;
        if (Instance == null) {
            //
        } else {
            Destroy(Instance);
        }

        bgmSource.clip = _mainMenu;
        bgmSource.Play();
    }

    private void Start() {
        bgmSource.clip = _mainMenu;
        bgmSource.Play();
    }

    public void PlayBgm(string name) {
        if (name == "MainMenu") {
            bgmSource.clip = _mainMenu;
            bgmSource.Play();
        } else {
            bgmSource.clip = _gameplay;
            bgmSource.Play();
        }
    }

    public void PlaySfx(string name) {
        if (name == "EnemyDeath") {
            sfxSource.PlayOneShot(sfxSource.clip = _destroyAnimal);
        } else if (name == "Eat") {
            sfxSource.PlayOneShot(sfxSource.clip = _eat);
        } else if (name == "GameOver") {
            sfxSource.PlayOneShot(sfxSource.clip = _gameOver);
        } else if (name == "Fire") {
            sfxSource.PlayOneShot(sfxSource.clip = _throwFood);
        } else if (name == "Click") {
            sfxSource.PlayOneShot(sfxSource.clip = _UIClickBtn);
        }
    }
}
