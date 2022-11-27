using System;
using System.Collections;
using UnityEngine;

namespace scripts_libs.Coroutines.CoroutineMove2 {
    class CoroutineMove2 : MonoBehaviour {

        public Transform MovableObject;

        public Transform PointA;
        public Transform PointB;

        public float duration = 2f;

        private Coroutine _currentRoutine;

        void Start() {
            StartCoroutine(InitMoves());
        }

        private void MoveToA() {
            if (_currentRoutine != null) {
                StopCoroutine(_currentRoutine);
            }
            Debug.Log("MOVE --->");
            _currentRoutine = StartCoroutine(MoveToTarget(MovableObject, PointA));

        }

        private void MoveToB() {
            if (_currentRoutine != null) {
                StopCoroutine(_currentRoutine);
            }
            Debug.Log("<--- MOVE");
            _currentRoutine = StartCoroutine(MoveToTarget(MovableObject, PointB));
        }
        private void stopMoving() {
            if (_currentRoutine != null) {
                StopCoroutine(_currentRoutine);
            }
        }

        private IEnumerator InitMoves() {

            // The Same as Update method!  
            while (true) {
                if (Input.GetKeyDown(KeyCode.RightArrow)) {
                    MoveToA();
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                    MoveToB();
                }
                if (Input.GetKeyDown(KeyCode.Space)) {
                    stopMoving();
                }
                yield return null;
            }
        }

        private IEnumerator MoveToTarget(Transform movableObject, Transform target) {
            Vector3 startPosition = movableObject.position;
            for (float t = 0; t < 1; t += Time.deltaTime / duration) {
                movableObject.position = Vector3.Lerp(startPosition, target.position, t);
                yield return null;
            }
        }
    }
}
