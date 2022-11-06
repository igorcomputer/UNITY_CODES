using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

    [Header("Dynamit")] // Устанавливает заголовок в инспекторе 

    [Range(0, 2)] public int Health = 2;

    [SerializeField] private float _affectRadius = 1.5f;

    [SerializeField] private GameObject[] _levels;

    [SerializeField] private GameObject _breackEffectPrefab;

    [SerializeField] private Animator _animator;

    [SerializeField] private Renderer _renderer;

    [SerializeField] private Text _text;

    [SerializeField] private Transform _visualTransform;

    [SerializeField] private SphereCollider _collider;

    [SerializeField] private SphereCollider _trigger;

    public Material[] BallMaterials;

    // Встроенные в Unity методы, такие как Start(), 
    // IDE Visual Studio подсвечивает синим цветом

    [ContextMenu("Die")]
    void Die() {
        Destroy(gameObject);
    }

    // Срабатывает, когда происходят изменения в инспекторе, 
    // Т.е можем визуально наблюдать изменение радиуса
    // (в данном случае, когда будем менять радиус руками: в игре или до старта игры)
    private void OnValidate() {
        _affectArea.transform.localScale = Vector3.one * _affectRadius * 2f;
    }

}

