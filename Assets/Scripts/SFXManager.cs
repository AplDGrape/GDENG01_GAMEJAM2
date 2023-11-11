using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {
    public static SFXManager Instance;

    [SerializeField]
    private AudioSource menuMusic;

    [SerializeField]
    private AudioSource levelMusic;

    public void PlayMenuMusic() {
        this.menuMusic.Play();
    }

    public void PlayLevelMusic() {
        this.levelMusic.Play();
    }

    private void Awake() {
        if(Instance == null) {
            Instance = this;
        }
        else {
            Destroy(this.gameObject);
        }
    }
}
