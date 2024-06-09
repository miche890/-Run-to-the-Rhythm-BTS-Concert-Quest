using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private static Main instance;
    private bool isStarted = false;
    public AudioSource backgroundMusicAudioSource; // AudioSource para la música de fondo
    public AudioSource ambientAudioSource; // AudioSource para la musica ambiente

    public AudioSource footStepAudioSource;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        backgroundMusicAudioSource.Play(); // Reproduce la música de fondo siempre
        ambientAudioSource.Stop(); // Asegurarse de que el sonido no se reproduzca al inicio
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isStarted)
        {
            if (!ambientAudioSource.isPlaying) 
            {
                StartSound();
            }
        } else {
            if(footStepAudioSource.isPlaying) {
                footStepAudioSource.Stop();
            }
        }

    }

    public void SetIsStarted(bool isStarted)
    {
        this.isStarted = isStarted;
    }

    public static Main GetInstance()
    {
        return instance == null ? instance = new Main() : instance;
    }

    private void StartSound()
    {
        ambientAudioSource.Play();
    }
}
