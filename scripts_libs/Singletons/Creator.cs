using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Creator : MonoBehaviour {
    private int _ballsLeft;

    private void Start() {

        // Получаем данные из объекта Singleton 
        // (из его поля, в котором находится сам объект)
        _ballsLeft = Level.Instance.NumberOfBalls;

    }
}