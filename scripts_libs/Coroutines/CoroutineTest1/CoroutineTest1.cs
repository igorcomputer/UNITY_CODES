using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace scripts_libs.Coroutines.CoroutineTest1 {

    public class CoroutineTest1 : MonoBehaviour {

        public Transform MovableObject;

        public Transform PointA;
        public Transform PointB;

        void Start() {

            StartCoroutine(CoroutineSimple());

        }

        private IEnumerator CoroutineSimple() {

            yield return new WaitForSeconds(1f);

            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));

            yield return StartCoroutine(Utils.MoveToTarget(MovableObject, PointA));

            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));

            yield return StartCoroutine(Utils.MoveToTarget(MovableObject, PointB, 5f));

            yield return new WaitForSeconds(1f);

            Debug.Log("FINISH");

        }

    }

}
