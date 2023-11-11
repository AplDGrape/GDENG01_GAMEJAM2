using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {
    public static SFXManager Instance;

    [SerializeField]
    private AudioSource menuMusic;

    [SerializeField]
    private AudioSource levelMusic;

    [SerializeField]
    private AudioSource retryMusic;

    public void PlayMenuMusic() {
        this.menuMusic.Play();
    }

    public void PlayLevelMusic() {
        this.levelMusic.Play();
    }

    public void PlayRetryMusic() {
        this.retryMusic.Play();
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
