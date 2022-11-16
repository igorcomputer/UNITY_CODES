using System.Collections;
using UnityEngine;

namespace SoundSnippets {
    public class SoundSnippets : MonoBehaviour {

        public AudioSource ShootSound;

        // Update is called once per frame
        void Start() {
            ShootSound.pitch = Random.Range(0.9f, 1.1f);
            ShootSound.volume = 0.5f;
            ShootSound.Play();
        }
    }
}

