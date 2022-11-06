using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    [SerializeField] private BallSettings _ballSettings;
    [SerializeField] private Renderer _renderer;

    public void SetLevel(int level) {

        // Пример использования объекта ScriptableObject
        _renderer.material = _ballSettings.BallMaterials[level]; 
        // todo 
    }

}
