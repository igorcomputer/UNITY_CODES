using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // ВЫводит в редактор поля для структур 

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

}

