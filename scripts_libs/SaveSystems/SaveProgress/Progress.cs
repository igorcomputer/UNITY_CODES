using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour {

    // Параметры, которые нужно сохранять от уровня к уровню
    public int Coins;
    public int Level;
    public Color BackgroundColor;
    public bool IsMusicOn;

    public static Progress Instance;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            // Объект перемещается по всем сценам 
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
        LoadData();
    }

    public void SetLevel(int level) {
        Level = level;
        SaveData();
    }

    public void AddCoins(int value) {
        Coins += value;
        SaveData();
    }

    [ContextMenu("SaveData")]
    public void SaveData() {
        SaveSystem.Save(this);
    }

    [ContextMenu("LoadData")]
    public void LoadData() {

        ProgressData progressData = SaveSystem.Load();

        if (progressData != null) {
            Coins = progressData.Coins;
            Level = progressData.Level;

            Color color = new Color();
            color.r = progressData.BackgroundColor[0];
            color.g = progressData.BackgroundColor[1];
            color.b = progressData.BackgroundColor[2];
            color.a = 100f;
            BackgroundColor = color;

            IsMusicOn = progressData.IsMusicOn;
        } else {
            Coins = 0;
            Level = 1;
            BackgroundColor = Color.blue * 0.5f;
            IsMusicOn = true;
        }

    }

    [ContextMenu("DeleteDataFile")]
    public void DeleteDataFile() {
        SaveSystem.DeleteDataFile();
    }

}
