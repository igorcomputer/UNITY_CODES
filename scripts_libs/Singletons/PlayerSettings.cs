using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : MonoBehaviour {

    public string Name;
    public int Difficulty;

    public static PlayerSettings Instance;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void SetName(string name) {
        Name = name;
    }

    public void SetDifficulty(int value) {
        Difficulty = value + 1;
    }
}
