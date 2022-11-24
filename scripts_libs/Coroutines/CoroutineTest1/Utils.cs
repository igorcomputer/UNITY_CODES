using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace scripts_libs.Coroutines.CoroutineTest1 {

    public static class Utils {
        public static IEnumerator MoveToTarget(Transform movableObject, Transform target, float animationDuration = 1f) {


            Vector3 startPosition = movableObject.position;

            float t = 0;
            while (t < 1) {
                movableObject.position = Vector3.Lerp(startPosition, target.position, t);
                t += Time.deltaTime / animationDuration;
                yield return null;
            }

            /*
            for (float t = 0; t < 1; t += Time.deltaTime / animationDuration) {
                movableObject.position = Vector3.Lerp(startPosition, target.position, t);
                yield return null;
            }
            */

        }
    }

}