using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace scripts_libs.Coroutines.CoroutineMove {

    public class CoroutineMove : MonoBehaviour {

        public Transform MovableObject;

        public Transform PointA;
        public Transform PointB;

        public float duration = 2f;

        private IEnumerator _coroutineA;
        private IEnumerator _coroutineB;

        void Update() {

            if (Input.GetKeyDown(KeyCode.RightArrow)) {

                StopRoutineB();

                // To prevent Double Move
                if (_coroutineA == null) {
                    _coroutineA = MoveToTarget(MovableObject, PointA);
                    StartCoroutine(_coroutineA);
                    Debug.Log("MOVE --->");
                }

            }

            if (Input.GetKeyDown(KeyCode.LeftArrow)) {

                StopRoutineA();

                // To prevent Double Move
                if (_coroutineB == null) {
                    _coroutineB = MoveToTarget(MovableObject, PointB);
                    StartCoroutine(_coroutineB);
                    Debug.Log("<--- MOVE");
                }

            }

            if (Input.GetKeyDown(KeyCode.Space)) {
                StopRoutineA();
                StopRoutineB();
            }
        }

        private void StopRoutineA() {
            if (_coroutineA != null) {
                StopCoroutine(_coroutineA);
                _coroutineA = null;
            }
        }
        private void StopRoutineB() {
            if (_coroutineB != null) {
                StopCoroutine(_coroutineB);
                _coroutineB = null;
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