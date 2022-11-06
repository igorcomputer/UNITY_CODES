using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public struct Task {
    public ItemType ItemType;
    public int Number;
    public int Level;
}

public class Level : MonoBehaviour {
    public int NumberOfBalls = 50;
    public int MaxCreatedBallLevel = 1;
    // Список задач на уровень (что нужно собрать)
    public Task[] Tasks;

    // Создаем Singleton из объекта, на котором висит скрипт 
    public static Level Instance; 

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }
    }

}
