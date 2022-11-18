using System;
using UnityEngine;

namespace solid.DIP {

    // C помощью интерфейса мы абстрагируемся от конкретного юнита 
    // И можем работать с любой другой подвижной сущностью

    public interface IMovable {
        public void Move(Vector3 direction);
    }
    
    // Базовый класс (реализаует интерфейс IMovable) 
    public abstract class UnitMovable: MonoBehaviour, IMovable {
        public abstract void Move(Vector3 direction);
    }

    // Базовый функционал 
    public class UnitTransformMovable : UnitMovable {

        [SerializeField] private Transform unitTransform;

        public override void Move(Vector3 direction) {
            unitTransform.Translate(direction);
        }
    }

    // Расширение функционала 
    public class UnitRigidbodyMovable : UnitMovable {

        [SerializeField] private Rigidbody unitRigidbody;

        public override void Move(Vector3 direction) {

            Vector3 currentPosition = unitRigidbody.transform.position;
            unitRigidbody.MovePosition(currentPosition + direction);

        }
    }


}
