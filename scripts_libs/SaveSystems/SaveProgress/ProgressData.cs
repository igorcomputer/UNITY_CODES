using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Специальный атрибут - позволяет преобразовать данные класса в текстовый файл 
[System.Serializable]
public class ProgressData {
    public int Coins;
    public int Level;
    public float[] BackgroundColor;
    public bool IsMusicOn;

    // Конструктор объекта
    public ProgressData(Progress progress) {

        Coins = progress.Coins;
        Level = progress.Level;

        // Преобразование цвета из Unity
        // т.к. класс не наследуется от MonoBehaviour
        BackgroundColor = new float[4];
        BackgroundColor[0] = progress.BackgroundColor.r;
        BackgroundColor[1] = progress.BackgroundColor.g;
        BackgroundColor[2] = progress.BackgroundColor.b;
        BackgroundColor[3] = 100f; // альфа канал 
        IsMusicOn = progress.IsMusicOn;
    }
}
