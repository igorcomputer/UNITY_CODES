using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu_test : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI _coinsText;
    [SerializeField] private TextMeshProUGUI _levelText;
    [SerializeField] private Progress _progress;

    [SerializeField] Button _startButton; // Button

    private void Start() {
        _coinsText.text = _progress.Coins.ToString();
        _levelText.text = "Level " + _progress.Level.ToString();

        // Вешаем метод на событие onClick
        _startButton.onClick.AddListener(StartLevel);
    }

    // Метод загружает сцену 
    private void StartLevel() {
        SceneManager.LoadScene(_progress.Level);
    }
}
